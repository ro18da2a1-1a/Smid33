using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smid33
{
    class Person
    {
        public String Navn { get; set; }
        public String  Adresse { get; set; }

        public override string ToString()
        {
            return $"{nameof(Navn)}: {Navn}, {nameof(Adresse)}: {Adresse}";
        }
    }
}
