using static System.Console;
namespace AddressBookMain
{
	class Program
	{
		static void Main()
		{
			Console.WriteLine("#------Welcome to Address Book Program------#");
			AddressBook book1 = new AddressBook();
			bool exit = false;
			while (!exit)
			{
				WriteLine();
				WriteLine("1.Create Contact\n2.Edit Contact\n3.Delete Contact\n4.Display Contacts\n5.Exit");
				int choice = Convert.ToInt32(Console.ReadLine());
				switch (choice)
				{
					case 1: book1.CreateContact();break;
					case 2: if (book1.NumberOfContacts > 0) { book1.EditContact(); } else { WriteLine("Add atlest one Contact in book");} break;
					case 3: if (book1.NumberOfContacts > 0) { book1.DeleteContact(); } else { WriteLine("There are no contacts in book"); } break;
					case 4: if (book1.NumberOfContacts > 0) { book1.ContactDisplay(); } else { WriteLine("There are no contacts in address book"); } break;
					case 5: exit = true; break;
					default:
						break;
				}
				WriteLine("#########################");
			}	
		}
	}
}