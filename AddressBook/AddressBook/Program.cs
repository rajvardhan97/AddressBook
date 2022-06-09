using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace AddressBook
{
    class Program
    {

        public static Dictionary<string, List<AddressBook>> numberNames = new Dictionary<string, List<AddressBook>>();
        public static Dictionary<string, List<AddressBook>> City = new Dictionary<string, List<AddressBook>>();
        public static Dictionary<string, List<AddressBook>> State = new Dictionary<string, List<AddressBook>>();

        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of AddressBook to create");
            int num = Convert.ToInt32(Console.ReadLine());

            while (0 < num)
            {
                Console.WriteLine("Enter name of addressBook");
                string addrBookName = Console.ReadLine();

                AddressBook addressBook = new AddressBook();
                Console.WriteLine("Enter number of Contacts to Add");
                int contacts = Convert.ToInt32(Console.ReadLine());

                while (contacts > 0)
                {
                    Console.WriteLine("\nEnter Firstname ");
                    string firstname = Console.ReadLine();
                    Console.WriteLine("Enter Lastname ");
                    string lastname = Console.ReadLine();

                    Console.WriteLine("Enter Address");
                    string address = Console.ReadLine();

                    Console.WriteLine("Enter City");
                    string city = Console.ReadLine();

                    Console.WriteLine("Enter State");
                    string state = Console.ReadLine();

                    Console.WriteLine("Enter pincode");
                    string pincode = Console.ReadLine();

                    Console.WriteLine("Enter PhoneNumber ");
                    string phone = Console.ReadLine();

                    Console.WriteLine("Enter Email");
                    string email = Console.ReadLine();

                    addressBook.CreateContact(addrBookName, firstname, lastname, address, city, state, pincode, phone, email);
                    contacts--;
                }
                Console.WriteLine("Do you want to Modify?(Y/N)");
                char ch = Convert.ToChar(Console.ReadLine());
                if (ch == 'Y')
                {

                    addressBook.Modify();
                }

                numberNames.Add(addrBookName, addressBook.ContactArray);
                foreach (KeyValuePair<string, List<AddressBook>> kvp in numberNames)
                {             
                    Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value + "\n");
                }
                num--;

            }

            Search();
        }
        public void Display(List<AddressBook> ContactArray, int N)
        {
            Console.WriteLine("Address Book:");
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("First name: {0}\n Last name: {1}\n Address: {2}\n City: {3}\n Zip: {4}\n State: {5}\n Phone Number: {6}\n Email: {7} \n", ContactArray[i].firstName, ContactArray[i].lastName, ContactArray[i].Address, ContactArray[i].city, ContactArray[i].zip, ContactArray[i].state, ContactArray[i].phoneNumber, ContactArray[i].email);

            }
        }
        public static void SortContactPerson()
        {

            Console.WriteLine("Enter 1-to Sort contact based on First Name");
            Console.WriteLine("Enter 2-to Sort Contact Based on State");
            Console.WriteLine("Enter 3-to Sort Contact based on City");
            Console.WriteLine("Enter 4-to Sort Contact based on zip");
            int option = Convert.ToInt32(Console.ReadLine());
            foreach (KeyValuePair<string, List<AddressBook>> kvp in numberNames)
            {
                Console.WriteLine("Displaying sorted Contact Person Details in address book: " + kvp.Key);
                
                List<AddressBook> listAddressBook = kvp.Value;
                ContactSort sort = new ContactSort();
                switch (option)
                {
                    case 1:
                        sort.compareByFields = ContactSort.sortBy.firstName;
                        listAddressBook.Sort(sort);
                        break;
                    case 2:
                        sort.compareByFields = ContactSort.sortBy.state;
                        listAddressBook.Sort(sort);
                        break;
                    case 3:
                        sort.compareByFields = ContactSort.sortBy.city;
                        listAddressBook.Sort(sort);
                        break;
                    case 4:
                        sort.compareByFields = ContactSort.sortBy.zip;
                        listAddressBook.Sort(sort);
                        break;
                }

                foreach (var emp in listAddressBook)
                {
                    Console.WriteLine(emp.ToString());
                }
            }
        }
        public static void Search()
        {
            Console.WriteLine("Enter 1-to Seach a person through a City");
            Console.WriteLine("Enter 2-to Seach a person through a State");
            Console.WriteLine("Enter 3-to view people  in City list or State list");
            Console.WriteLine("Enter 4-to Sort Contact people in Address Book");
            Console.WriteLine("Enter 5-To Write AddressBook in File");
            Console.WriteLine("Enter 6-To Read a File");
            Console.WriteLine("Enter 7-Perform Csv Operations");

            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    SearchAddress(option);
                    break;
                case 2:
                    SearchAddress(option);
                    break;
                case 3:
                    DisplayCityorState();
                    break;
                case 4:
                    SortContactPerson();
                    break;
                case 5:
                    FileOperations.GetDictionary(numberNames);
                    break;
                case 6:
                    FileOperations.ReadAddressBook();
                    break;
                case 7:
                    CSVOperations.CSVOperation(numberNames);
                    break;
                default:
                    Console.WriteLine("Invalid Option!");
                    break;
            }
        }
        public static void DisplayCityorState()
        {
            Console.WriteLine("Enter 1-to view City list\n Enter 2-to view State list");
            int citystate = Convert.ToInt32(Console.ReadLine());
            if (citystate == 1)
            {
                foreach (var i in City)
                {
                    Console.WriteLine("Display List for City: {0}\n", i.Key);
                    foreach (var j in i.Value)
                    {
                        Console.WriteLine("Found person {0} {1} , residing in City {2}", j.firstName, j.lastName, j.city);
                    }
                    Console.WriteLine("Count of people in City is: {0}", i.Value.Count);
                }
            }
            else
            {
                foreach (var i in State)
                {
                    Console.WriteLine("Display List for State: {0}\n", i.Key);
                    foreach (var j in i.Value)
                    {
                        Console.WriteLine("Found person {0} {1}, residing in State {2}", j.firstName, j.lastName, j.state);
                    }
                    Console.WriteLine("Count of people in State is: {0}", i.Value.Count);
                }
            }

        }
        public static void SearchAddress(int option)
        {
            string city = "", state = "";
            if (option == 1)
            {
                Console.WriteLine("Enter the City Name");
                city = Console.ReadLine();
            }
            if (option == 2)
            {
                Console.WriteLine("Enter the City Name");
                state = Console.ReadLine();
            }
            foreach (KeyValuePair<string, List<AddressBook>> kvp in numberNames)
            {
                if (option == 1)
                {
                    StoreCity(kvp.Key, kvp.Value, city);
                }
                if (option == 2)
                {
                    StoreState(kvp.Key, kvp.Value, state);
                }
            }
        }
        public static void StoreCity(string key, List<AddressBook> ContactArray, string city)
        {
            List<AddressBook> CityList = ContactArray.FindAll(x => x.city.Equals(city)).ToList();
            foreach (var i in CityList)
            {
                Console.WriteLine("Found person {0} in Address Book {1}, residing in City {2}", i.firstName, key, i.city);
            }
        }
        public static void StoreState(string key, List<AddressBook> ContactArray, string state)
        {
            List<AddressBook> StateList = ContactArray.FindAll(x => x.state.Equals(state)).ToList();
            foreach (var i in StateList)
            {
                Console.WriteLine("Found person {0} in Address Book {1}, residing in State {2}", i.firstName, key, i.state);
            }
        }

    }
}