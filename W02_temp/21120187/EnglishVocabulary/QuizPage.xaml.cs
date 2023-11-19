using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
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

namespace EnglishVocabulary
{
    /// <summary>
    /// Interaction logic for QuizPage.xaml
    /// </summary>
    public partial class QuizPage : Page
    {
        public QuizPage()
        {
            InitializeComponent();
            check[1] = true;

        }

        static string[] words = 
           {
                "Rabbit (n)",
                "Duck (n)",
                "Book (n)",
                "Ruler (n)",
                "Paper (n)",
                "Candidate (n)",
                "Recruit (v)",
                "Time-consuming (adj)",
                "Investment (n)",
                "Commit (v)",
                "Wisely (adv)",
                "Allocate (v)",
                "Ignore (v)",
                "Search (v)",
                "Warning (n)"
            };

        static string[] wordImgs =
        {
                "Images/word01.jpg",
                "Images/word02.jpg",
                "Images/word03.jpg",
                "Images/word04.jpg",
                "Images/word05.jpg",
                "Images/word06.jpg",
                "Images/word07.jpg",
                "Images/word08.jpg",
                "Images/word09.jpg",
                "Images/word10.jpg",
                "Images/word11.jpg",
                "Images/word12.jpg",
                "Images/word13.jpg",
                "Images/word14.jpg",
                "Images/word15.jpg"
        };

        static bool[] check = Enumerable.Repeat(false, words.Length).ToArray();
        static int score = 0;
        
        private void btnNext_Click(object sender, RoutedEventArgs e)
        {

            if (!check.All(b => b))
            {
                nextQuiz();
                
                
            }
            else
            {
                btnResult.Visibility = Visibility.Visible;
            }
        }

        private void nextQuiz()
        {
            
            
            // lay duong dan hien tai
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;

            Random rng = new Random();

            // i la bien index ngau nhien cua image1
            int i = rng.Next(words.Length);

            while (check[i] == true)
            {
                i=rng.Next(words.Length);
            }

            check[i] = true;

            // j la bien index ngau nhien cua image2
            int j = rng.Next(words.Length);

            while (i == j)
            {
                j=rng.Next(words.Length);
            }

           
            string word = words[i];
         


            string img1 = $"{baseDirectory}{wordImgs[i]}";
            string img2 = $"{baseDirectory}{wordImgs[j]}";

            var bitmap1 = new BitmapImage(new Uri(img1, UriKind.Absolute));
            var bitmap2 = new BitmapImage(new Uri(img2, UriKind.Absolute));

            foreach (var x in myCanvas.Children.OfType<RadioButton>()) {
                x.Tag = "0";
                x.IsChecked = false;
            }

            if (i % 2 == 0)
            {
                image1.Source = bitmap1;
                cbImg1.Tag = "1";
                image2.Source = bitmap2;

                
            }
            else
            {
                image1.Source = bitmap2;
                image2.Source = bitmap1;
                cbImg2.Tag = "1";
            }
            

            testWord.Text = word;


        }

        private void btnResult_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Ban dat duoc: " + score + "/" + words.Length);
        }



        private void Answer(object sender, RoutedEventArgs e)
        {
            RadioButton senderButton = sender as RadioButton;
            
            if (senderButton.Tag.ToString() == "1" && senderButton.IsChecked==true)
            {
                score++;
                
            }


        }
    }
}
