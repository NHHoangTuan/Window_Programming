﻿using System;
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

namespace LayoutPractice
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

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            Window1 window1 = new Window1();
            window1.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            window1.Owner = this;
            window1.ShowDialog();
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            Window2 window2 = new Window2();
            window2.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            window2.Owner = this;
            window2.ShowDialog();
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            Window3 window3 = new Window3();
            window3.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            window3.Owner = this;
            window3.ShowDialog();
        }
    }
}