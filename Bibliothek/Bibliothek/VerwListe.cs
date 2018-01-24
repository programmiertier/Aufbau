using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliothek
{
    class VerwListe
    {
        private static int counter;
        public List<Medium> list { get; set; }

        public VerwListe()
        {
            list = new List<Medium>();
            counter = 0;
        }

        public void add(Medium medium)
        {
            list.Add(medium);
            counter = +1;
        }


    }
}
