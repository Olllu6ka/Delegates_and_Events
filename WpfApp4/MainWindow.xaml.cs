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
using System.Windows.Threading;

namespace WpfApp4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int m, s, ms;
        static DispatcherTimer dt = new DispatcherTimer();
        public MainWindow(){
            InitializeComponent();
        }
        private void dtTicker(object sender, EventArgs e){
            ms++;
            if (ms == 60){
                ms = 0;
                s += 1;
            }
            if (s == 60){
                s = 0;
                m += 1;
            }
            Label1.Content = m.ToString() + " : " + s.ToString() + " : " + ms.ToString();
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            m = 0;s = 0; ms = 0;
            Label1.Content = "00:00:00";
           
        }

        private void Button_Click_3(object sender, RoutedEventArgs e){
            dt.Interval = TimeSpan.FromSeconds(1);
            dt.Tick += dtTicker;
            dt.Start();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e){
            dt.Stop();
            
        }
    }
}
