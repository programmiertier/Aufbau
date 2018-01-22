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
            Person person = new Person("Anna Alles", 34);
            Datei.xmlSerialisierungObjekt(@"C:\Uebung\serial.xml", person, typeof(Person));

            Person personneu = new Person();
            personneu = (Person)Datei.xmlDeseriasierungObjekt(@"C:\Uebung\serial.xml", typeof(Person));
            WriteLine("Name " + personneu.name);
            WriteLine("Alter " + personneu.alter);
            ReadLine();
        }
    }
}
