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
    /// Interaction logic for editWindow.xaml
    /// </summary>
    public partial class editWindow : Window
    {
        public editWindow()
        {
            InitializeComponent();
            DispatcherTimer timer = new DispatcherTimer() { Interval = TimeSpan.FromSeconds(3) };
            timer.Tick += delegate (object sender, EventArgs e)
            {
                ((DispatcherTimer)timer).Stop();
                shoplist.Visibility = Visibility.Visible;
                loading.Visibility = Visibility.Hidden;
            };

            timer.Start();
        }


        private void saveEdit_Click(object sender, RoutedEventArgs e)
        {
            itemlist.Visibility = Visibility.Hidden;
            shoplist.Visibility = Visibility.Visible;
        }
    }



}
