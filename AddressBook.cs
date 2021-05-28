using System;
using System.Collections.Generic;

namespace Try_Catch
{
    class AddressBook
    {
        public Dictionary<string, Contact> addressDictionary { get; set; }
        public AddressBook()
        {
            addressDictionary = new Dictionary<string, Contact>();
        }
        public void AddContact(Contact contact)
        {
            try
            {
                addressDictionary.Add(contact.Email, contact);
            }
            catch
            {
                Console.WriteLine($"{contact.FullName()} already exists as a contact");
            }
        }
        public Contact GetByEmail(string email)
        {
            addressDictionary.TryGetValue(email, out Contact Email);
            return Email;
        }
    }
}