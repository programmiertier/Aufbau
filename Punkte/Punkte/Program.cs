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
            Point p = new Point();
            p.XPos = 10;
            p.YPos = 20;
            p.color = 310;

            pArr[0] = p;

            p = new Point();
            p.XPos = 40;
            p.YPos = 50;
            p.color = 110;

            pArr[1] = p;
            /*
            pArr[0].XPos = 10;
            pArr[0].YPos = 20;
            pArr[0].color = 310;
            pArr[1].XPos = 40;
            pArr[1].YPos = 50;
            pArr[1].color = 110;    */

            // Point-Array speichern
            SchreibInDatei(@"C:\Users\Zimmermann\Documents\punkte.dat", pArr);

            // gespeicherte Informationen aus Datei einlesen
            Point[] neuesArr = HolePunkte(@"C:\Users\Zimmermann\Documents\punkte.dat");

            //alle Points ausgeben
            for(int zaehl = 0; zaehl < neuesArr.Length; zaehl++)
            {
                WriteLine("Point-Objekt-Nr. {0}", zaehl + 1);
                WriteLine();
                WriteLine("neuesArry[{0}].XPos = {1}", zaehl, neuesArr[zaehl].XPos);
                WriteLine("neuesArry[{0}].YPos = {1}", zaehl, neuesArr[zaehl].YPos);
                WriteLine("neuesArry[{0}].color = {1}", zaehl, neuesArr[zaehl].color);
                WriteLine(new string('=', 30));
            }
            

            // einen bestimmten Point einlesen
            WriteLine("Welchen Punkt möchten Sie einlesen");
            int position = Convert.ToInt32(ReadLine());
            try
            {
                Point meinPoint = HolePunkt(@"C:\Users\Zimmermann\Documents\punkte.dat", position);
                WriteLine("meinPoint.XPos = {0}", meinPoint.XPos);
                WriteLine("meinPoint.YPos = {0}", meinPoint.YPos);
                WriteLine("meinPoint.color = {0}", meinPoint.color);
            }
            catch (PositionException e)
            {
                WriteLine(e.Message);
            }
            ReadLine();
        }

        private static Point HolePunkt(string pfad, int punktNr)
        {
            FileStream fs = new FileStream(pfad, FileMode.Open);
            int pos = 4 + (punktNr - 1) * 16;
            BinaryReader binLeser = new BinaryReader(fs);
            if (punktNr > binLeser.ReadInt32() || punktNr == 0)
            {
                string nachricht = "Unter der angegebenen Position ist";
                nachricht += " kein Point-Objekt gespeichert";
                throw new PositionException(nachricht);
            }
                // Zeiger positionieren
                // mit seek positionieren wir ihn im Zeiger
                fs.Seek(pos, SeekOrigin.Begin);
                Point punkt = new Point();
                punkt.XPos = binLeser.ReadInt32();
                punkt.YPos = binLeser.ReadInt32();
                punkt.color = binLeser.ReadInt32();
                binLeser.Close();
                return punkt;
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
            binLeser.Close();
            return arrPoint;
        }

    }

    // eigene Exception schreiben
    public class PositionException : Exception
    {
        // leerer Konstruktor
        public PositionException() { }

        // mit Message
        public PositionException(string message) : base (message) { }

        // mit Message und inner Exception
        public PositionException(string message, Exception inner)  : base (message, inner) { }
    }

    struct Point
    {
        public int XPos { get; set; }
        public int YPos { get; set; }
        public long color { get; set; }     // long entspricht int64
    }
}
