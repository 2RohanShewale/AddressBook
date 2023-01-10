using AddressBook;
using System;
using static System.Console;

namespace AddressBookMain
{
    internal class AddressBook
    {
        public List<Contact> Contacts = new List<Contact>();
        

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
            Write("Phone Number: "); int number = Convert.ToInt32(ReadLine());
            Write("Email: "); string? email = ReadLine();
            Contact contact= new Contact(FirstName: FName, LastName: LName, Address: address, City: city, State: state, Country: country, ZipCode: code, PhoneNumber: number, Email: email);
            Contacts.Add(contact);
            Display();
        }
        public void Display()
        {
            foreach (var contact in Contacts)
            {
                WriteLine();
                WriteLine("Name: " + contact.FirstName + " " + contact.LastName);
                WriteLine("Address: " + contact.Address + " " + contact.City + " " + contact.City + " " + contact.Country + " " + contact.ZipCode);
                WriteLine("Phone Number: " + contact.PhoneNumber);
                WriteLine("Email: " + contact.Email);
                WriteLine("*--------------------*");
            }
        }
    }

}
