using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialisierung
{
    // die Klasse als ganzes ist serialisierbar
    [Serializable()]
    class Person
    {
        public string _name { get; set; }
        private int _alter;

        public int alter { get { return _alter; } }

        public Person(int alter, string name)
        {
            _alter = alter;
            _name = name;
        }
    }
}
