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

namespace DBKnowTest
{
    /// <summary>
    /// Логика взаимодействия для GeneralWindowDB.xaml
    /// </summary>
    public partial class GeneralWindowDB : Window
    {
        public GeneralWindowDB()
        {
            InitializeComponent();
        }

        private void btnCreateDB_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.SaveFileDialog dlg = new Microsoft.Win32.SaveFileDialog();
            dlg.FileName = "Test";
            dlg.InitialDirectory = System.Environment.CurrentDirectory;
            //dlg.DefaultExt = ".db";
            dlg.Filter = "All Files|*.*";

            Nullable<bool> result = dlg.ShowDialog();

            // Process save file dialog box results
            if (result == true)
            {
                // Save document
                string filename = dlg.FileName;
            }
        }

        private void btnOpenDB_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            dlg.InitialDirectory = System.Environment.CurrentDirectory;
            //dlg.DefaultExt= ".db";
            dlg.Filter = "All Files (*.*)|*.*";
            dlg.RestoreDirectory = true;

            if (dlg.ShowDialog() == true)
            {
                string selectedFileName = dlg.FileName;
            }

        }
    }
}
