namespace AddressBookMain
{
	class Program
	{
		static void Main()
		{
			Console.WriteLine("#------Welcome to Address Book Program------#");
			AddressBook book1 = new AddressBook();
			bool addContact = true;
			while (addContact)
			{
                book1.CreateContact();
				Console.Write("Do you want to add more contact?(Y/N) :");
				string? s = Console.ReadLine();
				if (s == "N" || s == "n") { addContact = false; }
            }	
		}
	}
}