using AiLaTrieuPhu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
using System.Windows.Threading;

namespace AiLaTrieuPhu
{
    /// <summary>
    /// Interaction logic for GamePlay.xaml
    /// </summary>
    public partial class GamePlay : Window
    {
        public SolidColorBrush DEFAULT = Brushes.White;
        public SolidColorBrush CHOOSE = Brushes.Orange;
        public SolidColorBrush AWSER = Brushes.Aquamarine;
        List<string> dsDapAn = new List<string> { "A", "B", "C", "D" };
        public int CurrentIndex = 0;
        public string isChoose = "";
        public string awsTrue = "";
        public int awsTrueint = 0;
        public List<CauHoi> CauHois = null;
        NotifiableCollection<Level> Levels = new NotifiableCollection<Level>() {
            new Level() { Score = "150.000.000", Background = "White", STT = 15, Foreground = "ExtraBold"},
            new Level() { Score = "85.000.000", Background = "White", STT = 14, Foreground = "Medium"},
            new Level() { Score = "60.000.000", Background = "White", STT = 13, Foreground = "Medium"},
            new Level() { Score = "40.000.000", Background = "White", STT = 12, Foreground = "Medium"},
            new Level() { Score = "30.000.000", Background = "White", STT = 11, Foreground = "Medium"},
            new Level() { Score = "22.000.000", Background = "White", STT = 10, Foreground = "ExtraBold"},
            new Level() { Score = "14.000.000", Background = "White", STT = 9, Foreground = "Medium"},
            new Level() { Score = "10.000.000", Background = "White", STT = 8, Foreground = "Medium"},
            new Level() { Score = "6.000.000", Background = "White", STT = 7, Foreground = "Medium"},
            new Level() { Score = "3.000.000", Background = "White", STT = 6, Foreground = "Medium"},
            new Level() { Score = "2.000.000", Background = "White", STT = 5, Foreground = "ExtraBold"},
            new Level() { Score = "1.000.000", Background = "White", STT = 4, Foreground = "Medium"},
            new Level() { Score = "600.000", Background = "White", STT = 3, Foreground = "Medium"},
            new Level() { Score = "400.000", Background = "White", STT = 2, Foreground = "Medium"},
            new Level() { Score = "200.000", Background = "White", STT = 1, Foreground = "Medium"},
        };
        public event EventHandler Exit;
        DispatcherTimer timer = null;
        public int Second = 0;

        public GamePlay()
        {
            InitializeComponent();
            InitGame();
        }

        public async void InitGame()
        {
            await Task.Run(() => {
                Thread.Sleep(14000);
            });

            MyMediaPlayer.getInstance.PlayMusic("BatDauDiTim");
            await Task.Run(() => {
                Thread.Sleep(4000);
            });
            KhoiTaoCauHoi();
            KhoiTaoTroChoi();
            GameScreen.Visibility = Visibility.Visible;
            WelComScreen.Visibility = Visibility.Hidden;
            MyMediaPlayer.getInstance.PlayMusic((CurrentIndex + 1).ToString());
            await Task.Run(() => {
                Thread.Sleep(1200);
            });
            MyMediaPlayer.getInstance.PlayMusic("MocMot");
        }

        public void KhoiTaoCauHoi()
        {
            // lấy random 15 câu từ kho
            CauHois = DataProvider.DataProvider.getInstance.DanhSachCauHoi.OrderBy(x => Guid.NewGuid()).Take(15).ToList();
            dataContext.ItemsSource = Levels;
            foreach (var item in CauHois) {
                // xáo trộn đáp án
                item.DanhSachDapAn = item.DanhSachDapAn.OrderBy(x => Guid.NewGuid()).ToList();
            }
        }

        public void KhoiTaoTroChoi()
        {
            timer = new DispatcherTimer();
            timer.Interval = new TimeSpan(0, 0, 1); //in Hour, Minutes, Second.
            timer.Tick += (sender, args) =>
            {
                Second++;
                TimeSpan time = TimeSpan.FromSeconds(Second);
                txtTime.Text = time.ToString(@"hh\:mm\:ss");
            };
            timer.Start();

            NapCauHoi(CauHois, CurrentIndex);
        }

        public void NapCauHoi(List<CauHoi> dsCauHoi, int index)
        {
            txtAwsA.Visibility = Visibility.Visible;
            txtAwsB.Visibility = Visibility.Visible;
            txtAwsC.Visibility = Visibility.Visible;
            txtAwsD.Visibility = Visibility.Visible;
            if (dsCauHoi.Count > index)
            {
                ClearDapAn();
                CauHoi cauHoi = dsCauHoi[index];     
                txtContentQes.Text = cauHoi.NoiDung;
                txtAwsA.Text = "A. "+ cauHoi.DanhSachDapAn[0].NoiDung;
                txtAwsB.Text = "B. " + cauHoi.DanhSachDapAn[1].NoiDung;
                txtAwsC.Text = "C. " + cauHoi.DanhSachDapAn[2].NoiDung;
                txtAwsD.Text = "D. " + cauHoi.DanhSachDapAn[3].NoiDung;
                grQuest.Header = "Câu số " + (index + 1);
                isChoose = "";
                awsTrue = cauHoi.DanhSachDapAn[0].IsTrue ? "A" : cauHoi.DanhSachDapAn[1].IsTrue ? "B" : cauHoi.DanhSachDapAn[2].IsTrue ? "C" : "D";
                awsTrueint = cauHoi.DanhSachDapAn[0].IsTrue ? 1 : cauHoi.DanhSachDapAn[1].IsTrue ? 2 : cauHoi.DanhSachDapAn[2].IsTrue ? 3 : 4;

            }
            foreach (var item in Levels)
            {
                item.Background = "";
            }
            if (index > 0)
            {
                Levels[Levels.Count - index - 1].Background = "Image/bg_btn_red.png";
            }
            else
            {
                Levels[Levels.Count - 1].Background = "Image/bg_btn_red.png";

            }
            dataContext.ItemsSource = null;
            dataContext.ItemsSource = Levels;
        }

        public bool SetDapAnDung(Control children)
        {
            bool flag = false;
            this.Dispatcher.Invoke((() => {
                if (children.Tag.ToString().Equals(isChoose)) {
                    flag = true;
                }
                children.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(this), "Image/select.png")));
            }));
            return flag;
        }

        private async void btnTraLoi_Click()
        {
            bool isFlag = false;
            if (CurrentIndex >= 5)
            {
                MyMediaPlayer.getInstance.PlayMusic("Cau tra loi cuoi cung cua ban la " + isChoose);
                await Task.Run(() =>
                {
                    Thread.Sleep(2200);
                });
                MyMediaPlayer.getInstance.PlayMusic("TraLoiCuoiCung");
            }
            await Task.Run(() =>
            {
                // random
                if (CurrentIndex < 5)
                {
                    Thread.Sleep(1500);
                }
                else {
                    Thread.Sleep(new Random().Next(5, 15) * 1000);
                }
                CauHoi cauHoi = CauHois[CurrentIndex];
                for (int i = 0; i < cauHoi.DanhSachDapAn.Count; i++) {
                    if (cauHoi.DanhSachDapAn[i].IsTrue) {
                        switch (i) {
                            case 0:
                                {
                                    isFlag = SetDapAnDung(txtAwsA);
                                    break;
                                }
                            case 1:
                                {
                                    isFlag = SetDapAnDung(txtAwsB);
                                    break;
                                }
                            case 2:
                                {
                                    isFlag = SetDapAnDung(txtAwsC);
                                    break;
                                }
                            case 3:
                                {
                                    isFlag = SetDapAnDung(txtAwsD);
                                    break;
                                }
                        }
                    }
                }
                Thread.Sleep(500);
            });
            if (isFlag) {
                int sleep = 2500;
                if (CurrentIndex < 5) {
                    if (CurrentIndex == 4) {
                        MyMediaPlayer.getInstance.PlayMusic("ChinhXacMocMot");
                        await Task.Run(() =>
                        {
                            Thread.Sleep(2500);
                        });
                        sleep = 6500;
                        MyMediaPlayer.getInstance.PlayMusic("MocNam");
                    }
                    else {
                        if (CurrentIndex % 2 == 0)
                        {
                            MyMediaPlayer.getInstance.PlayMusic("ChinhXacMocMot");
                            await Task.Run(() =>
                            {
                                Thread.Sleep(2500);
                            });
                        }
                        MyMediaPlayer.getInstance.PlayMusic("TraLoiDungMot");
                    }
                }
                else {
                    if (CurrentIndex == 9 || CurrentIndex == 14) {
                        MyMediaPlayer.getInstance.PlayMusic("DapAn" + isChoose);
                        await Task.Run(() =>
                        {
                            Thread.Sleep(2600);
                        });
                        sleep = 6500;
                        MyMediaPlayer.getInstance.PlayMusic("MocNam");
                    }
                    else {

                        MyMediaPlayer.getInstance.PlayMusic("DapAn"+isChoose);
                        sleep = 2600;
                    }
                }
                await Task.Run(() => {
                    Thread.Sleep(sleep);
                });
                if (CurrentIndex != 14)
                {
                    CurrentIndex++;
                    MyMediaPlayer.getInstance.PlayMusic((CurrentIndex + 1).ToString());
                    await Task.Run(() =>
                    {
                        Thread.Sleep(1200);
                    });
                    NapCauHoi(CauHois, CurrentIndex);
                   // btnTraLoi.IsEnabled = true;
                    if (CurrentIndex < 5)
                    {
                        MyMediaPlayer.getInstance.PlayMusic("MocMot");
                    }
                    else
                    {
                        MyMediaPlayer.getInstance.PlayMusic("MocHai");
                    }
                }
                else {
                    await Task.Run(() => {
                        Thread.Sleep(3000);
                    });
                    // Game over
                    MyMediaPlayer.getInstance.StopMusic();
                    showReport();
                    Exit(this, new EventArgs());
                }
            }
            else {
                MyMediaPlayer.getInstance.PlayMusic("Cau tra loi dung cua chung toi la " + awsTrue);

                await Task.Run(() =>
                {
                    Thread.Sleep(5000);
                });
                // Game over
                MyMediaPlayer.getInstance.StopMusic();
                showReport();
                Exit(this, new EventArgs());
            }
        }

        public void showReport() {
            string[] arr = txtTime.Text.Split(':');
            string tg = "";
            if (arr[0].Equals("00")) {
                if (arr[1].Equals("00")) {
                    tg = arr[2] + " giây";
                }
                else {
                    tg = arr[1] + " phút" + arr[2] + " giây";
                }
            } else {
                tg = arr[0] + " giờ" + arr[1] + " phút " + arr[2] + " giây";
            }
            MessageBox.Show("Bạn đã hoàn thành " + CurrentIndex + " câu hỏi" +
                Environment.NewLine +
                "Thời gian : " + tg, "Thông báo", MessageBoxButton.OK, MessageBoxImage.Stop);
        }

        private void grAwsA_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (String.IsNullOrEmpty(isChoose))
            {
                ClearDapAn();
                var gr = sender as TextBox;
                if (gr != null)
                {
                    gr.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(this), "Image/choose.png")));
                    isChoose = gr.Tag.ToString();
                    btnTraLoi_Click();
                }
            }
        }
        public void ClearDapAn()
        {
            txtAwsA.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(this), "Image/button3.png")));
            txtAwsB.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(this), "Image/button3.png")));
            txtAwsC.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(this), "Image/button3.png")));
            txtAwsD.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(this), "Image/button3.png")));
        }

        private async void btnDungCuocChoi_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult dialog = MessageBox.Show("Xác nhận dừng ?", "Thông báo", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (dialog == MessageBoxResult.Yes) {
                MyMediaPlayer.getInstance.PlayMusic("HetGio");
                await Task.Run(() => {
                    Thread.Sleep(3500);
                });
                MyMediaPlayer.getInstance.StopMusic();
                showReport();
                Exit(this, new EventArgs());
            }
        }

        private void Window_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Escape)
            {
                Close();
            }
        }

        public List<int> RanDom(int des) {
            List<int> res = new List<int>();
            while (res.Count !=2) {
                Random rnd = new Random();
                int fl = rnd.Next(1, 4);
                if (fl != des && !res.Contains(fl)) {
                    res.Add(fl);
                }
            }
            return res;
        }
        public List<int> DivideEvenly(int total)
        {
            List<int> ds = new List<int>();
            while (total != 0 && ds.Count != 4) {
                Random rnd = new Random();
                int fl = rnd.Next(0, total);
                ds.Add(fl);
                total -= fl;
            }
            return ds;
        }
        private async void helperA_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            var item = (sender as Image);
            switch (item.Name) {
                case "helperA": {
                        //change
                        if (item.Tag.ToString().Equals("0")) {
                            item.Source = new BitmapImage(new Uri(@"/Image/change_used.png", UriKind.Relative));
                            item.Tag = 1;
                            item.IsEnabled = false;
                            CurrentIndex++;
                            MyMediaPlayer.getInstance.PlayMusic((CurrentIndex + 1).ToString());
                            await Task.Run(() =>
                            {
                                Thread.Sleep(1100);
                            });
                            NapCauHoi(CauHois, CurrentIndex);
                            if (CurrentIndex < 5)
                            {
                                MyMediaPlayer.getInstance.PlayMusic("MocMot");
                            }
                            else
                            {
                                MyMediaPlayer.getInstance.PlayMusic("MocHai");
                            }
                        }
                        break;
                }
                case "helperB":
                {
                        //fiftyfifty
                        if (item.Tag.ToString().Equals("0"))
                        {
                            item.Source = new BitmapImage(new Uri(@"/Image/fiftyfifty_used.png", UriKind.Relative));
                            item.Tag = 1;
                            item.IsEnabled = false;
                            MyMediaPlayer.getInstance.PlayMusic("5050");
                            await Task.Run(() =>
                            {
                                Thread.Sleep(2800);
                            });
                            var ranDom = RanDom(awsTrueint);
                            foreach (var fl in ranDom) {
                                switch (fl) {
                                    case 1: {
                                            txtAwsA.Visibility = Visibility.Hidden;
                                            break;
                                     }
                                    case 2:
                                        {
                                            txtAwsB.Visibility = Visibility.Hidden;
                                            break;
                                        }
                                    case 3:
                                        {
                                            txtAwsC.Visibility = Visibility.Hidden;
                                            break;
                                        }
                                    case 4:
                                        {
                                            txtAwsD.Visibility = Visibility.Hidden;
                                            break;
                                        }
                                }
                            }
                            await Task.Run(() =>
                            {
                                Thread.Sleep(1000);
                            });
                            if (CurrentIndex < 5)
                            {
                                MyMediaPlayer.getInstance.PlayMusic("MocMot");
                            }
                            else
                            {
                                MyMediaPlayer.getInstance.PlayMusic("MocHai");
                            }
                        }
                        break;
                }
                case "helperC":
                {
                        //audience
                        if (item.Tag.ToString().Equals("0"))
                        {
                            item.Source = new BitmapImage(new Uri(@"/Image/audience_used.png", UriKind.Relative));
                            item.Tag = 1;
                            List<int> ds = DivideEvenly(100);
                            MyMediaPlayer.getInstance.PlayMusic("HoiKhanGia");
                            await Task.Run(() =>
                            {
                                Thread.Sleep(6000);
                            });
                            string res = ds[0].ToString() + "% khán giả chọn A" + Environment.NewLine
                                + ds[1].ToString() + "% khán giả chọn B" + Environment.NewLine
                                + ds[2].ToString() + "% khán giả chọn C" + Environment.NewLine
                                + ds[3].ToString() + "% khán giả chọn D" + Environment.NewLine;
                            if (CurrentIndex < 5)
                            {
                                MyMediaPlayer.getInstance.PlayMusic("MocMot");
                            }
                            else
                            {
                                MyMediaPlayer.getInstance.PlayMusic("MocHai");
                            }
                            MessageBox.Show(res);
                        }
                        break;
                }
            }
        }
    }
}
