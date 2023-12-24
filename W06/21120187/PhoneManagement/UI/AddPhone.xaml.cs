using Microsoft.Win32;
using PhoneManagement.BUS;
using PhoneManagement.DAO;
using PhoneManagement.DTO;
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

namespace PhoneManagement.UI
{
    /// <summary>
    /// Interaction logic for AddPhone.xaml
    /// </summary>
    public partial class AddPhone : Window
    {
        private FileInfo? _selectedImage = null;
        private PhoneBUS _phoneBUS;
        private bool _isImageChanged = false;
        public Phone newPhone { get; set; }
        public AddPhone()
        {
            InitializeComponent();
            _phoneBUS = new PhoneBUS();
            newPhone = new Phone();
            this.DataContext = newPhone;
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
            newPhone.ID = id;
            MessageBox.Show("Add phone success", "Notice", MessageBoxButton.OK);
            DialogResult = true;
        }
    }
}
