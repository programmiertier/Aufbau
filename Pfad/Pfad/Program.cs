using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static System.Console;

namespace Pfad
{
    class Program
    {
        static void Main(string[] args)
        {
            string pfad = @"C:\Windows\system32.kernell32.dll";

            // gibt C:\ zurück
            WriteLine(Path.GetPathRoot(pfad));

            // gibt C:\Windows\system32 -> bis zum letzten \
            WriteLine(Path.GetDirectoryName(pfad));

            // gibt kernell32.dll
            WriteLine(Path.GetFileName(pfad));

            // gibt C:\Windows\system32\kernell32.dll
            WriteLine(Path.GetFullPath(pfad));

            // gibt .dll
            WriteLine(Path.GetExtension(pfad));

            // gibt Pfad zum Temp-Ordner zurück
            WriteLine(Path.GetTempPath());

            Path.GetTempFileName();
            ReadLine();
        }
    }
}
