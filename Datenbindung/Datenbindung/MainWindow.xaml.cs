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

namespace Datenbindung
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Binding binding = new Binding("Background");
            binding.ElementName = "lstBox";
            txtbox.SetBinding(TextBox.BackgroundProperty, binding);

            BindingOperations.ClearBinding(txtbox, TextBox.BackgroundProperty);

        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            BindingExpression binding = txtTarget.GetBindingExpression(TextBox.TextProperty);
            binding.UpdateSource();
        }

        private void txtTarget_SourceUpdated(object sender, DataTransferEventArgs e)
        {
            MessageBox.Show("Aktualisierung durchgeführt!");
            //BindingOperations.ClearAllBindings(txtTarget);
        }
    }
}
