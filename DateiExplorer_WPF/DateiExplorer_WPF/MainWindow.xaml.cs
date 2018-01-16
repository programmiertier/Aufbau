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
using static System.Console;
using System.IO;

namespace DateiExplorer_WPF
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void knopf_Click(object sender, RoutedEventArgs e)
        {
            // DriveInfo laufwerk = new DriveInfo(eingabe.Text);
            // ausgabe.Content = laufwerk.Name + "\t" + laufwerk.AvailableFreeSpace + "\t" + laufwerk.DriveFormat;
            FileInfo datei = new FileInfo(eingabe.Text);
            ausgabe.Content = datei.DirectoryName + "\t" +  datei.Name + "\t" + datei.LastWriteTime + "\t" + datei.Attributes;
        }
    }
}
