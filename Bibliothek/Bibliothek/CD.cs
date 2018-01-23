using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliothek
{
    class CD : Medium
    {
        public int spieldauer;
        public CD() { }
        public CD(string _titel, int _erscheinung, int _spieldauer)
        {
            titel = _titel;
            erscheinung = _erscheinung;
            spieldauer = _spieldauer;
        }
    }
}
