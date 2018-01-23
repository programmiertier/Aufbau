using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Xml.Serialization;

namespace Klassenbibo
{
    /// <summary>
    /// 
    /// </summary>
    public class Datei
    {
        /// <summary>
        /// Speichert die Liste in eine Datei
        /// </summary>
        /// <param name="pfad">absoluter Pfad zur Datei</param>
        /// <param name="liste">die Liste die gespeichert werden soll</param>
        public static void listeSpeichern(string pfad, List<Object> liste)
        {
            FileStream fs = new FileStream(pfad, FileMode.Create);
            BinaryWriter writer = new BinaryWriter(fs);

            writer.Write(liste.Count);
            for(int i=0;i<liste.Count;i++)
            {
                writer.Write(((Auto)liste[i]).baujahr);
                writer.Write(((Auto)liste[i]).kmStand);
                writer.Write(((Auto)liste[i]).leistung);
            }
            writer.Close();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pfad">absoluter Pfad zur Datei</param>
        /// <returns>Liste mit den Inhalten der Datei</returns>
        public static List<Object> listeEinlesen(string pfad)
        {
            List<Object> liste;
            if (File.Exists(pfad))
            {
                FileStream fs = new FileStream(pfad, FileMode.Open);
                BinaryReader reader = new BinaryReader(fs);

                int anzahl = reader.ReadInt32();
                liste = new List<Object>();
                for (int i = 0; i < anzahl; i++)
                {
                    Auto pkw = new Auto();
                    pkw.baujahr=reader.ReadInt32();
                    pkw.kmStand=reader.ReadInt32();
                    pkw.leistung=reader.ReadInt32();
                    liste.Add(pkw);
                }
                reader.Close();
            }
            else
            {
                liste = null;
            }

            return liste;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pfad"></param>
        /// <param name="obj"></param>
        public static void serialisierungObjekt(string pfad, object obj)
        {
            FileStream fs = new FileStream(pfad, FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fs, obj);
            fs.Close();
        }

        public static Object deserialisiereObjekt(string pfad)
        {
            FileStream fs = new FileStream(pfad, FileMode.Open);
            BinaryFormatter formatter = new BinaryFormatter();
            object obj = formatter.Deserialize(fs);
            fs.Close();
            return obj;
        }

        public static void xmlSerialisierungObjekt(string pfad, object obj, Type type)
        {
            FileStream fs = new FileStream(pfad, FileMode.Create);
            XmlSerializer serializer = new XmlSerializer(type);
            serializer.Serialize(fs, obj);
            fs.Close();
        }

        public static object xmlDeseriasierungObjekt(string pfad, Type type)
        {
            FileStream fs = new FileStream(pfad, FileMode.Open);
            XmlSerializer serializer = new XmlSerializer(type);
            object obj = serializer.Deserialize(fs);
            fs.Close();
            return obj;
        }
    }
}
