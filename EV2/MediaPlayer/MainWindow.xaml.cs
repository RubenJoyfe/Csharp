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

namespace Pr_MediaPlayer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MediaPlayer mp = new MediaPlayer();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_Play(object sender, RoutedEventArgs e)
        {

        }
        private void btn_Pause(object sender, RoutedEventArgs e)
        {

        }
        private void btn_Stop(object sender, RoutedEventArgs e)
        {

        }
        private void btn_VolumeUp(object sender, RoutedEventArgs e)
        {

        }
        private void btn_VolumeDown(object sender, RoutedEventArgs e)
        {

        }

    }
}
