using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.IO;
using Miau;     // verwendet den Namespace Miau

namespace DeKatzen
{
    class Program
    {
        // nur innerhalb der Klasse verwandt
        private static ListeKatze liste = new ListeKatze();
        private static string pfad = @"C:\Uebung\katze.dat";
        // private static char ende = 'n';     // so lange 'n' steht, läuft die Schleife
        static void Main(string[] args)
        {
            liste = new ListeKatze();
            liste.liste = Datei.listeEinlesen(pfad);
            do
            {
                WriteLine("Katzen erstellen heute in simpel");
                WriteLine(new string('=', 30));
                WriteLine("1 Katze erstellen");
                WriteLine("2 alle Katzen zeigen");
                WriteLine("3 eine Katze anzeigen");
                WriteLine("4 binär speichern");
                WriteLine("5 Serialisiert speichern");
                WriteLine("ESC für beenden");
                WriteLine("Auswahl bitte: ");

                int auswahl = Read();
                // ginge auch
                // char auswahl = Convert.ToChar(Read());
                // ginge auch
                // char auswahl2 = (char)Read();

                // switch oder if else, beides geht

                switch (auswahl)
                {
                    case '1':
                        liste.Hinzufuegen(katzeEingeben());
                        break;
                    case '2':
                        alleAnzeigen();
                        break;
                    case '3':
                        int id = katzeSuchenEingabe();
                        katzeAnzeigen(liste.SucheKatze(id), id);
                        break;
                    case '4':
                        Datei.ListeSpeichern(pfad, liste.liste);
                        break;
                    case '5':
                        Datei.serialisierungObjekt(pfad, liste.liste);
                        break;
                    case '6':
                        Datei.ListeSpeichern(pfad, liste.liste);
                        Environment.Exit(0);
                        break;
                    default:
                        WriteLine("Falsche Eingabe!");
                        break;
                }
            }
            
            while (true);
            // while (ReadKey().Key != ConsoleKey.Escape);
            /*
            while (true)
            {
                return;
            }   */
            /* WriteLine("Welches Katzerl hätten's denn gern?");
            WriteLine(new string('=', 30));
            ReadLine();
            FileStream leserStream = new FileStream(@"c:\Uebung\deKatzen.txt", FileMode.OpenOrCreate);
            StreamReader leser = new StreamReader(leserStream);
            WriteLine(leser.ReadToEnd());
            leser.Close();

            FileStream schreibenStream = new FileStream(@"c:\Uebung\deKatzen.txt", FileMode.Create);
            StreamWriter schreiber = new StreamWriter(schreibenStream);
            schreiber.WriteLine("hi na");
            schreiber.Close();

            WriteLine("Welche Katzen möchten Sie begutachten?");
            int katze = Convert.ToInt32(ReadLine());
            WriteLine("Katze Nummer {0}", katze);   */
        }
        private static Katze katzeEingeben()
        {
            Katze miez = new Katze();
            Clear();
            WriteLine("Eingabe eines Autos.");
            WriteLine(new string('-', 30));
            Write("Baujahr: ");
            miez.baujahr = Convert.ToInt32(ReadLine());
            Write("Km-Stand: ");
            miez.futterStand = Convert.ToInt32(ReadLine());
            Write("Leistung in PS: ");
            miez.schlafLeistung = Convert.ToInt32(ReadLine());
            return miez;
        }

        private static void alleAnzeigen()
        {
            Clear();
            WriteLine("Alle Fahrzeuge anzeigen");
            WriteLine(new string('-', 30));
            for (int i = 0; i < liste.liste.Count; i++)
            {
                katzeAnzeigen(liste.liste[i], i);
                WriteLine(new string('/', 30));
            }
        }

        private static void katzeAnzeigen(Object miez, int id)
        {
            if (miez != null)
            {
                Katze mi = (Katze)miez;
                WriteLine("Katzennummer: " + id);
                WriteLine("Baujahr: " + mi.baujahr);
                WriteLine("Futterstand: " + mi.futterStand);
                WriteLine("Schlafleistung: " + mi.schlafLeistung);
                WriteLine("Weiter mit der ENTER-Taste");
            }
            else
            {
                WriteLine("Katzennummer: " + id);
                WriteLine("Nicht vorhanden!");
            }
            ReadLine();
        }

        private static int katzeSuchenEingabe()
        {
            Clear();
            WriteLine("Katze suchen");
            WriteLine(new string('-', 30));
            Write("Welche Katzen-ID wollen sie suchen: ");
            int id = Convert.ToInt32(ReadLine());
            return id;
        }
    }
}
