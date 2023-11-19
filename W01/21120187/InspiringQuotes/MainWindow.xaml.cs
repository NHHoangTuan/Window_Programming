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

namespace InspiringQuotes
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

        private void btnChange_Click(object sender, RoutedEventArgs e)
        {
            Random rng = new Random();

            string[] quotes = {

                "A problem is a chance for you to do your best",
                "Motivation is what gets you started. Habit is what keeps you going",
                "A little progress each day adds up to big results.",
                "Success consists of getting up just one more time than you fall",
                "If you get tired, learn to rest, not quit.",
                "Don’t stop until you’re proud.",
                "Focus on your goal. Don’t look in any direction but ahead.",
                "Courage is one step ahead of fear.",
                "Don’t wish it were easier. Wish you were better",
                "I find that the harder I work, the more luck I seem to have.",
                "Success is the sum of small efforts repeated day-in and day-out",
                "We must embrace pain and burn it as fuel for our journey.",
                "Believe you can and you’re halfway there",
                "Hustle until you no longer have to introduce yourself",
                "Be so good they can’t ignore you"

            };

            string[] quotesImgs =
            {
                @"C:\Users\Hoang Tuan\Desktop\Images\quotes01.jpg",
                @"C:\Users\Hoang Tuan\Desktop\Images\quotes02.jpg",
                @"C:\Users\Hoang Tuan\Desktop\Images\quotes03.jpg",
                @"C:\Users\Hoang Tuan\Desktop\Images\quotes04.jpg",
                @"C:\Users\Hoang Tuan\Desktop\Images\quotes05.jpg",
                @"C:\Users\Hoang Tuan\Desktop\Images\quotes06.jpg",
                @"C:\Users\Hoang Tuan\Desktop\Images\quotes07.jpg",
                @"C:\Users\Hoang Tuan\Desktop\Images\quotes08.jpg",
                @"C:\Users\Hoang Tuan\Desktop\Images\quotes09.jpg",
                @"C:\Users\Hoang Tuan\Desktop\Images\quotes10.jpg",
                @"C:\Users\Hoang Tuan\Desktop\Images\quotes11.jpg",
                @"C:\Users\Hoang Tuan\Desktop\Images\quotes12.jpg",
                @"C:\Users\Hoang Tuan\Desktop\Images\quotes13.jpg",
                @"C:\Users\Hoang Tuan\Desktop\Images\quotes14.jpg",
                @"C:\Users\Hoang Tuan\Desktop\Images\quotes15.jpg",

            };

            int i = rng.Next(quotesImgs.Length);
            string quotesStr = quotes[i];
            quotesTextBlock.Text = quotesStr;

            string image = quotesImgs[i];

            var bitmap = new BitmapImage(new Uri(image, UriKind.Absolute));
            quotesImg.Source = bitmap;

        }
    }
}
