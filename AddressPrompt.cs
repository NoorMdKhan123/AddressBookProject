using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookProject
{
    class AddressPrompt
    {
        AddressBook book;

        public AddressPrompt()
        {
            book = new AddressBook();
        }

        static void Main(string[] args)
        {
            string selection = "";
            AddressPrompt prompt = new AddressPrompt();

            prompt.displayMenu();
            while (!selection.ToUpper().Equals("Q"))
            {
                Console.WriteLine("Selection: ");
                selection = Console.ReadLine();
                prompt.performAction(selection);
            }
        }

        void displayMenu()
        {
            Console.WriteLine("Main Menu");
            Console.WriteLine("=========");
            Console.WriteLine("A - Add an Address");
            Console.WriteLine("D - Delete an Address");
            Console.WriteLine("E - Edit an Address");
            Console.WriteLine("L - List All Addresses");
            Console.WriteLine("Q - Quit");
        }

        void performAction(string selection)
        {
            string firstName = "";
            string lastName = "";
            string address = "";
            string city = "";
            string state = "";
            string zip = "";
            string phone = "";
            string email = "";

            switch (selection.ToUpper())
            {
                case "A":
                    Console.WriteLine("Enter First Name: ");
                    firstName = Console.ReadLine();
                    Console.WriteLine("Enter Last Name: ");
                    lastName = Console.ReadLine();
                    Console.WriteLine("Enter Address: ");
                    address = Console.ReadLine();
                    Console.WriteLine("Enter City: ");
                    city = Console.ReadLine();
                    Console.WriteLine("Enter State : ");
                    state = Console.ReadLine();
                    Console.WriteLine("Enter zip: ");
                    zip = Console.ReadLine();
                    Console.WriteLine("Enter phone: ");
                    phone = Console.ReadLine();
                    Console.WriteLine("Enter Email : ");
                    email = Console.ReadLine();
                    if (book.add(firstName, lastName, address,
                        city, state, zip, phone, email))
                    {
                        Console.WriteLine("Address successfully added!");
                    }
                    else
                    {
                        Console.WriteLine("An address is already on file for {0}.", firstName);
                    }
                    break;
                case "D":
                    Console.WriteLine("Enter Name to Delete: ");
                    firstName = Console.ReadLine();
                    if (book.remove(firstName))
                    {
                        Console.WriteLine("Address successfully removed");
                    }
                    else
                    {
                        Console.WriteLine("Address for {0} could not be found.", firstName);
                    }
                    break;
                case "L":
                    if (book.isEmpty())
                    {
                        Console.WriteLine("There are no entries.");
                    }
                    else
                    {
                        Console.WriteLine("Addresses:");
                        book.list((a) => Console.WriteLine("{0} - {7}", a.firstname, a.lastname,
                             a.address, a.city, a.state, a.zip, a.phone, a.email));
                    }
                    break;
                case "E":
                    Console.WriteLine("Enter Name to Edit: ");
                    firstName = Console.ReadLine();
                    Address addr = book.find(firstName);
                    if (addr == null)
                    {
                        Console.WriteLine("Address for {0} count not be found.", firstName);
                    }
                    else
                    {
                        Console.WriteLine("Enter new Address: ");
                        addr.address = Console.ReadLine();
                        Console.WriteLine("Address updated for {0}", firstName);
                    }
                    break;
            }

        }
    }
}
