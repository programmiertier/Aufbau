﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliothek
{
    class CD : OptischeMedien
    {
        public string interpret;
        public CD() { }

        public override string ToString()
        {
            return base.ToString() + " (CD)";
        }
    }
}
