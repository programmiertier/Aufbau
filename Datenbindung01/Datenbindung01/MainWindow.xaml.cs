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

namespace Datenbindung01
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Person pers = new Person { name = "Véronique Zimmermann", adresse = "Köln" };
        public MainWindow()
        {
            InitializeComponent();
            gridUnten.DataContext = pers;
            //btn1.Click += Btn1_Click;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            pers.name = "Klaus Kleber";
            pers.adresse = "Köln";
            pers.alter = null;
            pers.PropertyChanged += Pers_PropertyChanged;
        }

        private void Pers_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            MessageBox.Show("Es hat sich was geändert");
        }
    }
}
