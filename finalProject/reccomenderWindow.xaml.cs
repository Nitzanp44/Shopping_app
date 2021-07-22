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
using System.Windows.Threading;

namespace finalProject
{
    /// <summary>
    /// Interaction logic for reccomenderWindow.xaml
    /// </summary>
    public partial class reccomenderWindow : Window
    {
        public reccomenderWindow()
        {
            InitializeComponent();
            DispatcherTimer timer = new DispatcherTimer() { Interval = TimeSpan.FromSeconds(3) };
            timer.Tick += delegate (object sender, EventArgs e)
            {
                ((DispatcherTimer)timer).Stop();
                shopListRec.Visibility = Visibility.Visible;
                loadingRec.Visibility = Visibility.Hidden;
            };

            timer.Start();
        }
    }
}
