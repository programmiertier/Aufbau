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

            // erzeugt eine Datei im Temp-Ordner und liefert den kompletten Pfad zurück
            string tempDatei = Path.GetTempFileName();
            // WriteLine(Path.GetTempFileName());
            WriteLine(tempDatei);

            // datei löschen
            File.Delete(tempDatei);
            if(File.Exists(tempDatei))
            {
                WriteLine("Datei ist noch da");
            }
            else
            {
                WriteLine("Temporäre Datei ist gelöscht worden");
            }

            DriveInfo laufwerk = new DriveInfo("c");
            WriteLine(laufwerk.AvailableFreeSpace);
            WriteLine(laufwerk.DriveFormat);
            WriteLine(laufwerk.DriveType);
            WriteLine(laufwerk.IsReady);
            WriteLine(laufwerk.Name);
            WriteLine(laufwerk.RootDirectory);
            WriteLine(laufwerk.TotalFreeSpace);
            WriteLine(laufwerk.TotalSize);
            WriteLine(laufwerk.VolumeLabel);

            ReadLine();
        }
    }
}
