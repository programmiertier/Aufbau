using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliothek
{
    class Zeitung : Print
    {
        public int ausgabe { get; set; }
        public Zeitung() { }
        public Zeitung(string _titel, int _erscheinung, int _seiten)
        {
            titel = _titel;
            erscheinung = _erscheinung;
        }
    }
}
