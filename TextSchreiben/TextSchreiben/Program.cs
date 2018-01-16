using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.IO;

namespace TextSchreiben
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter schreib = new StreamWriter(@"C:\datei.txt");
            FileStream stream = new FileStream(@"C:\datei.txt", FileMode.CreateNew);
            StreamWriter schreib2 = new StreamWriter(stream);
        }
    }
}
