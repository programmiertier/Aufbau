using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.Xml;

namespace XML_schreiben
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlWriterSettings settings = new XmlWriterSettings();
            // damit eingerückt wird
            settings.Indent = true;
            settings.IndentChars = "    ";    // 4 Leerzeichen einrücken
            XmlWriter writer = XmlWriter.Create(@"C:\Uebung\Person_schreiben.xml", settings);
            writer.WriteStartDocument();    // gibt den Anfang der Datei dar xml version blabla

            // Starttag
            writer.WriteStartElement("Personen");
            writer.WriteComment("Die Datei wurde von XmlWriter erzeugt");

            // Starttag von Person
            writer.WriteStartElement("Person");
            writer.WriteElementString("Zuname", "Meier");
            writer.WriteElementString("Vorname", "Horst");

            // Element mit Attributen
            writer.WriteStartElement("Adresse");
            writer.WriteAttributeString("Ort", "WeitAb");
            writer.WriteAttributeString("Strasse", "Beim Feld 1");
            writer.WriteValue("Wurzelland");

            // Endtag von Person
            writer.WriteEndElement();

            // Endtag des Stammelements
            writer.WriteEndElement();
            writer.WriteEndDocument();
            writer.Close();

            WriteLine(@" Datei C:\Uebung\Person_schreiben.xml erzeugt");
            ReadLine();
        }
    }
}
