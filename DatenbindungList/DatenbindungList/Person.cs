using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datenbindung01
{
    class Person : INotifyPropertyChanged
    {
        private string _name;
        public string name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged(new PropertyChangedEventArgs("Name"));
            }
        }
        private int? _alter;
        public int? alter
        {
            get { return _alter; }
            set
            {
                _alter = value;
                OnPropertyChanged(new PropertyChangedEventArgs("Alter"));
            }
        }
        private string _adresse;
        public string adresse
        {
            get { return _adresse; }
            set
            {
                _adresse = value;
                OnPropertyChanged(new PropertyChangedEventArgs("Adresse"));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, e);
            }
        }
    }
}