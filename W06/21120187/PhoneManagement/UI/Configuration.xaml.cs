using PhoneManagement.Config;
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

namespace PhoneManagement.UI
{
    /// <summary>
    /// Interaction logic for Configuration.xaml
    /// </summary>
    public partial class Configuration : Window
    {

        private string nPhonePerPage = "5";
        public Configuration()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void saveButton_Click(object sender, RoutedEventArgs e)
        {
            var item = (ComboBoxItem)nProductComboBox.SelectedValue;

            var content = "";

            if (item != null)
            {
                content = (string)item.Content;
            }

            if (content != "")
                AppConfig.SetValue(AppConfig.NumberProductPerPage, content);

            Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if (AppConfig.GetValue(AppConfig.NumberProductPerPage) != null)
            {
                nPhonePerPage = AppConfig.GetValue(AppConfig.NumberProductPerPage);
            }

            
            if (nPhonePerPage == "3")
                nProductComboBox.SelectedIndex = 0;
            else if (nPhonePerPage == "4")
                nProductComboBox.SelectedIndex = 1;
            else if (nPhonePerPage == "5")
                nProductComboBox.SelectedIndex = 2;
            else if (nPhonePerPage == "6")
                nProductComboBox.SelectedIndex = 3;
            else if (nPhonePerPage == "7")
                nProductComboBox.SelectedIndex = 4;
            else if (nPhonePerPage == "8")
                nProductComboBox.SelectedIndex = 5;
            else if (nPhonePerPage == "9")
                nProductComboBox.SelectedIndex = 6;
            else if (nPhonePerPage == "10")
                nProductComboBox.SelectedIndex = 7;
            else if (nPhonePerPage == "11")
                nProductComboBox.SelectedIndex = 8;
            else if (nPhonePerPage == "12")
                nProductComboBox.SelectedIndex = 9;
        }
    }
}
