using System;
using System.Collections.Generic;
using System.IO;
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

namespace Bibliothek
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
        private void btnFett_Click(object sender, RoutedEventArgs e)
        {
            Object fett = rtbDocument.Selection.GetPropertyValue(FontWeightProperty);
            FontWeight actFontWeight = (FontWeight)fett;

            FontWeight newFontWeight;
            if (actFontWeight == FontWeights.Bold)
                newFontWeight = FontWeights.Normal;
            else
                newFontWeight = FontWeights.Bold;

            rtbDocument.Selection.ApplyPropertyValue(FontWeightProperty, newFontWeight);
            rtbDocument.Focus();
        }

        private void btnLaden_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog dialog = new Microsoft.Win32.OpenFileDialog();
            dialog.Filter = "Text-Dateien|*.txt|XAML-Dateien|*.xaml|RTF-Dateien|*.rtf|Alle Dateien|*.*";
            bool? result = dialog.ShowDialog();
            if (result == true)
            {
                string format = null; ;
                switch (dialog.FilterIndex)
                {
                    case 1:
                    case 4:
                        format = System.Windows.DataFormats.Text;
                        break;
                    case 2:
                        format = System.Windows.DataFormats.Xaml;
                        break;
                    case 3:
                        format = System.Windows.DataFormats.Rtf;
                        break;
                }
                FlowDocument document = rtbDocument.Document;
                TextRange range = new TextRange(document.ContentStart, document.ContentEnd);

                FileStream stream = new FileStream(dialog.FileName, FileMode.Open, FileAccess.ReadWrite);
                range.Load(stream, format);
                stream.Close();
            }
        }

        private void btnSpeichern_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.SaveFileDialog dialog = new Microsoft.Win32.SaveFileDialog();
            dialog.Filter = "Text-Dateien|*.txt|XAML-Dateien|*.xaml|RTF-Dateien|*.rtf";
            bool? result = dialog.ShowDialog();
            if (result == true)
            {
                string format = null; ;
                switch (dialog.FilterIndex)
                {
                    case 1:
                        format = System.Windows.DataFormats.Text;
                        break;
                    case 2:
                        format = System.Windows.DataFormats.Xaml;
                        break;
                    case 3:
                        format = System.Windows.DataFormats.Rtf;
                        break;
                }
                FlowDocument document = rtbDocument.Document;
                TextRange range = new TextRange(document.ContentStart, document.ContentEnd);

                FileStream stream = new FileStream(dialog.FileName, FileMode.Create, FileAccess.ReadWrite);
                range.Save(stream, format);
                stream.Close();
            }
        }
    }
}