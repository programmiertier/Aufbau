using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miau
{
    public class ListeKatze
    {
        public List<Object> liste { get; set; }
        public ListeKatze()
        {
            liste = new List<Object>();
        }

        public void Hinzufuegen(Object katze)
        {
            liste.Add(katze);
        }

        public Object SucheKatze(int id)
        {
            Object miez = new Object();
            if (id > 0 && liste.Count >= id)
            {
                miez = liste[id - 1];
            }
            else
            {
                miez = null;
            }
            return miez;
        }
    }
}