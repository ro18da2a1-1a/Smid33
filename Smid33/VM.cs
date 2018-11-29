using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Smid33.Annotations;

namespace Smid33
{
    class VM:INotifyPropertyChanged
    {
        private string _bareTxt;
        private Person _pers;

        public RC KnapFunktion { get; set; }

        public String BareTxt
        {
            get { return _bareTxt; }
            set
            {
                _bareTxt = value; 
                OnPropertyChanged();
            }
        }

        public Person SelectedPerson
        {
            get { return _pers; }
            set
            {
                _pers = value; 
                OnPropertyChanged();
            }
        }

        public ObservableCollection<Person> Personer { get; set; }

        public VM()
        {
            Personer = new ObservableCollection<Person>()
            {
                new Person(){Navn = "Peter", Adresse = "Sorø"},
                new Person(){Navn = "Poul", Adresse = "Hillerød"},
                new Person(){Navn = "Lars", Adresse = "Roskilde"}
            };

            KnapFunktion = new RC((s)=> BareTxt = "Peter" + s);
        }


        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
