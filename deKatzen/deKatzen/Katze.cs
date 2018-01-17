using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace DeKatzen
{
    internal class Katze
    {
        private int _katzenID;
        private int _baujahr;
        private double _futterStand;
        private int _schlafLeistung;

        public int katzenID { get { return _katzenID; } set { _katzenID = value; } }
        public int baujahr { get { return _baujahr; } set { _baujahr = value; } }
        public double futterStand { get { return _futterStand; } set { _futterStand = value; } }
        public int schlafLeistung { get { return _schlafLeistung; } set { _schlafLeistung = value; } }

        public Katze() { }

        public Katze(int katzenID, int baujahr, double futterStand, int schlafLeistung )
        {
            WriteLine("Katze mit der ID {0}\tdem Jahr{1}\tFutterStand {2} und \tSchlafleistung {3}", 
                        katzenID, baujahr, futterStand, schlafLeistung);
        }
    }
}
