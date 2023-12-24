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
    /// Interaction logic for UpdatePhone.xaml
    /// </summary>
    public partial class UpdatePhone : Window
    {

        public FileInfo? _selectedImage = null;
        private bool _isImageChanged = false;
        private PhoneBUS _phoneBUS;
        public Phone updatePhone { get; set; }
        public UpdatePhone(Phone info)
        {
            InitializeComponent();
            _phoneBUS = new PhoneBUS();
            updatePhone = (Phone)info.Clone();
            this.DataContext = updatePhone;
        }

        private void UpdateImageButton_Click(object sender, RoutedEventArgs e)
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

                updateImage.Source = bitmap;

            }
        }

        private void SaveProduct_Click(object sender, RoutedEventArgs e)
        {
            if (_isImageChanged)
            {

                int id = updatePhone.ID;
                string key = Guid.NewGuid().ToString();
                updatePhone.ImagePath = _phoneBUS.uploadImage(_selectedImage, id, key);
            }


            MessageBox.Show("Update phone success", "Notice", MessageBoxButton.OK);
            DialogResult = true;
        }
    }
}
