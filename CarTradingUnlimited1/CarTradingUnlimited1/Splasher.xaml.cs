using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;
using System.Windows.Media.Animation;

namespace CarTradingUnlimited
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class Splasher : Window
    {
        DispatcherTimer dsptime = new DispatcherTimer();

        public Splasher()
        {
            InitializeComponent();
        }

        private void SplashScreen_Loaded(object sender, RoutedEventArgs e)
        {
            dsptime.Tick += new EventHandler(dsptime_Tick);
            dsptime.Interval = new TimeSpan(0, 0, 20);
            dsptime.Start();
        }

        private void dsptime_Tick(object sender, EventArgs e)
        {
            dsptime.Stop();
            this.Close();
            LoginWindow log = new LoginWindow();
            log.Show();
        }

        private void SplashScreen_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Closing -= SplashScreen_Closing;
            e.Cancel = true;
            var anim = new DoubleAnimation(0, (Duration)TimeSpan.FromSeconds(0.3));
            anim.Completed += (s, _) => this.Close();
            this.BeginAnimation(UIElement.OpacityProperty, anim);
            dsptime.Stop();
        }

       
    }
}
