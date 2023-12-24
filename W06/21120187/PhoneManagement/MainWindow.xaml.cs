using PhoneManagement.BUS;
using PhoneManagement.Config;
using PhoneManagement.DAO;
using PhoneManagement.DTO;
using PhoneManagement.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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

        

        PhoneBUS _phoneBUS;
        BindingList<Phone> _listPhoneOrigin;
        List<Phone> _currentList;
        List<Phone> tempList;
        private int _currentPage = 1;
        private int _rowsPerPage;
        private int _totalItems = 0;
        private int _totalPages = 0;
        private int _currentCurrency = 0;
        private int? _currentStartPrice = null;
        private int? _currentEndPrice = null;
        private string keyword = "";

        public Tuple<int, int, int?, int?> getCurrentState()
        {
            return new Tuple<int, int, int?, int?>
                (
                    _currentPage,
                    _currentCurrency,
                    _currentStartPrice,
                    _currentEndPrice
                );
        }

        public MainWindow()
        {
            InitializeComponent();
            _phoneBUS = new PhoneBUS();
            _listPhoneOrigin = new BindingList<Phone>();
            tempList = new List<Phone>();
            _currentList = new List<Phone>();
            _currentPage = 1;
            _currentStartPrice = null;
            _currentEndPrice = null;
            _currentCurrency = 0;
            _rowsPerPage = _phoneBUS.getRowPerPage();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            
            _listPhoneOrigin = _phoneBUS.getAllPhone();
            _currentList = _listPhoneOrigin.ToList();
           
            updateDataSource(_currentPage, _currentCurrency, _currentStartPrice, _currentEndPrice, _currentList);
        }


        private void updateDataSource(int page = 1, int currentCurrency = 0, int? currentStartPrice = null, int? currentEndPrice = null, List<Phone>? _currentList = null)
        {
            if (_currentList == null)
            {
                _currentList = _listPhoneOrigin.ToList();
            }
            var listPhone = _currentList
               .Where((item) =>
               {

                   bool checkPrice = (item.Price >= currentStartPrice && item.Price <= currentEndPrice) ||
                   (currentStartPrice == null && currentEndPrice == null) || currentStartPrice == null || currentEndPrice == null;

                   return checkPrice;
               });

            _currentPage = page;

            _totalItems = listPhone.ToList().Count;
            _totalPages = listPhone.ToList().Count / _rowsPerPage +
                (listPhone.ToList().Count % _rowsPerPage == 0 ? 0 : 1);
            

            if (_currentPage >= _totalPages)
            {
                _currentPage = _totalPages;
                LastButton.IsEnabled = false;
                NextButton.IsEnabled = false;
            }
            else
            {
                LastButton.IsEnabled = true;
                NextButton.IsEnabled = true;
            }

            if (_currentPage == 1)
            {
                FirstButton.IsEnabled = false;
                PrevButton.IsEnabled = false;
            }

            if (_currentPage == 1)
            {
                if (_totalPages > 1)
                {
                    NextButton.IsEnabled = true;
                    LastButton.IsEnabled = true;
                }
                else
                {
                    NextButton.IsEnabled = false;
                    LastButton.IsEnabled = false;
                }
            }
            
            
            if (_currentList.Count == 0)
            {
                MessageText.Text = "Opps! Không tìm thấy bất kì sản phẩm nào.";
            }

            tempList = listPhone
                .Skip((_currentPage - 1) * _rowsPerPage)
                .Take(_rowsPerPage).ToList();

            phoneListView.ItemsSource = tempList;

            if (currentCurrency != 0)
            {
                PriceCombobox.SelectedIndex = currentCurrency;
            }
            pageInfoTextBlock.Text = $"{_currentPage}/{_totalPages}";
            
        }


        private void RemovePhone_Click(object sender, RoutedEventArgs e)
        {
            var p = (Phone)phoneListView.SelectedItem;
            if (p != null)
            {
                var result = MessageBox.Show($"Bạn thật sự muốn xóa điện thoại {p.Name} - {p.Manufacturer}?",
               "Xác nhận xóa", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (result == MessageBoxResult.Yes)
                {
                    _phoneBUS.deletePhone(p);
                    _listPhoneOrigin.Remove(p);
                    _currentList.Clear();
                    _currentList = _listPhoneOrigin.ToList();
                    updateDataSource(_currentPage, _currentCurrency, _currentStartPrice, _currentEndPrice, _currentList);
                }
            }
            
           else
            {
                MessageBox.Show("Please choose an item to delete");
            }
        }

        private void UpdatePhone_Click(object sender, RoutedEventArgs e)
        {
            
            var p = (Phone)phoneListView.SelectedItem;
            if (p != null)
            {
               
                var screen = new UpdatePhone(p);
                screen.WindowStartupLocation = WindowStartupLocation.CenterScreen;
                var result = screen.ShowDialog();
                if (result == true)
                {
                    var info = screen.updatePhone;
                    p.Name = info.Name;
                    p.Manufacturer = info.Manufacturer;
                    p.Price = info.Price;
                    p.ImagePath = info.ImagePath;
                    updateDataSource(_currentPage, _currentCurrency, _currentStartPrice, _currentEndPrice, _currentList);

                    try
                    {
                        _phoneBUS.updatePhone(p);

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
                    _listPhoneOrigin.Add(newPhone);
                    _currentList.Clear();
                    _currentList = _listPhoneOrigin.ToList();
                    updateDataSource(_currentPage, _currentCurrency, _currentStartPrice, _currentEndPrice, _currentList);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(screen, ex.Message);
                }

            }
        }

        private void ListViewItem_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

        }

        private void phoneListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void FirstButton_Click(object sender, RoutedEventArgs e)
        {
            if (_totalPages <= 1)
            {
                NextButton.IsEnabled = false;
                LastButton.IsEnabled = false;
            }
            updateDataSource(1, _currentCurrency, _currentStartPrice, _currentEndPrice, _currentList);
        }

        private void PrevButton_Click(object sender, RoutedEventArgs e)
        {
            NextButton.IsEnabled = true;
            LastButton.IsEnabled = true;
            _currentPage--;
            
            updateDataSource(_currentPage, _currentCurrency,_currentStartPrice, _currentEndPrice, _currentList);
            if (_currentPage - 1 < 1)
            {
                PrevButton.IsEnabled = false;
                FirstButton.IsEnabled = false;
            }
        }

        private void NextButton_Click(object sender, RoutedEventArgs e)
        {
            PrevButton.IsEnabled = true;
            FirstButton.IsEnabled = true;
            _currentPage++;
           
            updateDataSource(_currentPage, _currentCurrency, _currentStartPrice, _currentEndPrice, _currentList);
            if (_currentPage + 1 > _totalPages)
            {
                NextButton.IsEnabled = false;
                LastButton.IsEnabled = false;
            }
        }

        private void LastButton_Click(object sender, RoutedEventArgs e)
        {
            if (_totalPages > 1)
            {
                FirstButton.IsEnabled = true;
                PrevButton.IsEnabled = true;
            }
            updateDataSource(_totalPages, _currentCurrency, _currentStartPrice, _currentEndPrice, _currentList);
        }

        private void SearchTermTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            string search_text = SearchTermTextBox.Text;
            if (search_text.Length > 0)
            {
                _currentPage = 1;
                PrevButton.IsEnabled = false;
                FirstButton.IsEnabled = false;

                tempList.Clear();
                BindingList<Phone> phones = new BindingList<Phone>();
                foreach (Phone phone in _currentList)
                {
                    if (phone.Name.ToLower().Contains(search_text.ToLower()))
                    {
                        phones.Add(phone);
                    }
                }

                tempList = phones
                .Skip((_currentPage - 1) * _rowsPerPage)
                .Take(_rowsPerPage).ToList();

                if (tempList.Count > 0)
                {
                    _currentPage = 1;
                    _totalItems = phones.Count;
                    _totalPages = phones.Count / _rowsPerPage +
                    (phones.Count % _rowsPerPage == 0 ? 0 : 1);
                    phoneListView.ItemsSource = tempList;
                    pageInfoTextBlock.Text = $"{_currentPage}/{_totalPages}";
                }
                if (_totalPages <= 1)
                {
                    NextButton.IsEnabled = false;
                    LastButton.IsEnabled = false;
                }
            }
            else
            {
                updateDataSource(1);
            }
        }

        private void PriceCombobox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (PriceCombobox.SelectedIndex >= 0)
            {
                //Giá dưới 5 triệu
                if (PriceCombobox.SelectedIndex == 1)
                {
                    _currentStartPrice = 0;
                    _currentEndPrice = 5000000;
                    _currentCurrency = 1;
                    updateDataSource(1, _currentCurrency, _currentStartPrice, _currentEndPrice, _currentList);
                    
                }
                // Giá từ 5 triệu đến 10 triệu
                if (PriceCombobox.SelectedIndex == 2)
                {
                    _currentStartPrice = 5000000;
                    _currentEndPrice = 10000000;
                    _currentCurrency = 2;
                    updateDataSource(1, _currentCurrency, _currentStartPrice, _currentEndPrice, _currentList);
                    
                }
                // Giá dưới 10 triệu đến 15 triệu
                if (PriceCombobox.SelectedIndex == 3)
                {
                    _currentStartPrice = 10000000;
                    _currentEndPrice = 15000000;
                    _currentCurrency = 3;
                    updateDataSource(1, _currentCurrency, _currentStartPrice, _currentEndPrice, _currentList);
                    
                }
                // Giá trên 15 triệu
                if (PriceCombobox.SelectedIndex == 4)
                {
                    _currentStartPrice = 15000000;
                    _currentEndPrice = int.MaxValue;
                    _currentCurrency = 4;
                    updateDataSource(1, _currentCurrency, _currentStartPrice, _currentEndPrice, _currentList);
                    
                }

                if (PriceCombobox.SelectedIndex == 5)
                {
                    _currentStartPrice = null;
                    _currentEndPrice = null;
                    _currentCurrency = 5;
                    updateDataSource(1, _currentCurrency, null, null, _currentList);
                    
                }
            }
        }

        private void SortCombobox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (SortCombobox.SelectedIndex >= 0)
            {
                // Sort A-Z
                if (SortCombobox.SelectedIndex == 1)
                {
                    
                    _currentList = _phoneBUS.MergeSort(_currentList, _phoneBUS.ComparePhonesByNameInCreasing);
                   
                    updateDataSource(1, _currentCurrency, _currentStartPrice, _currentEndPrice, _currentList);

                }
                // Sort Z-A
                if (SortCombobox.SelectedIndex == 2)
                {
               
                    _currentList = _phoneBUS.MergeSort(_currentList, _phoneBUS.ComparePhonesByNameDeCreasing);
                  
                    updateDataSource(1, _currentCurrency, _currentStartPrice, _currentEndPrice, _currentList);

                }

                if (SortCombobox.SelectedIndex == 3)
                {
                    _currentList = _phoneBUS.MergeSort(_currentList, _phoneBUS.ComparePhonesByPriceDecreasing);

                    updateDataSource(1, _currentCurrency, _currentStartPrice, _currentEndPrice, _currentList);
                }

                if (SortCombobox.SelectedIndex == 4)
                {
                    _currentList = _phoneBUS.MergeSort(_currentList, _phoneBUS.ComparePhonesByPriceIncreasing);

                    updateDataSource(1, _currentCurrency, _currentStartPrice, _currentEndPrice, _currentList);
                }

                if (SortCombobox.SelectedIndex == 5)
                {
                    _currentList.Clear();
                    _currentList = _listPhoneOrigin.ToList();
                    updateDataSource(1, _currentCurrency, null, null, _currentList);

                }
            }
        }

        private void Setting_Click(object sender, RoutedEventArgs e)
        {
            var settingScreen = new Configuration();
            settingScreen.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            settingScreen.ShowDialog();

            _rowsPerPage = int.Parse(AppConfig.GetValue(AppConfig.NumberProductPerPage));

            updateDataSource(_currentPage, _currentCurrency, _currentStartPrice, _currentEndPrice, _currentList);
        }
    }
}
