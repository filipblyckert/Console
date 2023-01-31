using adressbok;

Console.WriteLine("Name and Adress Book");
Console.WriteLine("Choose an option");
Console.WriteLine("1 Add contact");
Console.WriteLine("2 View all contacts");
Console.WriteLine("3 Search contacts by name");
Console.WriteLine("4 Remove contact");
Console.WriteLine("Press'x' to exit");



var userInput = Console.ReadLine();

var AdressBook = new AdressBook();

while (true)
{
    switch (userInput)
    {
        case "1":
            Console.WriteLine("Contact name");
            var name = Console.ReadLine();
            Console.WriteLine("Contact number");
            var number = Console.ReadLine();
            Console.WriteLine("Contact email");
            var email = Console.ReadLine();
            Console.WriteLine("Contact adress");
            var adress = Console.ReadLine();

            var newContact = new Contact(name, number, email, adress);
            AdressBook.AddContact(newContact);

            break;

        case "2":
            AdressBook.DisplayAllContact();
            break;
        case "3":
            Console.WriteLine("Enter name of existing contact");
            var searchPhrase = Console.ReadLine();
            AdressBook.DisplayMatchingContacts(searchPhrase);
            break;
        case "4":
            Console.WriteLine("Remove Contact");
             var contact = Console.ReadLine();
            AdressBook.RemoveContactByName(contact);
            break;
        case "x":
            return;
        default:
            Console.WriteLine("Select a valid operation");
            break;

    }
    Console.WriteLine("Choose an option");
    userInput = Console.ReadLine();
}
