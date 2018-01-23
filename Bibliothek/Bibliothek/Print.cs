using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliothek
{
    class Print : Medium
    {
        private string _isbn { get; set; }

        public string isbn { get { return _isbn; } set { if (value.Length == 13 || value.Length == 10) { _isbn = value; } } }
        public string verlag { get; set; }
    }
}
