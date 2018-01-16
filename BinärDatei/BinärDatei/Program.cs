using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.IO;

namespace BinärDatei
{
    class Program
    {
        static void Main(string[] args)
        {
            // eine Datei erzeugen und einen integer-Wert in die Datei schreiben

            FileStream stream = new FileStream(@"C:\Users\Zimmermann\Documents\datei.txt", FileMode.Create);
            BinaryWriter schreiben = new BinaryWriter(stream);

            int zahl = 500;
            schreiben.Write(zahl);
            schreiben.Close();

            // Datei öffnen und den Inhalt byteweise auslesen
            FileInfo fi = new FileInfo(@"C:\Users\Zimmermann\Documents\datei.txt");
            FileStream fs = new FileStream(@"C:\Users\Zimmermann\Documents\datei.txt", FileMode.Open);

            byte[] byteArr = new byte[fi.Length];

            // Datenstrom in ein Byte-Array lesen
            fs.Read(byteArr, 0, (int)fi.Length);

            // Ausgabe in der Konsole
            WriteLine("Interpretation als Byte-Array:");
            for (int zaehl = 0; zaehl < fi.Length; zaehl++)
            {
                WriteLine(byteArr[zaehl]);
            }
            WriteLine();
            WriteLine();
            fs.Close();

            ReadLine();
        }
    }
}
