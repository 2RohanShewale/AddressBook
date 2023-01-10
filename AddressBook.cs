using System;
using static System.Console;

namespace AddressBookMain
{
    internal class AddressBook
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? address { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? Country { get; set; }
        public int ZipCode { get; set; }
        public int PhoneNumber { get; set; }
        public string? Email { get; set; }

        public void Display()
        {
            WriteLine("Name: " + this.FirstName + " " + this.LastName);
            WriteLine("Address: " + this.address + " " + this.City + " " + this.City + " " + this.Country + " " + this.ZipCode);
            WriteLine("Phone Number: " + this.PhoneNumber);
            WriteLine("Email: " + this.Email);
            WriteLine("*--------------------*");
        }
    }

}
