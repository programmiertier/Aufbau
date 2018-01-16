using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.IO;

namespace Textdatei
{
    class Program
    {
        static void Main(string[] args)
        {
            // Benutzereingabe anfordern
            WriteLine("Geben Sie die zu öffnende Datei an");
            string dateiName = ReadLine();

            // Plausibilitätsprüfung... überspringen, davon gehen wir einfach mal aus
            if (! File.Exists(dateiName))
            {
                WriteLine("Die Datei {0} existiert nicht", dateiName);
                ReadLine();
                return;
            }
            else
            {
                FileStream dateiStream = File.Open(dateiName, FileMode.Open);

                // byte-Array, in die Datei aus dem Datenstrom lesen
                byte[] puffer = new byte[dateiStream.Length];

                // Zeichen aus der Datei lesen und in Array schreiben
                dateiStream.Read(puffer, 0, (int)dateiStream.Length);   // (int) explizit als int ausgewiesen!

                // das byte-Array elementweise einlesen und jedes Array-Element in Char konvertieren
                for (int zaehl = 0; zaehl < dateiStream.Length; zaehl++)
                {
                    WriteLine(Convert.ToChar(puffer[zaehl]));
                }
                ReadLine();
            }
        }
    }
}
