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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DataBindingOneObject
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

        private void btnBook_Click(object sender, RoutedEventArgs e)
        {
            var bookWindow = new BookWindow();
            bookWindow.ShowDialog();
        }

        private void btnMobilePhone_Click(object sender, RoutedEventArgs e)
        {
            var mobilephoneWindow = new MobilePhoneWindow();
            mobilephoneWindow.ShowDialog();
        }

        private void btnEmployee_Click(object sender, RoutedEventArgs e)
        {
            var employeeWindow = new EmployeeWindow();
            employeeWindow.ShowDialog();
        }
    }
}
