using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using static System.Reflection.Metadata.BlobBuilder;

namespace Employees
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

        BindingList<Employee> employees = null;
        List<Employee> newEmployee = null;
        private int newEmployeeIndex = 0;

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            // add 1 employee at a time, max = 2
            if (newEmployeeIndex < 2)
            {
                employees.Add(newEmployee[newEmployeeIndex]);
                newEmployeeIndex++;
            }
            else
            {
                MessageBox.Show("Out of employee to add! Sorry!");
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            int removeIndex = employeeListView.SelectedIndex;
            if (removeIndex != -1)
            {
                employees.RemoveAt(removeIndex);
            }
            else
            {
                MessageBox.Show("Please choose an item to delete");
            }
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            int updateIndex = employeeListView.SelectedIndex;
            if (updateIndex != -1)
            {
                employees[updateIndex].FullName = "Luong Thi Mai";
                employees[updateIndex].Email = "LuongThiMai@gmail.com";
                employees[updateIndex].Address = "Dong Thap";
                employees[updateIndex].TelephoneNumber = "0234567890";
                employees[updateIndex].Avatar = "images/avatar13.jpg";
            }
            else
            {
                MessageBox.Show("Please choose an item to update");
            }
        }



        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            employees = new BindingList<Employee>()
            {
                new Employee(){FullName = "Nguyen Van Toan", Email = "NguyenVanToan@gmail.com", Address = "Ho Chi Minh City", TelephoneNumber = "0987654321", Avatar = "images/avatar01.jpg"},
                new Employee { FullName = "Tran Thi Hoa", Email = "TranThiHoa@gmail.com", Address = "Hanoi", TelephoneNumber = "0123456789", Avatar = "images/avatar02.jpg" },
                new Employee { FullName = "Le Van Khanh", Email = "LeVanKhanh@gmail.com", Address = "Da Nang", TelephoneNumber = "0909090909", Avatar = "images/avatar03.jpg" },
                new Employee { FullName = "Pham Quoc Thang", Email = "PhamQuocThang@gmail.com", Address = "Can Tho", TelephoneNumber = "0369852147", Avatar = "images/avatar04.jpg" },
                new Employee { FullName = "Nguyen Thi Minh", Email = "NguyenThiMinh@gmail.com", Address = "Vung Tau", TelephoneNumber = "0777888999", Avatar = "images/avatar05.jpg" },
                new Employee { FullName = "Hoang Minh Tuan", Email = "HoangMinhTuan@gmail.com", Address = "Quang Ngai", TelephoneNumber = "0333666999", Avatar = "images/avatar06.jpg" },
                new Employee { FullName = "Vo Van Hieu", Email = "VoVanHieu@gmail.com", Address = "Dak Lak", TelephoneNumber = "0555555555", Avatar = "images/avatar07.jpg" },
                new Employee { FullName = "Tran Thi Thu", Email = "TranThiThu@gmail.com", Address = "Phu Yen", TelephoneNumber = "0777123456", Avatar = "images/avatar08.jpg" },
                new Employee { FullName = "Do Quang Long", Email = "DoQuangLong@gmail.com", Address = "Bac Ninh", TelephoneNumber = "0888888888", Avatar = "images/avatar09.jpg" },
                new Employee { FullName = "Le Thi My", Email = "LeThiMy@gmail.com", Address = "Thai Binh", TelephoneNumber = "0666666666", Avatar = "images/avatar10.jpg" },
            };
            employeeListView.ItemsSource = employees;

            newEmployee = new List<Employee>()
            {
                new Employee { FullName = "Nguyen Van An", Email = "NguyenVanAn@gmail.com", Address = "Hue", TelephoneNumber = "0999999999", Avatar = "images/avatar11.jpg" },
                new Employee { FullName = "Trinh Thanh Tung", Email = "TrinhThanhTung@gmail.com", Address = "Nha Trang", TelephoneNumber = "0111222333", Avatar = "images/avatar12.jpg" },
            };
        }
    }
}
