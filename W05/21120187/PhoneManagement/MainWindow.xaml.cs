using PhoneManagement.BUS;
using PhoneManagement.DTO;
using PhoneManagement.ViewModel;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PhoneManagement
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        PhoneViewModel _phoneVM = new PhoneViewModel();
        List<PhoneDTO?> phones = null;
        PhoneBUS _phoneBUS = new PhoneBUS();


        private void AddOrder_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AddPhone_Click(object sender, RoutedEventArgs e)
        {
           
            var screen = new AddPhone();
            screen.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            var result = screen.ShowDialog();
            if (result == true)
            {
                try
                {
                    var newPhone = screen.newPhone;
                    _phoneVM.Phones.Add(newPhone);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(screen, ex.Message);
                }
                
            }
        }

        
        private void UpdatePhone_Click(object sender, RoutedEventArgs e)
        {
            int updateIndex = phoneListView.SelectedIndex;
            if (updateIndex != -1)
            {
                PhoneDTO selectedPhone = _phoneVM.Phones[updateIndex];
                var screen = new UpdatePhone(selectedPhone);
                screen.WindowStartupLocation = WindowStartupLocation.CenterScreen;
                var result = screen.ShowDialog();
                if (result == true)
                {
                    

                    var info = screen.updatePhone;
                    selectedPhone.Name = info.Name;
                    selectedPhone.Manufacturer = info.Manufacturer;
                    selectedPhone.Price = info.Price;
                    selectedPhone.ImagePath = info.ImagePath;

                    try
                    {
                        _phoneVM.updatePhone(selectedPhone);

                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine("Exception here");
                        MessageBox.Show(screen, ex.Message);
                    }
                }
                else
                {
                    
                }
                
                
            }
            else
            {
                MessageBox.Show("Please choose an item to update");
            }
        }

        private void RemovePhone_Click(object sender, RoutedEventArgs e)
        {
            int removeIndex = phoneListView.SelectedIndex;
            if (removeIndex != -1)
            {
                PhoneDTO selectedPhone = _phoneVM.Phones[removeIndex];
                _phoneVM.deletePhone(selectedPhone);
                _phoneVM.Phones.RemoveAt(removeIndex);
            }
            else
            {
                MessageBox.Show("Please choose an item to delete");
            }
        }

        private void ListViewItem_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            /*phones = _phoneBUS.getAllPhone();
            phoneListView.ItemsSource = phones;*/
            phoneListView.ItemsSource = _phoneVM.Phones;
        }

        private void phoneListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
