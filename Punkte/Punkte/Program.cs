using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.IO;

namespace Punkte
{
    class Program
    {
        static void Main(string[] args)
        {
            //Point-Array erzeugen
            Point[] pArr = new Point[2];
            pArr[0].XPos = 10;
            pArr[0].YPos = 20;
            pArr[0].color = 310;
            pArr[1].XPos = 40;
            pArr[1].YPos = 50;
            pArr[1].color = 110;
            SchreibInDatei(@"C:\Users\Zimmermann\Documents\punkte.dat", pArr);
        }

        public static void SchreibInDatei(string path, Point[] array)
        {
            FileStream datenStream = new FileStream(path, FileMode.Create);
            BinaryWriter binSchreiber = new BinaryWriter(datenStream);

            //Anzahl der Punkte in die Datei schreiben
            binSchreiber.Write(array.Length);

            //die Poin-Datenin die Datei schreiben
            for (int i = 0; i < array.Length; i++)
            {
                binSchreiber.Write(array[i].XPos);
                binSchreiber.Write(array[i].YPos);
                binSchreiber.Write(array[i].color);
            }
            binSchreiber.Close();
        }

        public static Point[] HolePunkte(string pfad)
        {
            // if else Datei da oder nicht, sollte eigentlich vorhanden sein
            FileStream fs = new FileStream(pfad, FileMode.Open);
            BinaryReader binLeser = new BinaryReader(fs);

            // list die ersten 4 Bytes aus der Datei, die die Anzahl der Point-Objekte enthält
            int anzahl = binLeser.ReadInt32();

            // Lesen der Daten aus der Datei
            Point[] arrPoint = new Point[anzahl];
            for (int zaehl = 0; zaehl < anzahl; zaehl++)
            {
                arrPoint[zaehl].XPos = binLeser.ReadInt32();
                arrPoint[zaehl].YPos = binLeser.ReadInt32();
                arrPoint[zaehl].color = binLeser.ReadInt64();       // Int64 ist ein Long
            }
        }

    }

    struct Point
    {
        public int XPos { get; set; }
        public int YPos { get; set; }
        public long color { get; set; }     // long entspricht int64
    }
}
