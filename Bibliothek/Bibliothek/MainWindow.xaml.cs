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

            liste.add(buch);

            Zeitung zeitung = new Zeitung();
            zeitung.ausgabe = 1;
            zeitung.titel = "Zeit";
            zeitung.isbn = "9-999-12345-2";
            zeitung.verlag = "Mordor";
            liste.add(zeitung);

            CD cd = new CD();
            cd.interpret = "Megaherz";
            cd.titel = "Kopfschuss";
            cd.erscheinung = 2000;
            cd.dauer = 43;

            liste.add(cd);

            DVD dvd = new DVD();
            dvd.dauer = 96;
            dvd.titel = "Matrix";
            dvd.erscheinung = 1999;
            dvd.regisseur = "Wachovskis";

            liste.add(dvd);

            lstMedien.ItemsSource = liste.list;

        }


        private void lstMedien_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            btn_bearbeiten.IsEnabled = true;
            btn_loeschen.IsEnabled = true;
        }

        private void btn_neu_Click(object sender, RoutedEventArgs e)
        {
            stackEingabe.Visibility = Visibility.Visible;
            stackListe.Visibility = Visibility.Collapsed;
            btn_abbrechen.IsEnabled = true;
        }

        private void cmbtyp_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cmbtyp.SelectedIndex == 0)
            {
                lblausgabenummer.Content = "Autor";
                lblISBN.Content = "ISBN";
                txtVerlag.Visibility = Visibility.Visible;
                lblVerlag.Visibility = Visibility.Visible;
            }
            else if (cmbtyp.SelectedIndex == 1)
            {
                lblausgabenummer.Content = "Ausgabenummer";
                lblISBN.Content = "ISBN";
                txtVerlag.Visibility = Visibility.Visible;
                lblVerlag.Visibility = Visibility.Visible;
            }
            else if (cmbtyp.SelectedIndex == 2)
            {
                lblausgabenummer.Content = "Regisseur";
                lblISBN.Content = "Dauer";
                txtVerlag.Visibility = Visibility.Collapsed;
                lblVerlag.Visibility = Visibility.Collapsed;
            }
            else if (cmbtyp.SelectedIndex == 3)
            {
                lblausgabenummer.Content = "Interpret";
                lblISBN.Content = "Dauer";
                txtVerlag.Visibility = Visibility.Collapsed;
                lblVerlag.Visibility = Visibility.Collapsed;
            }
        }

        private void btn_abbrechen_Click(object sender, RoutedEventArgs e)
        {
            stackEingabe.Visibility = Visibility.Collapsed;
            stackListe.Visibility = Visibility.Visible;
            btn_abbrechen.IsEnabled = false;
        }
    }
}