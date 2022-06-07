

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

        public static IDictionary<string, List<AddressBook>> numberNames = new Dictionary<string, List<AddressBook>>();
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

                AddressBook addressBookSystem = new AddressBook();
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
                    int pincode = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter PhoneNumber ");
                    long phone = Convert.ToInt64(Console.ReadLine());

                    Console.WriteLine("Enter Email");
                    string email = Console.ReadLine();

                    addressBookSystem.CreateContact(firstname, lastname, address, city, state, pincode, phone, email);
                    contacts--;
                }
                Console.WriteLine("Do you want to Modify?(Y/N)");
                char ch = Convert.ToChar(Console.ReadLine());
                if (ch == 'Y')
                {

                    addressBookSystem.Modify();
                }

                numberNames.Add(addrBookName, addressBookSystem.ContactArray);
                num--; ;
            }
            AddressBook.Search();
        }
    }
}