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
    /// Interaction logic for EmployeeWindow.xaml
    /// </summary>
    public partial class EmployeeWindow : Window
    {
        public EmployeeWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var employee = new Employee()
            {
                FullName = "Nguyen Van A",
                Address = "Ho Chi Minh City",
                Email = "NguyenVanA@gmail.com",
                TelephoneNumber = "0987654321",
                Avatar = "images/avatar01.jpg"
            };

            this.DataContext = employee;
        }
    }
}
