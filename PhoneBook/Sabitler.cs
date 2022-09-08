using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    internal class Sabitler
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Number { get; set; }

        public Sabitler(string Name, string Surname, string Number)
        {
           this.Name = Name;
           this.Surname = Surname;
           this.Number = Number;
        }
        public Sabitler()
        {

        }
    }
}

