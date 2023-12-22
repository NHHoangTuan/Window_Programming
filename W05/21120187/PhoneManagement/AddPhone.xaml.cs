using Microsoft.Win32;
using PhoneManagement.BUS;
using PhoneManagement.DAO;
using PhoneManagement.DTO;
using PhoneManagement.ViewModel;
using System;
using System.Collections.Generic;
using System.IO;
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
using System.Windows.Shapes;

namespace PhoneManagement
{
    /// <summary>
    /// Interaction logic for AddPhone.xaml
    /// </summary>
    public partial class AddPhone : Window
    {

        private FileInfo? _selectedImage = null;
        private PhoneBUS _phoneBUS;
        private bool _isImageChanged = false;
        private PhoneViewModel _phoneVM;
        public PhoneDTO newPhone {  get; set; }

        public AddPhone()
        {
            InitializeComponent();
            _phoneBUS = new PhoneBUS();
            _phoneVM = new PhoneViewModel();
            newPhone = new PhoneDTO();
            this.DataContext = newPhone;
        }

        

        private void SaveProduct_Click(object sender, RoutedEventArgs e)
        {
            if (_selectedImage == null)
            {
                MessageBox.Show("Please enter image");
                return;
            }

            int id = _phoneBUS.saveProduct(newPhone);
            string key = Guid.NewGuid().ToString();
            newPhone.ImagePath = _phoneBUS.uploadImage(_selectedImage, id, key);
            MessageBox.Show("Add phone success", "Notice", MessageBoxButton.OK);
            DialogResult = true;

            /*var phoneDTO = new PhoneDTO();

            phoneDTO.Name = NameTermTextBox.Text;
            phoneDTO.Manufacturer = ManufacturerTermTextBox.Text;
            phoneDTO.Price = int.Parse(PriceTermTextBox.Text);

            int id = _phoneBUS.saveProduct(phoneDTO);
            string key = Guid.NewGuid().ToString();

            phoneDTO.ImagePath = _phoneBUS.uploadImage(_selectedImage, id, key);

            MessageBox.Show("Add phone success", "Notice", MessageBoxButton.OK);
            _phoneVM.addPhone(phoneDTO);

            
            Close();*/


        }

        private void AddImageButton_Click(object sender, RoutedEventArgs e)
        {
            var screen = new OpenFileDialog();
            screen.Filter = "Files|*.png; *.jpg; *.jpeg;";
            if (screen.ShowDialog() == true)
            {
                _isImageChanged = true;
                _selectedImage = new FileInfo(screen.FileName);

                var bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri(screen.FileName, UriKind.Absolute);
                bitmap.EndInit();

                AddedImage.Source = bitmap;
                
            }

            /*var screen = new OpenFileDialog();
            if (screen.ShowDialog() == true)
            {
                _selectedImage = new FileInfo(screen.FileName);
                var bitmap = new BitmapImage(new Uri(screen.FileName, UriKind.Absolute));
                AddedImage.Source = bitmap;
                newPhone.ImagePath = screen.FileName;
            }*/
        }
    }
}
