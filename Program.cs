using AddressBookMain;
using static System.Console;
namespace AddressBookMain
{
	class Program
	{
		static void Main()
		{
			Console.WriteLine("#------Welcome to Address Book Program------#");
			AddressBooks addressBooks = new AddressBooks();

			//create new book
			string name = addressBooks.AddBook();
			if (name != null )
			{
                bool exit = false;
                while (!exit)
                {
                    AddressBook book = addressBooks.OpenBook(name);
                    WriteLine();
                    WriteLine("This is Address Book: " + $" {name} ");
                    WriteLine("1.Create Contact\n2.Edit Contact\n3.Delete Contact\n4.Display Contacts\n5.Change Address Book\n6.Create new Address Book\n7.Exit");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1: book.CreateContact(); break;
                        case 2:
                            if (book.NumberOfContacts > 0)
                            { book.EditContact(); }
                            else { WriteLine("Add atlest one Contact in book"); }
                            break;
                        case 3:
                            if (book.NumberOfContacts > 0) { book.DeleteContact(); }
                            else { WriteLine("There are no contacts in book"); }
                            break;
                        case 4:
                            if (book.NumberOfContacts > 0) { book.ContactDisplay(); }
                            else { WriteLine("There are no contacts in address book"); }
                            break;
                        case 5: name = addressBooks.ChangeAddressBook(); break;
                        case 6: name = addressBooks.AddBook();break;
                        case 7: exit = true; break;
                        default:
                            break;
                    }
                    WriteLine("#########################");
                }
            }

		}
	}
}