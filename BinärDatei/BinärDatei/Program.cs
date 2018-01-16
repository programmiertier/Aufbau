using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.IO;

namespace BinärDatei
{
    class Program
    {
        static void Main(string[] args)
        {
            // eine Datei erzeugen und einen integer-Wert in die Datei schreiben

            FileStream stream = new FileStream(@"C:\Users\Zimmermann\Documents\datei.txt", FileMode.Create);
            BinaryWriter schreiben = new BinaryWriter(stream);
        }
    }
}
