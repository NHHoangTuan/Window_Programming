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

namespace EnglishVocabulary
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Dictionary<string, string> vocabulary = new Dictionary<string, string>
        {
            {"Images/word01.jpg", "Rabbit"},
            {"Images/word02.jpg", "Duck"},
            {"Images/word03.jpg", "Book"},
            {"Images/word04.jpg", "Ruler"},
            {"Images/word05.jpg", "Paper"},
            {"Images/word06.jpg", "Candidate"},
            {"Images/word07.jpg", "Recruit"},
            {"Images/word08.jpg", "Time-consuming"},
            
            // Thêm nhiều từ vựng và hình ảnh khác vào đây
        };

        private List<string> testWords;
        private Random random = new Random();
        private int score = 0;
        string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void StartTest()
        {
            testWords = vocabulary.Keys.OrderBy(x => random.Next()).Take(10).ToList();
            ShowNextWord();
        }

        private void ShowNextWord()
        {
            if (testWords.Count > 0)
            {
                string randomWord = testWords[0];
                string imagePath = $"{baseDirectory}{randomWord}";

                BitmapImage bitmap = new BitmapImage(new Uri(imagePath, UriKind.Absolute));
                imageView.Source = bitmap;
            }
            else
            {
                MessageBox.Show($"Bài kiểm tra đã kết thúc. Điểm của bạn: {score}");
            }
        }

        private void CheckAnswer_Click(object sender, RoutedEventArgs e)
        {
            if (testWords.Count > 0)
            {
                Button button = (Button)sender;
                string selectedWord = vocabulary[testWords[0]];
                int selectedImage = int.Parse(button.Tag.ToString());

                if ((selectedImage == 1 && selectedWord == testWords[0]) ||
                    (selectedImage == 2 && selectedWord != testWords[0]))
                {
                    score++;
                }

                testWords.RemoveAt(0);
                ShowNextWord();
            }
        }

    }
}
