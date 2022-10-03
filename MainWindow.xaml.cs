using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Media;
using System.Net.Security;
using System.Security.Policy;
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

namespace piggychan
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("hi!! well done!!!!");
        }
        bool isplaying = false;
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            SoundPlayer piggychan = new SoundPlayer("C:\\Users\\Carolina\\Downloads\\ばかみたい.wav");

            if (isplaying == false)
            {
                piggychan.Play();
                isplaying = true;
                MessageBox.Show("why did you click it :( (click again to stop playing)");
            }
            else if (isplaying == true)
            {
                piggychan.Stop();
                isplaying = false;
            } 
        }

        private void myGif_MediaEnded(object sender, RoutedEventArgs e)
        {
            myGif.Position = new TimeSpan(0, 0, 1);
            myGif.Play();
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
           Process myProcess=new Process();
            myProcess.StartInfo.UseShellExecute = true;
            myProcess.StartInfo.FileName = "https://github.com/piggy-chan";
            myProcess.Start();
        }
    }
}
