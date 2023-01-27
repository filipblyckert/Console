using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adressbok
{
    internal class AdressBook
    {
        private List<Contact> _contacts { get; set; } = new List<Contact>();
        private void DisplayContactDetails(Contact contact)
        {
            Console.WriteLine($"Contact:{contact.Name}, {contact.Number}, {contact.Email}, {contact.Adress}");
        }

        public void AddContact(Contact contact)
        {
            _contacts.Add(contact);
        }

        private void DisplayContactsDetails(List<Contact> contacts) 
        {
            foreach (var contact in contacts)
            {
                DisplayContactDetails(contact);
            }
        }
      

        public void DisplayAllContact()
        {
            DisplayContactsDetails(_contacts);
        }

        public void DisplayMatchingContacts(string searchPhrase)
        {
            var matchingContacts = _contacts.Where(c => c.Name.Contains(searchPhrase)).ToList();
            if (matchingContacts != null)
            {
                Console.WriteLine("Contact not found");
            }
            else
            {
               DisplayContactsDetails(matchingContacts);
            }
            
        }
    }   
}
