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

namespace LearningEnglish
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

        private void btnLearn_Click(object sender, RoutedEventArgs e)
        {
            LearningWindow learningWindow = new LearningWindow();
            learningWindow.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            learningWindow.Owner = this;
            learningWindow.ShowDialog();
        }

        private void btnTutorial_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Bam vao nut Quiz de lam bai kiem tra\n" +
                "Bam vao nut Learn de vao bai hoc\n" +
                "Bam vao Exit de thoat", "Huong dan su dung");
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void btnQuiz_Click(object sender, RoutedEventArgs e)
        {
            QuizWindow quizWindow = new QuizWindow();
            quizWindow.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            quizWindow.Owner = this;
            quizWindow.ShowDialog();
        }
    }
}
