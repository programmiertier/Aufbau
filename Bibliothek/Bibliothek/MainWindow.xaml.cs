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

            VerwListe liste = new VerwListe();
            Buch buch = new Buch();
            buch.autor = "Terry Pratchett";
            buch.isbn = "9-256-12345-1";
            buch.titel = "Wachen! Wachen!";
            buch.verlag = "Klett";

            liste.Add(buch);

            Zeitung zeitung = new Zeitung();
            zeitung.ausgabe = 1;
            zeitung.titel = "Zeit";
            zeitung.isbn = "9-999-12345-2";
            zeitung.verlag = "Mordor";
            liste.Add(zeitung);

            CD cd = new CD();
            cd.interpret = "Megaherz";
            cd.titel = "Kopfschuss";
            cd.erscheinung = 2000;
            cd.dauer = 43;

            liste.Add(cd);

            DVD dvd = new DVD();
            dvd.dauer = 96;
            dvd.titel = "Matrix";
            dvd.erscheinung = 1999;
            dvd.regisseur = "Wachovskis";

            liste.Add(dvd);

            lstMedien.ItemsSource = liste.list;

        }

        private void btn_neu_Click(object sender, RoutedEventArgs e)
        {
            Window window = new Window();
            window.Show();
        }
    }
}