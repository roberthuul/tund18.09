using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Person
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public ShoppingCart ShoppingCart { get; set; }

        public Person(string eesnimi, string perenimi)
        {
            FirstName = eesnimi;
            LastName = perenimi;
        }

        public override string ToString()
        {
            return FirstName + " " + LastName;
        }
    }
}
