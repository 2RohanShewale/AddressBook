using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookMain
{
    internal class AddressBooks
    {
        public Dictionary<string, AddressBook> books = new Dictionary<string, AddressBook>();
        public int NumberOfBooks { get; set; }

        public string AddBook()
        {
            WriteLine("//create a new book");
            WriteLine("Please Enter name of the book: "); string? name = ReadLine();
            if (books.ContainsKey(name)) 
            { WriteLine("Sorry this name is Already Taken."); return null; }
            else
            {
                books[name] = new AddressBook();
                WriteLine("New book has been created");
                return name;
            }

        }
        public void DisplayBooks()
        {
            foreach (var book in books.Keys) { Console.WriteLine(book); }
        }

        public AddressBook OpenBook(string name)
        {
            return books[name];
        }
        public string ChangeAddressBook()
        {
            WriteLine("***** Change Book ******\n available books");
            DisplayBooks();
            Write("Enter the name of the book: "); string name = ReadLine();
            return name;
        }

        public void ByStateOrCity()
        {
            WriteLine();
            Write("Enter name of the city of state: "); string state = ReadLine();
            List<Contact> contacts = new List<Contact>();
            foreach(var book in books.Values)
            {
                contacts.AddRange(book.ByStateOrCity(state));
            }
            foreach (var contact in contacts)
            {
                WriteLine($"{contact.State} {contact.City} {contact.FirstName} ");
            }
        }
    }
}
