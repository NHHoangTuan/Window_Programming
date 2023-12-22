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

namespace MobilePhones
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

        BindingList<MobilePhone> mobilePhones = null;
        List<MobilePhone> newPhones = null;
        private int newPhoneIndex = 0;

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            mobilePhones = new BindingList<MobilePhone>()
            {
                new MobilePhone(){ Name = "iPhone 13 Pro Max", Manufacturer = "Apple",Price = 1299, ImagePath = "images/phone01.jpg"},
                new MobilePhone(){ Name = "iPhone 13 Pro", Manufacturer = "Apple", Price = 999, ImagePath = "images/phone02.jpg"},
                new MobilePhone(){ Name = "iPhone 13", Manufacturer = "Apple", Price = 799, ImagePath = "images/phone03.jpg"},
                new MobilePhone(){ Name = "iPhone 13 Mini", Manufacturer = "Apple", Price = 699, ImagePath = "images/phone04.jpg"},
                new MobilePhone(){ Name = "Samsung Galaxy Note 20 Ultra", Manufacturer = "Samsung", Price = 949, ImagePath = "images/phone05.jpg"},
                new MobilePhone(){ Name = "Samsung Galaxy S21 Ultra", Manufacturer = "Samsung", Price = 999, ImagePath = "images/phone06.jpg"},
                new MobilePhone(){ Name = "Samsung Galaxy S21+", Manufacturer = "Samsung", Price = 899, ImagePath = "images/phone07.jpg"},
                new MobilePhone(){ Name = "Samsung Galaxy S20 Ultra", Manufacturer = "Samsung", Price = 799, ImagePath = "images/phone08.jpg"},
                new MobilePhone(){ Name = "Xiaomi Mi 11 5G", Manufacturer = "Xiaomi", Price = 699, ImagePath = "images/phone09.jpg"},
                new MobilePhone(){ Name = "Xiaomi Mi 10T Pro", Manufacturer = "Xiaomi", Price = 549, ImagePath = "images/phone10.jpg"},
            };

            mobilephoneListView.ItemsSource = mobilePhones;

            newPhones = new List<MobilePhone>()
            {
                new MobilePhone(){Name = "Realme 8", Manufacturer = "Realme", Price = 349, ImagePath = "images/phone11.jpg"},
                new MobilePhone(){Name = "Realme 8 Pro", Manufacturer = "Realme", Price = 399, ImagePath = "images/phone12.jpg"}
            };
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            // add 1 phone at a time, max = 2
            if (newPhoneIndex < 2)
            {
                mobilePhones.Add(newPhones[newPhoneIndex]);
                newPhoneIndex++;
            }
            else
            {
                MessageBox.Show("Out of phone to add! Sorry!");
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            int removeIndex = mobilephoneListView.SelectedIndex;
            if (removeIndex != -1)
            {
                mobilePhones.RemoveAt(removeIndex);
            }
            else
            {
                MessageBox.Show("Please choose an item to delete");
            }
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            int updateIndex = mobilephoneListView.SelectedIndex;
            if (updateIndex != -1)
            {
                mobilePhones[updateIndex].Name = "Iphone 15 Pro Max";
                mobilePhones[updateIndex].Manufacturer = "Apple";
                mobilePhones[updateIndex].Price = 1399;
                mobilePhones[updateIndex].ImagePath = "images/phone13.jpg";
            }
            else
            {
                MessageBox.Show("Please choose an item to update");
            }
        }
    }
}
