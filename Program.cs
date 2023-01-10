namespace AddressBookMain
{
	class Program
	{
		static void Main()
		{
			Console.WriteLine("#------Welcome to Address Book Program------#");
			AddressBook contact = new AddressBook() {
				FirstName= "Rohan",
				LastName = "Shewale",
				address = "Room: 237, 13th floor",
				City = "Mumbai",
				State = "Maharastra",
				Country = "India",
				ZipCode = 400215,
				PhoneNumber = 98695421,
				Email = "rohan@gmail.com"	
			};
			contact.Display();
			
		}
	}
}