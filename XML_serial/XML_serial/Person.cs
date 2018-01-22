using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XML_serial
{
    public class Person
    {
        public int alter { get; set; }
        private string _name;
        public Person() { }
        public string name
        {
            get { return _name; }
            set { _name = value; }
        }
        public Person(string name, int alter)
        { name = name;
            alter = alter;
        }
    }
}
