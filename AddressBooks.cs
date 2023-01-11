using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using System.Threading.Tasks.Dataflow;

namespace AddressBookMain
{
    internal class AddressBooks
    {
        public Dictionary<string, AddressBook> books = new Dictionary<string, AddressBook>();
        public List<Contact> AllContacts = new List<Contact>();
        public Dictionary<string, List<Contact>> ByState = new Dictionary<string, List<Contact>>();
        public Dictionary<string, List<Contact>> ByCity = new Dictionary<string, List<Contact>>();
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

        public void GetAllTheContacts()
        {
            foreach(AddressBook Book in books.Values)
            {
                foreach (Contact contact in Book.contacts)
                {
                    AllContacts.Add(contact);
                }
            }
        }

        private void AddToDictionary()
        {
            GetAllTheContacts();
            foreach(Contact x in AllContacts)
            {
                if (ByState.ContainsKey(x.State))
                {
                    ByState[x.State].Add(x);
                }
                else
                {
                    List<Contact> list = new List<Contact>();
                    list.Add(x);
                    ByState.Add(x.State, list);
                }
                if (ByCity.ContainsKey(x.City))
                {
                    ByCity[x.City].Add(x);
                }else
                {
                    List<Contact> list = new List<Contact>(); list.Add(x);
                    ByCity.Add(x.City, list);
                }
            }
        }

        public void DislplayDictionary()
        {
            WriteLine("Display contacts by City or State: ");
            Write("1. By State 2.By City"); int a = Convert.ToInt32(ReadLine());
            if (a == 1)
            {
                DisplayState();
            }
            else if(a ==2)
            {
                DisplayCity();
            }
        }
        
        public void DisplayState()
        {
            foreach(KeyValuePair<string,List<Contact>> contacts in ByState)
            {
                ForegroundColor = ConsoleColor.Magenta;
                WriteLine(ByState.Keys);
                ResetColor();
                contacts.Value.ForEach(contacts => { WriteLine(contacts.FirstName); });
                WriteLine();
            }
        }
        public void DisplayCity()
        {
            foreach (KeyValuePair<string, List<Contact>> contacts in ByCity)
            {
                ForegroundColor = ConsoleColor.Cyan;
                WriteLine(ByCity.Keys);
                ResetColor();
                contacts.Value.ForEach(contacts => { WriteLine(contacts.FirstName); });
                WriteLine();
            }
        }

    }
}
