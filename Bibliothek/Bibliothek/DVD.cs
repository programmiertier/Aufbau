using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliothek
{
    class DVD : OptischeMedien
    {
        public string regisseur { get; set; }
        public DVD() { }

        public override string ToString()
        {
            return base.ToString() + " (DVD)";
        }
    }
}
