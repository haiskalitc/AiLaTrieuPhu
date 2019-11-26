using Microsoft.Win32;
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

namespace AiLaTrieuPhu
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow() {
            InitializeComponent();
        }

        private void btnPlayGame_Click(object sender, RoutedEventArgs e) {
            GamePlay gamePlay = new GamePlay();
            MyMediaPlayer.getInstance.StopMusic();
            //s MyMediaPlayer.getInstance.PlayMusic("StartGame");
            gamePlay.Exit += (se, ar) => {
                 //Thoát game, quay lại màn hình welcome
                (se as GamePlay).Close();
                MyMediaPlayer.getInstance.PlayMusic("NhacNenDauGame");
                Show();
            };
            Hide();
            gamePlay.Show();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            MyMediaPlayer.getInstance.PlayMusic("NhacNenDauGame");
        }

        private void Window_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Escape)
            {
                Close();
            }
        }
    }
}
