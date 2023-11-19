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
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnChange_Click(object sender, RoutedEventArgs e)
        {

            string[] words =
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

            string[] spellings =
            {
                "/ˈræb.ɪt/",
                "/dʌk/",
                "/bʊk/",
                "/ˈruː.lɚ/",
                "/ˈpeɪ.pɚ/",
                "/ˈkændɪdeɪt/",
                "/rɪˈkruːt/",
                "/ˈtaɪm kənsjuːmɪŋ/",
                "/ɪnˈvestmənt/",
                "/kəˈmɪt/",
                "/ˈwaɪzli/",
                "/ˈæləkeɪt/",
                "/ɪɡˈnɔː(r)/",
                "/sɜːtʃ/",
                "/ˈwɔːnɪŋ/"
            };

            string[] meanings =
            {
                "con thỏ",
                "con vịt",
                "sách, vở",
                "thước kẻ",
                "giấy",
                "ứng cử viên",
                "thuê, tuyển dụng",
                "tốn nhiều thời gian",
                "sự đầu tư, vốn đầu tư",
                "cam kết, giao phó",
                "từng trãi, thông thái, uyên bác",
                "cung cấp, phân bổ",
                "phớt lờ, bỏ qua",
                "tìm kiếm",
                "sự cảnh báo"
            };

            string[] wordImgs =
            {
                "/Images/word01.jpg",
                "/Images/word02.jpg",
                "/Images/word03.jpg",
                "/Images/word04.jpg",
                "/Images/word05.jpg",
                "/Images/word06.jpg",
                "/Images/word07.jpg",
                "/Images/word08.jpg",
                "/Images/word09.jpg",
                "/Images/word10.jpg",
                "/Images/word11.jpg",
                "/Images/word12.jpg",
                "/Images/word13.jpg",
                "/Images/word14.jpg",
                "/Images/word15.jpg"
            };

            Random rng = new Random();
            int i = rng.Next(wordImgs.Length);

            string word = words[i];
            string spelling = spellings[i];
            string meaning = meanings[i];
            string img = wordImgs[i];

            var bitmap = new BitmapImage(new Uri(img, UriKind.Relative));

            wordText.Text = word;
            spellingText.Text = spelling;
            meaningText.Text = meaning;
            wordImg.Source = bitmap;

        }
    }
}
