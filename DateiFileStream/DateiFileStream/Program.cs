using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.IO;

namespace DateiFileStream
{
    class Program
    {
        static void Main(string[] args)
        {
            // public FileStream(string pfad, FileMode mode);
            FileStream fs = new FileStream(@"C:\Users\Zimmermann\Documents\C#\Aufbau\DateiFileStream\schreiben.txt", FileMode.OpenOrCreate);
            // byte[] array = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
            byte[] array = { (byte)'D', (byte)'a', (byte)'s' };
            fs.Write(array, 0, array.Length);

            // Schreiben des Inhaltes in die Datei
            ReadLine();

            // fs.Close();
            // Positionszeiger an den Anfang setzen
            fs.Position = 0;
            byte[] arrayRead = new byte[10];

            // lesen der Byteblöcke aus dem Stream
            fs.Read(arrayRead, 0, 10);

            // Ausgabe des Arrayinhaltes
            for (int zaehl = 0; zaehl < arrayRead.Length; zaehl++)
            {
                WriteLine(arrayRead[zaehl]);
            }
            fs.Close();

            ReadLine();
        }
    }
}
