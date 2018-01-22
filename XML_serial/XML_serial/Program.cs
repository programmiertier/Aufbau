using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using Miau;

namespace XML_serial
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> liste = new List<Person>();

            Person person = new Person("Anna Alles", 34);
            liste.Add(person);
            person = new Person("Blabla Bla", 37);
            liste.Add(person);
            Datei.xmlSerialisierungObjekt(@"C:\Uebung\serial.xml", liste, typeof(List<Person>));

            List<Person> listeNeu = new List<Person>();
            listeNeu = (List<Person>)Datei.xmlDeseriasierungObjekt(@"C:\Uebung\serial.xml", typeof(List<Person>));
            foreach(Person temp in listeNeu)
            {
                WriteLine("Name\t" + temp.name);
                WriteLine("Alter\t" + temp.alter);
            }
            /* Person personneu = new Person();
            personneu = (Person)Datei.xmlDeseriasierungObjekt(@"C:\Uebung\serial.xml", typeof(Person));
            WriteLine("Name " + personneu.name);
            WriteLine("Alter " + personneu.alter);
            */
            ReadLine();
        }
    }
}
