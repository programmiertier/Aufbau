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
using Datenbindung01;
using System.Collections.ObjectModel;

namespace DatenbindungList
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Person> liste = new ObservableCollection<Person>();
        public MainWindow()
        {
            liste.Add(new Person { name = "V Zim", adresse = "Köln", alter = 31 });
            liste.Add(new Person { name = "Klaus Kleber", adresse = "Köln", alter = 79 });
            liste.Add(new Person { name = "Karla Meier", adresse = "Berlin", alter = 46 });
            liste.Add(new Person { name = "Paul Paulchen", adresse = "Mainz", alter = 23 });
            liste.Add(new Person { name = "Otto Friede", adresse = "Flensburg", alter = 80 });
            liste.Add(new Person { name = "Martha Bauer", adresse = "München", alter = 56 });
            InitializeComponent();
            listBox1.ItemsSource = liste;
            listBox1.DisplayMemberPath = "name";
            listBox1.SelectedIndex = 0;
            listBox1.Focus();
            lstView.ItemsSource = liste;
            
        }


        private void btn_bearbeiten_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_hinzufuegen_Click(object sender, RoutedEventArgs e)
        {
            // Binding hinzufügen
            BindingOperations.ClearBinding(txtName, TextBox.TextProperty);
            BindingOperations.ClearBinding(txtAdresse, TextBox.TextProperty);
            BindingOperations.ClearBinding(txtAlter, TextBox.TextProperty);
            txtName.Text = txtAlter.Text = txtAdresse.Text = "";
            txtName.Focus();
            btn_hinzufuegen.IsEnabled = false;
            btn_abbrechen.IsEnabled = true;
            btn_speichern.IsEnabled = true;
            btn_loeschen.IsEnabled = false;
        }

        private void btn_speichern_Click(object sender, RoutedEventArgs e)
        {
            Person person = new Person();
            person.name = txtName.Text;
            person.adresse = txtAdresse.Text;
            person.alter = Convert.ToInt32(txtAlter.Text);
            liste.Add(person);
            btn_hinzufuegen.IsEnabled = false;
            btn_abbrechen.IsEnabled = true;
            btn_speichern.IsEnabled = true;
            btn_loeschen.IsEnabled = true;
            setBinding();
            listBox1.SelectedItem = person; // noch einfacher, als die Zeile drunter
            // listBox1.SelectedIndex = listBox1.Items.Count - 1;  // letztes hinzugefügtes
        }

        private void btn_abbrechen_Click(object sender, RoutedEventArgs e)
        {
            btn_hinzufuegen.IsEnabled = true;
            btn_loeschen.IsEnabled = true;
            btn_abbrechen.IsEnabled = false;
            btn_speichern.IsEnabled = false;
            listBox1.SelectedIndex = 0;
            setBinding();
        }

        private void btn_loeschen_Click(object sender, RoutedEventArgs e)
        {
            liste.RemoveAt(listBox1.SelectedIndex);
        }

        private void setBinding()
        {
            // bindung neu festlegen
            Binding binding = new Binding("name");
            txtName.SetBinding(TextBox.TextProperty, binding);
            binding = new Binding("adresse");
            txtAdresse.SetBinding(TextBox.TextProperty, binding);
            binding = new Binding("alter");
            txtAlter.SetBinding(TextBox.TextProperty, binding);
        }

        private void btnObjekt_Click(object sender, RoutedEventArgs e)
        {
            liste[1].adresse = "zuhause";
            liste[1].alter = 44;
            liste[1].name = "voll wichtig";

            // geht so auch
            liste.Add(new Person { name = "Anna Berta", alter = 30, adresse = "Berlin" });
        }
    }
}
