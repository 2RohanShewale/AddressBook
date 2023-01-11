using System.Collections.Specialized;
using static System.Console;

namespace AddressBookMain
{
   
        internal class AddressBook
    {
        public string Name { get; set; }
        public List<Contact> contacts = new List<Contact>();
        public int NumberOfContacts { get; set; }


        public void CreateContact()
        {
            WriteLine("---Add New Contact---");
            Write("First Name: "); string? FName = ReadLine();
            Write("Last Name: "); string? LName = ReadLine();
            Write("Address: "); string? address = ReadLine();
            Write("City: "); string? city = ReadLine();
            Write("State: "); string? state = ReadLine();
            Write("Country: "); string? country = ReadLine();
            Write("Zip Code: "); int code = Convert.ToInt32(ReadLine());
            Write("Phone Number: "); uint number = Convert.ToUInt32(ReadLine());
            Write("Email: "); string? email = ReadLine();
            Contact contact = new Contact(FirstName: FName, LastName: LName, Address: address, City: city, State: state, Country: country, ZipCode: code, PhoneNumber: number, Email: email);
            AddContact(contact);
        }

        public void AddContact(Contact contact) 
        {
            bool isDuplicate = false;
            foreach (var name in contacts)
            {
                isDuplicate = name.Equals(contact);
                WriteLine(isDuplicate);
                if (isDuplicate) { break; }
            }
            if(!isDuplicate) 
            {
                contacts.Add(contact);
                NumberOfContacts++;
            }
            else 
            { 
                ForegroundColor= ConsoleColor.Red;
                WriteLine("Contact with similar first name and last name already exists"); 
                ResetColor();
            }
            
            ContactDisplay();
        }
        public void ContactDisplay()
        {
            foreach (var contact in contacts)
            {
                WriteLine();
                ForegroundColor = ConsoleColor.Blue;
                contact.Display();
                ResetColor();
                WriteLine("*--------------------*");
            }
        }

        public void EditContact()
        {
            WriteLine();
            WriteLine("*---Edit Contact---*");
            Write("Enter a first name of the contact: "); string? FName = ReadLine();
            foreach (var contact in contacts)
            {
                if (contact.FirstName == FName)
                {
                    contact.Edit();
                }
            }
        }
        public void DeleteContact()
        {
            WriteLine();
            WriteLine("*---Delete Contact---*");
            Write("Enter first name of contact: "); string? FName = ReadLine();
            Write("Enter Last Name: "); string? LName = ReadLine();
            foreach (Contact contact in contacts)

            {
                if (contact.FirstName == FName && contact.LastName == LName)
                {
                    contacts.Remove(contact);
                    WriteLine("Contact Removed");
                    NumberOfContacts--;
                    break;
                }
                else
                {
                    WriteLine("Name does not Exists");
                }

            }

        }
        public List<Contact> ByStateOrCity(string state)
        {
            List<Contact> result = new List<Contact>();
            contacts.ForEach(c => { if (c.City == state || c.State == state) { result.Add(c); } });
            //foreach (var contact in contacts)
            //{
            //    if (contact.City == state || contact.State == state)
            //    {
            //       result.Add(contact);
            //    }
            //}
            return result;
        }

    }

}

