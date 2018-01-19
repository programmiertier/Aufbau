using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Miau
{
    public class Datei
    {
        public static void ListeSpeichern(string pfad, List<Object> liste)
        {
            FileStream fs = new FileStream(pfad, FileMode.Create);
            BinaryWriter writer = new BinaryWriter(fs);

            writer.Write(liste.Count);
            for (int i = 0; i < liste.Count; i++)
            {
                /* writer.Write(((Katze)liste[i]).baujahr);
                writer.Write(((Katze)liste[i]).futterStand);
                writer.Write(((Katze)liste[i]).schlafLeistung);*/
            }
            writer.Close();
        }

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
                    /* Katze miau = new Katze();
                    miau.baujahr = reader.ReadInt32();
                    miau.futterStand = reader.ReadInt32();
                    miau.schlafLeistung = reader.ReadInt32();
                    liste.Add(miau);    */
                }
                reader.Close();
            }
            else
            {
                liste = null;
            }

            return liste;
        }

        public static void serialisierungObjekt(string pfad, object obj)
        {
            FileStream fs = new FileStream(pfad, FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(obj);
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
    }
}
