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
        private static List<Katze> listeKatze = new List<Katze>();
        private static string pfad;
        // private static char ende = 'n';     // so lange 'n' steht, läuft die Schleife
        static void Main(string[] args)
        {
            do
            {
                WriteLine("Katzen erstellen heute in simpel");
                WriteLine(new string('=', 30));
                WriteLine("1 Katze erstellen");
                WriteLine("2 alle Katzen zeigen");
                WriteLine("3 eine Katze anzeigen");
                WriteLine("4 speichern");
                WriteLine("ESC für beenden");
                WriteLine("Auswahl bitte: ");
                
                int auswahl = Read();
                // ginge auch
                // char auswahl = Convert.ToChar(Read());
                // ginge auch
                // char auswahl2 = (char)Read();

                // switch oder if else, beides geht

                switch (ReadKey().Key)
                {  }
            }
            while (ReadKey().Key != ConsoleKey.Escape);
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
    }
}
