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
            List<Person> liste = new List<Person>();
            Person babyPorg = new Person(1, "BabyPorg");
            liste.Add(babyPorg);
            babyPorg = new Person(5, "Porg");
            liste.Add(babyPorg);
            FileStream stream;
            stream = new FileStream(@"C:\Uebung\person.dat", FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();
            // formatter.Serialize(stream, babyPorg);
            formatter.Serialize(stream, liste);
            stream.Close();
            
            
            // BinaryFormatter formatter = new BinaryFormatter();
            // bekommt Objekte (Katze oder Liste und schreibt sie direkt in den Stream rein)
            // formatter.Serialize(Stream, object);
            // formatter.Deserialize(Stream);
        }
    }
}
