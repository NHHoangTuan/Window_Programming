using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
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

namespace Books
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

        BindingList<Book> books = null;
        List<Book> newBooks = null;
        private int newBookIndex = 0;

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            books = new BindingList<Book>()
            {
                new Book() {Name = "Đắc Nhân Tâm", Author = "Dale Carnegie", PublishYear = 1936, ImagePath = "images/book01.jpg"},
                new Book() {Name = "Đời Ngắn Đừng Ngủ Dài", Author = "Robin Sharma", PublishYear = 1999, ImagePath = "images/book02.jpg"},
                new Book() {Name = "Nhà Giả Kim", Author = "Paulo Coelho", PublishYear = 1988, ImagePath = "images/book03.jpg"},
                new Book() {Name = "Thức Tỉnh Mục Đích Sống", Author = "Eckhart Tolle", PublishYear = 2006, ImagePath = "images/book04.jpg"},
                new Book() {Name = "Tu Giữa Đời Thường", Author = "Pedram Shojai", PublishYear = 2021, ImagePath = "images/book05.jpg"},
                new Book() {Name = "Dòng chảy", Author = "Mihaly Csikszentmihalyi", PublishYear = 2015, ImagePath = "images/book06.jpg"},
                new Book() {Name = "Nội Lực", Author = "Tara Swart", PublishYear = 2001, ImagePath = "images/book07.jpg"},
                new Book() {Name = "Cú Hích Phiên Bản Cuối Cùng", Author = "Richard H. Thaler, Cass R. Sunstein", PublishYear = 1994, ImagePath = "images/book08.jpg"},
                new Book() {Name = "Chữa lành đứa trẻ tổn thương bên trong", Author = "Robert Jackman", PublishYear = 2003, ImagePath = "images/book09.jpg"},
                new Book() {Name = "Là bạn nhưng vạn lần tốt hơn", Author = "Mike Bayer", PublishYear = 2014, ImagePath = "images/book10.jpg"},


            };
            bookListView.ItemsSource = books;

            newBooks = new List<Book>()
            {
                new Book() {Name = "Lẽ Sống", Author = "Viktor Frankl", PublishYear = 1995, ImagePath = "images/book11.jpg" },
                new Book() {Name = "Chữa lành đứa trẻ tổn thương bên trong", Author = "Robert Jackman", PublishYear = 1975, ImagePath = "images/book12.jpg" },
            };
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            // add 1 book at a time, max = 2
            if (newBookIndex < 2)
            {
                books.Add(newBooks[newBookIndex]);
                newBookIndex++;
            }
            else 
            {
                MessageBox.Show("Out of book to add! Sorry!");
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            int removeIndex = bookListView.SelectedIndex;
            if(removeIndex != -1) 
            {
                books.RemoveAt(removeIndex);
            }
            else
            {
                MessageBox.Show("Please choose an item to delete");
            }

        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            int updateIndex = bookListView.SelectedIndex;
            if (updateIndex != -1)
            {
                books[updateIndex].Name = "Hiểu Về Trái Tim";
                books[updateIndex].Author = "Minh Niệm";
                books[updateIndex].PublishYear = 2011;
                books[updateIndex].ImagePath = "images/book13.jpg";
            }
            else
            {
                MessageBox.Show("Please choose an item to update");
            }
        }
    }
}
