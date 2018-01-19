using System;
using System.Collections.Generic;
using static System.Console;
using Miau;

namespace Serialisierung
{
    class Program
    {
        static void Main(string[] args)
        {
            // alternativ auch Liste möglich!
            List<Object> liste = new List<Object>();
            Person babyPorg = new Person(1, "BabyPorg");
            liste.Add(babyPorg);
            babyPorg = new Person(5, "Porg");
            liste.Add(babyPorg);

            Datei.serialisierungObjekt(@"C:\Uebung\serial.dat", liste);
            List<Person> listeNeu = new List<Person>();
            listeNeu = (List<Person>)Datei.deserialisiereObjekt(@"C:\Uebung\serial.dat");
            
            for (int zaehl = 0; zaehl < listeNeu.Count; zaehl++)
            {
                WriteLine(((Person)listeNeu[zaehl]).alter + " " + ((Person)listeNeu[zaehl])._name);
            }
            ReadLine();

        }
    }
}
