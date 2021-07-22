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

namespace finalProject
{
    /// <summary>
    /// Interaction logic for UserControlMenu.xaml
    /// </summary>
    public partial class UserControlMenu : UserControl
    {
        public UserControlMenu()
        {
            InitializeComponent();
        }

        private void ToggleButton_Click(object sender, RoutedEventArgs e)
        {
            if (openMenu.Visibility == Visibility.Visible)
                openMenu.Visibility = Visibility.Hidden;
            else
                openMenu.Visibility = Visibility.Visible;
        }

        private void home_Click(object sender, RoutedEventArgs e)
        {
            new MainWindow().Show();
            var myWindow = Window.GetWindow(this);
            myWindow.Close();
        }

        private void new_Click(object sender, RoutedEventArgs e)
        {
            new QRqode().Show();
            var myWindow = Window.GetWindow(this);
            myWindow.Close();
        }

        private void edit_Click(object sender, RoutedEventArgs e)
        {
            new editWindow().Show();
            var myWindow = Window.GetWindow(this);
            myWindow.Close();
        }

        private void analysis_Click(object sender, RoutedEventArgs e)
        {
            new analysisWindow().Show();
            var myWindow = Window.GetWindow(this);
            myWindow.Close();
        }

        private void list_Click(object sender, RoutedEventArgs e)
        {
            new reccomenderWindow().Show();
            var myWindow = Window.GetWindow(this);
            myWindow.Close();
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
