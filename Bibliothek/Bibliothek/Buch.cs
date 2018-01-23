using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliothek
{
    class Buch : Print
    {
        public string autor { get; set; }
        private string _widmung;
        public string widmung { get { return _widmung; } set { _widmung = value; } }
        public Buch() { }
        public Buch(string _titel, int _erscheinung, int _seiten)
        {
            titel = _titel;
            erscheinung = _erscheinung;
        }
    }
}
