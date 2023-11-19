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

namespace EnglishVocabulary
{
    /// <summary>
    /// Interaction logic for QuizWindow.xaml
    /// </summary>
    public partial class QuizWindow : Window
    {
        public QuizWindow()
        {
            InitializeComponent();
        }

        private void btnGuide_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("1. Bam Start de bat dau lam bai kiem tra \n" +
                "2. Bam Next de tiep tuc 2 hinh moi","Huong dan lam bai kiem tra");
        }

        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            //contentFrame.Navigate(new Uri("QuizPage.xaml", UriKind.Relative));
            //btnNext.Visibility = Visibility.Visible;
            QuizFrame.Content=new QuizPage();
            btnClose.Visibility = Visibility.Visible;
            //QuizFrame.Navigate(new QuizPage());
            
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            QuizFrame.Navigate(null);
            btnClose.Visibility = Visibility.Collapsed;
        }
    }


}
