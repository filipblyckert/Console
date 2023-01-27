using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adressbok
{
    internal class Contact
    {
       public Contact(string name, string number, string email, string adress) 
        {
            Name = name;
            Number = number;
            Email = email;
            Adress = adress;
        }

        public string Number { get; internal set; }
        public string Name { get; internal set; }
        public string Adress { get; internal set; }
        public string Email { get; internal set; }
    }
}
