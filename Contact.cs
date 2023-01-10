using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookMain
{
    internal class Contact
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? Country { get; set; }
        public int ZipCode { get; set; }
        public uint PhoneNumber { get; set; }
        public string? Email { get; set; }

        public Contact(string? FirstName, string? LastName, string? Address, string? City, string? State, string? Country, int ZipCode, uint PhoneNumber, string? Email) 
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Address = Address;
            this.City = City;
            this.State = State;
            this.Country = Country;
            this.ZipCode = ZipCode;
            this.PhoneNumber = PhoneNumber;
            this.Email = Email;
        }

        public void Edit()
        {
            WriteLine("Current info of contact: ");
            ForegroundColor = ConsoleColor.Gray;
            Display();
            ResetColor();
            WriteLine();
            WriteLine("1.First Name 2.Last Name 3.Address 4.City 5.State \n6.Country 7.Zip Code 8.Phone Number 9.Email 10.Cancel\n Enter number : ");
            int num = Convert.ToInt32(ReadLine());
            
            ForegroundColor = ConsoleColor.Green;
            switch (num)
            {
                case 1: Write("First Name: "); FirstName= ReadLine(); break;
                case 2: Write("Last Name: "); LastName= ReadLine(); break;
                case 3: Write("Address: "); Address= ReadLine(); break;
                case 4: Write("City"); City= ReadLine(); break;
                case 5: Write("State: "); State= ReadLine(); break;
                case 6: Write("Country: "); Country= ReadLine(); break;
                case 7: Write("Zip Code: "); ZipCode= Convert.ToInt32(ReadLine()); break;
                case 8: Write("Phone Number: "); PhoneNumber = Convert.ToUInt32(ReadLine()); break;
                case 9: Write("Email: "); Email = ReadLine(); break;
                case 10: WriteLine("Nothing Changed."); break;
                default:
                    break;
            }
            ResetColor();

        }

        public void Display()
        {
            WriteLine("Name: " + this.FirstName + " " + this.LastName);
            WriteLine("Address: " + this.Address + " " + this.City + " " + this.State + " " + this.Country + " " + this.ZipCode);
            WriteLine("Phone Number: " + this.PhoneNumber);
            WriteLine("Email: " + this.Email);
        }

        public override bool Equals(Object? obj)
        {
            if (obj is Contact) 
            { 
                Contact ob = (Contact)obj;
                if (this.FirstName == ob.FirstName && this.LastName == ob.LastName)
                {
                    return true;
                }
                return false;
            }
            return true;
            
        }
    }
}
