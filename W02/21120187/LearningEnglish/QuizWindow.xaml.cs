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

namespace LearningEnglish
{
    /// <summary>
    /// Interaction logic for QuizWindow.xaml
    /// </summary>
    public partial class QuizWindow : Window
    {
        int score = 0;
        int qNum = 0;
        int trueIndex = 0;
        int falseIndex = 0;

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

        List<int> index = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14};

        //static bool[] check = Enumerable.Repeat(false, words.Length).ToArray();

        public QuizWindow()
        {

            InitializeComponent();
            startQuiz();
            showQuiz();

        }

        private void startQuiz()
        {
            score = 0;
            qNum = 0;
            trueIndex = 0;
            falseIndex = 0;
            var randomlist = index.OrderBy(a => Guid.NewGuid()).ToList();
            index = randomlist;
            foreach (var x in mycanvas.Children.OfType<RadioButton>())
            {
                x.Tag = "0";
                x.IsChecked = false;
            }

            btnNext.Visibility = Visibility.Visible;
            btnResult.Visibility = Visibility.Collapsed;

        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            qNum++;
            if (qNum < index.Count)
            {
                
              
                foreach (var x in mycanvas.Children.OfType<RadioButton>())
                {
                    x.Tag = "0";
                    x.IsChecked = false;
                }

                showQuiz();

            }
            else
            {
                btnResult.Visibility = Visibility.Visible;
                btnNext.Visibility = Visibility.Collapsed;
            }
            
        }

        private void showQuiz()
        {


            trueIndex = index[qNum];

            if (trueIndex == index.Count - 1)
            {
                falseIndex = 0;
            }
            else
            {
                falseIndex = trueIndex + 1;
            }

            // lay duong dan hien tai
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;

            Random rng = new Random();


            string word = words[trueIndex];



            string img1 = $"{baseDirectory}{wordImgs[trueIndex]}";
            string img2 = $"{baseDirectory}{wordImgs[falseIndex]}";

            var bitmap1 = new BitmapImage(new Uri(img1, UriKind.Absolute));
            var bitmap2 = new BitmapImage(new Uri(img2, UriKind.Absolute));

            

            if (rng.Next(index.Count) % 2 == 0)
            {
                image1.Source = bitmap1;
                radiobtn1.Tag = "1";
                image2.Source = bitmap2;


            }
            else
            {
                image1.Source = bitmap2;
                image2.Source = bitmap1;
                radiobtn2.Tag = "1";
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

            if (senderButton.Tag.ToString() == "1" && senderButton.IsChecked == true)
            {
                score++;

            }
        }

        private void btnRestart_Click(object sender, RoutedEventArgs e)
        {
            startQuiz();
            showQuiz();
        }
    }
}
