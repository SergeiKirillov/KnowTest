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

namespace DBKnowTest
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnPath_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dlg =new OpenFileDialog();
            dlg.InitialDirectory = "c:\\";
            dlg.Filter = "Image files (*.jpg)|*.jpg|All Files (*.*)|*.*";
            dlg.RestoreDirectory = true;

            if (dlg.ShowDialog() == true)
            {
                string selectedFileName = dlg.FileName;
                BitmapImage bi = new BitmapImage();
                bi.BeginInit();
                Uri fileuri = new Uri(selectedFileName);

                bi.UriSource = fileuri;

               
                
                string fileName = fileuri.Segments[fileuri.Segments.Length - 1];
                string PathFile = fileuri.LocalPath.Replace(fileName,"");
                picQuestion.Text = fileName;
                txtBlockPath.Text= PathFile;
                bi.EndInit();
                imgPic.Source= bi;


            }
        }
    }
}
