using System;
					
namespace PhoneBookConsole
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("PhoneBook Console:");
			Console.WriteLine("Please select operation");
			Console.WriteLine("1. Add Contact");
			Console.WriteLine("2. Display contact by number");
			Console.WriteLine("3. View all contacts");
			Console.WriteLine("4. Search contacts for a given name");
			Console.WriteLine("5. Exit");
			
			var userInput = Console.ReadLine();
			
			var phoneBook = new PhoneBook();
			
			while(true)
			{
				switch(userInput)
				{
					case "1": 
						Console.WriteLine("Please enter the contact name");
						var name = Console.ReadLine();
						Console.WriteLine("Please enter the contact number");
						var number = Console.ReadLine();
						var newContact = new Contact(name, number);
						phoneBook.AddContact(newContact);
						break;
					case "2": 
						Console.WriteLine("Please enter the contact number");
						var searchNumber = Console.ReadLine();
						phoneBook.DisplayContact(searchNumber);
						break;
					case "3": 
						phoneBook.DisplayAllContact();
						break;
					case "4": 
						Console.WriteLine("Please enter the contact name to search");
						var searchName = Console.ReadLine();
						phoneBook.DisplayMatchingContacts(searchName);
						break;
					case "5": 
						return;
					default: 
						Console.WriteLine("Please select a valid operation");
						break;
				}
				Console.WriteLine("Please select operation");
				userInput = Console.ReadLine();
			}
			
				
		}
	}
}
