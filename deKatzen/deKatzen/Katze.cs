using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Miau
{
    public class Katze
    {
        /* private int _katzenID;
        private int _baujahr;
        private double _futterStand;
        private int _schlafLeistung;

        public int katzenID { get { return _katzenID; } set { _katzenID = value; } }
        public int baujahr { get { return _baujahr; } set { _baujahr = value; } }
        public double futterStand { get { return _futterStand; } set { _futterStand = value; } }
        public int schlafLeistung { get { return _schlafLeistung; } set { _schlafLeistung = value; } } */

        public int baujahr { get; set; }
        public int futterStand { get; set; }
        public int schlafLeistung { get; set; }

        public Katze() { }

        public string fahrgestellnummer { get; set; }
        public string kennzeichen { get; set; }
    }
}
