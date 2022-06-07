

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace AddressBook
{
    public class Program
    {
        static void Main(string[] args)
        {
            AddressBook records = new AddressBook();
            string ab;
        Again:
            while (true)
            {
                Console.WriteLine("\n\nWelcome to Address Book System");
                Console.WriteLine("1. Add a new Record");
                Console.WriteLine("2. Update a Record");
                Console.WriteLine("3. Delete a Record");
                Console.WriteLine("4. Display all persons by City name");
                Console.WriteLine("5. Display all persons by State name");
                Console.WriteLine("6. Exit");
                Console.WriteLine("\nEnter your choice : ");

                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        string n;
                        Console.WriteLine("\nEnter name of address book which you want to create : ");
                        n = Console.ReadLine();
                        records.CreateAddressBook(n);
                        records.AddRecords(n);
                        records.DisplayDictionary();
                        break;
                    case 2:
                        records.DiplayListOfAddressBook();
                        if (records.temp == 1)
                        {
                            Console.WriteLine("\nPlease Add Address Book First by entering choice 1");
                            goto Again;
                        }
                        else
                        {
                            Console.WriteLine("\nSelect any one address book from above list : ");
                            ab = Console.ReadLine();
                            records.UpdateRecords(ab);
                            records.DisplayDictionary();
                        }
                        break;
                    case 3:
                        records.DiplayListOfAddressBook();
                        if (records.temp == 1)
                        {
                            Console.WriteLine("\nPlease Add Address Book First by entering choice 1");
                            goto Again;
                        }
                        else
                        {
                            Console.WriteLine("\nSelect any one address book from above list : ");
                            ab = Console.ReadLine();
                            records.DeleteRecord(ab);
                            records.DisplayDictionary();
                        }
                        break;
                    case 4:
                        Console.WriteLine("Enter any city name : ");
                        string city = Console.ReadLine();
                        records.DisplayPersonsByCityName(city);
                        break;
                    case 5:
                        Console.WriteLine("Enter any state name : ");
                        string state = Console.ReadLine();
                        records.DisplayPersonsByCityName(state);
                        break;
                    case 6:
                        System.Environment.Exit(0);
                        break;
                }
                goto Again;
            }
        }
    }
}