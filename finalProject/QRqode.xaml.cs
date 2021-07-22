using System;
using Firebase.Storage;
using ZXing;
using System.Drawing;
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
using System.IO;
using System.Net;
using Microsoft.Win32;

namespace finalProject
{
    /// <summary>
    /// Interaction logic for QRqode.xaml
    /// </summary>
    public partial class QRqode : Window
    {
        public QRqode()
        {
            InitializeComponent();
        }


        public async static Task addToStorage(string path)
        {
            var stream = File.Open(path, FileMode.Open);
            // Construct FirebaseStorage with path to where you want to upload the file and put it there
            var task = new FirebaseStorage("QRqode.appspot.com")
            .Child(path + ".jpg")
            .PutAsync(stream);
            // Track progress of the upload
            task.Progress.ProgressChanged += (s, e) => Console.WriteLine($"Progress:{ e.Percentage} % ");
            // Await the task to wait until upload is completed and get the download url
            var downloadUrl = await task;
            Console.WriteLine(downloadUrl);
            readQRqode(downloadUrl);

        }

        private static void readQRqode(string url)
        {
            var client = new WebClient();
            var stream = client.OpenRead(url);
            if (stream == null) return;
            var bitmap = new Bitmap(stream);
            IBarcodeReader reader = new BarcodeReader();
            var result = reader.Decode(bitmap);
            Console.WriteLine(result.Text);
        }

        private void StackPanel_MouseEnter(object sender, MouseEventArgs e)
        {

        }

        private void text_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void addItem_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                Uri fileUri = new Uri(openFileDialog.FileName);
                //Task task = addToStorage(string(fileUri));
            }
        }

        private void finisfShopping_Click(object sender, RoutedEventArgs e)
        {
            finish.Visibility = Visibility.Visible;
            innerGrid.Visibility = Visibility.Hidden;
        }

        private void okfinisfShopping_Click(object sender, RoutedEventArgs e)
        {
            new MainWindow().Show();
            this.Close();
        }

    }
}
