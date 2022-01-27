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

namespace Pr_MediaPlayer_Musica
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MediaPlayer md = new MediaPlayer();

        public MainWindow()
        {
            InitializeComponent();

            md.Open(new Uri("ChingChengHanji.mp3", UriKind.Relative));
        }

        private void btn_Play(object sender, RoutedEventArgs e)
        {
            md.Play();
        }
        private void btn_Pause(object sender, RoutedEventArgs e)
        {
            md.Pause();
        }
        private void btn_Stop(object sender, RoutedEventArgs e)
        {
            md.Stop();
        }
        private void btn_VolumeUp(object sender, RoutedEventArgs e)
        {
            md.Volume += 0.1;
        }
        private void btn_VolumeDown(object sender, RoutedEventArgs e)
        {
            md.Volume -= 0.1;
        }


    }

}
