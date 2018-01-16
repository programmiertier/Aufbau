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
            StreamWriter schreib = new StreamWriter(@"C:\Users\Zimmermann\Documents\datei.txt");
            // so geht es halt auch
            // FileStream stream = new FileStream(@"C:\Users\Zimmermann\Documents\datei.txt", FileMode.CreateNew);
            // StreamWriter schreib2 = new StreamWriter(stream);

            schreib.WriteLine("heute ist Dienstag");
            schreib.WriteLine("und morgen ist Mittwoch");
            schreib.Flush();
            schreib.Close();
            WriteLine("das schreiben ist vorbei");
            ReadLine();
            StreamReader lies = new StreamReader(@"C:\Users\Zimmermann\Documents\datei.txt");
            // so lange hier noch was steht
            while (lies.Peek() != -1)   
            {
                WriteLine(lies.ReadLine());
            }
            lies.Close();

            lies = new StreamReader(@"C:\Users\Zimmermann\Documents\datei.txt");
            WriteLine(lies.ReadToEnd());
            lies.Close();
            // Write(lies.ReadToEnd());
            ReadLine();
        }
    }
}
