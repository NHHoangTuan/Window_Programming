using System;
using System.Collections.Generic;
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

namespace DataBindingOneObject
{
    /// <summary>
    /// Interaction logic for MobilePhoneWindow.xaml
    /// </summary>
    public partial class MobilePhoneWindow : Window
    {
        public MobilePhoneWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var mobilephone = new MobilePhone()
            {
                Name = "Iphone 15",
                ImagePath = "images/phone01.jpg",
                Manufacturer = "Apple",
                Price = 27000000
            };

            this.DataContext = mobilephone;

        }
    }
}
