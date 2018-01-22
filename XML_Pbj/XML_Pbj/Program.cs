using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using static System.Console;

namespace XML_Pbj
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlReader reader = XmlReader.Create(@"C:\Uebung\Person.xml");
            List<Person> liste = new List<Person>();
            Person person = null;
            Adresse adresse = null;

            while(reader.Read())
            {
                // Prüfen, ob es sich um ein Element / Kommentar usw handelt
                if(reader.NodeType==XmlNodeType.Element)
                {
                    // alle relevanten Elemente untersuchen
                    switch(reader.Name)
                    {
                        case "Person":
                            person = new Person();
                            liste.Add(person);
                            break;
                        case "Vorname":
                            person.vorname = reader.ReadString();
                            break;
                        case "Zuname":
                            person.zuname = reader.ReadString();
                            break;
                        case "Alter":
                            person.alter = reader.ReadElementContentAsInt();
                            break;
                        case "Adresse":
                            adresse = new Adresse();
                            person.adresse = adresse;
                            if(reader.HasAttributes)
                            {
                                while(reader.MoveToNextAttribute())
                                {
                                    if(reader.Name == "Ort")
                                    {
                                        adresse.ort = reader.Value;
                                    }
                                    else if(reader.Name == "Strasse")
                                    {
                                        adresse.strasse = reader.Value;
                                    }
                                }
                            }
                            break;
                    }
                }
            }
            // Liste ausgeben
            GetList(liste);
            reader.Close();
            ReadLine();

        }
        static void GetList(List<Person> liste)
        {
            foreach(Person temp in liste)
            {
                WriteLine("Vorname: {0} \tZuname: {1}\tAlter: {2}\n", temp.vorname, temp.zuname, temp.alter);
                WriteLine("Ort: {0}\tStrasse:{1}\n", temp.adresse.ort, temp.adresse.strasse);
            }
        }
    }
}
