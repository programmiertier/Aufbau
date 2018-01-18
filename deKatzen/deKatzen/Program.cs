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
        static void Main(string[] args)
        {


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

            ReadLine();
        }
    }
}
