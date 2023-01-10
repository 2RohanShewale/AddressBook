using AddressBook;
using System;
using static System.Console;

namespace AddressBookMain
{
    internal class AddressBook
    {
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
            Contact contact= new Contact(FirstName: FName, LastName: LName, Address: address, City: city, State: state, Country: country, ZipCode: code, PhoneNumber: number, Email: email);
            contacts.Add(contact);
            NumberOfContacts++;
            ContactDisplay();
        }
        public void ContactDisplay()
        {
            foreach (var contact in contacts)
            {
                WriteLine();
                ForegroundColor= ConsoleColor.Red;
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
    }

}
