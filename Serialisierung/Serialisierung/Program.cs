using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

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
            FileStream stream;
            stream = new FileStream(@"C:\Uebung\person.dat", FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, babyPorg);
            // formatter.Serialize(stream, liste);
            stream.Close();

            stream = new FileStream(@"C:\Uebung\person.dat", FileMode.Open);
            BinaryFormatter formatter1 = new BinaryFormatter();

            // gibt ein Object. unser Object ist aus der Klasse Person
            babyPorg = (Person)formatter1.Deserialize(stream);
            WriteLine(babyPorg.alter + " " + babyPorg._name);
            ReadLine();

            BinaryFormatter formatter2 = new BinaryFormatter();
            List<Object> neueListe = new List<Object>();
            neueListe = (List<Object>)formatter2.Deserialize(stream);
            for (int zaehl = 0; zaehl < neueListe.Count; zaehl++)
            {
                WriteLine(((Person)neueListe[zaehl]).alter + " " + ((Person)neueListe[zaehl])._name);
            }
            ReadLine();

        }
    }
}
