using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Aufruf
{
    // Call-by-Value und Call-by-Reference

    class Program
    {
        static void Main(string[] args)
        {
            int zahl = 3;
            int zahl1;
            //  macheIrgendwas(zahl);   // hier wird die Zahl (3) übergeben - Call-by-Value
            macheIrgendwas(ref zahl, out zahl1); // hier wird die Referenz (500) übergeben - Call-by-Reference
            WriteLine("Zahl = " + zahl);
            WriteLine("Zahl1 = " + zahl1);
            ReadLine();

            Demo1 obj = new Demo1();
            Demo2 obj2 = new Demo2();
            obj2.aendereWert(obj);
            WriteLine(obj.wert);
            ReadLine();

            // unsafe geht nur, wenn man oben in der Projektmappe aufrauf -> rechtsklick -> einstellungen -> build -> unsicher zulassen
            unsafe
            {
                int* p = &zahl;
                WriteLine("p = {0:X}", *p);
                WriteLine((int)p);  // der speicherpunkt
            }
            ReadLine();
        }

        static void macheIrgendwas(ref int zahl, out int zahl1)    // ohne ref: Zahl (3) wird übergeben
        {
            zahl = 500;
            zahl1 = zahl + 500;

        }

        /*    static int macheIrgendwas2(ref int wert)    
            {
                wert = 500;
                return 0;
            } */

        /*   static List<int> macheIrgendwas3(ref int wert)  
           {
               List<int> liste = new List<int>();
               wert = 500;
               return liste;
           } */


        class Demo1
        {
            public int wert = 500;
        }

        class Demo2
        {
            public void aendereWert(Demo1 obj)
            {
                obj.wert = 4711;
            }
        }

    }
}


// CbV: Inhalt wird übergeben
// CbR: Speicheradresse wird übergeben
//http://www.lerneprogrammieren.com/blog/praxis/call-value-und-call-reference-bei-der-parameteruebergabe