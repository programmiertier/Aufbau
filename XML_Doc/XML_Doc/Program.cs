using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.Xml;

namespace XML_Doc
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlReader reader = XmlReader.Create(@"C:\Uebung\Person.xml");
            while (reader.Read())
            {
                switch(reader.NodeType)
                {
                    case XmlNodeType.XmlDeclaration:
                        WriteLine("{0, -20}<{1}>", "Deklaration", reader.Value);
                        break;
                    case XmlNodeType.CDATA:
                        WriteLine("{0, -20}<{1}>", "CDATA", reader.Value);
                        break;
                    case XmlNodeType.Whitespace:
                        WriteLine("{0, -20}", "WHITESPACE");
                        break;
                    case XmlNodeType.Comment:
                        WriteLine("{0, -20}<!--{1}-->", "Comment", reader.Value);
                        break;
                    case XmlNodeType.Element:
                        if(reader.IsEmptyElement)
                        {
                            WriteLine("{0, -20}<{1}/>", "EMPTY ELEMENT", reader.Name);
                        }
                        else
                        {
                            WriteLine("{0, -20}<{1}>", "ELEMENT", reader.Name);
                            // Prüfe, ob node Attribute besitzt
                            if(reader.HasAttributes)
                            {
                                // durch Attribute navigieren
                                while(reader.MoveToNextAttribute())
                                {
                                    WriteLine("{0, -20}{1}", "ATTRIBUT", reader.Name + "=" + reader.Value);
                                }
                            }
                        }
                        break;
                    case XmlNodeType.EndElement:
                        WriteLine("{0, -20}</{1}>", "END ELEMENT", reader.Name);
                        break;
                    case XmlNodeType.Text:
                        WriteLine("{0, -20}{1}", "TEXT", reader.Value);
                        break;
                }
                ReadLine();
            }
        }
    }
}
