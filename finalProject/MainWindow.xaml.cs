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
using BEEE;




namespace finalProject
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

        private void newShop_Click(object sender, RoutedEventArgs e)
        {
            new QRqode().Show();
            this.Close();
        }

        private void editShop_Click(object sender, RoutedEventArgs e)
        {
            new editWindow().Show();
            this.Close();
        }

        private void viewShop_Click(object sender, RoutedEventArgs e)
        {
            new analysisWindow().Show();
            this.Close();
        }

        private void recShop_Click(object sender, RoutedEventArgs e)
        {
            new reccomenderWindow().Show();
            this.Close();
        }
    }
}
