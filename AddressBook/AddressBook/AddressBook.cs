using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class Details
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
    }
    public class AddressBook
    {

        List<string> addressBookName = new List<string>();
        Dictionary<string, List<Details>> dict = new Dictionary<string, List<Details>>();
        public void CreateAddressBook(string n)
        {
            addressBookName.Add(n);
            if (dict.Count == 0) 
            {
                dict.Add(n, new List<Details>());
            }
            else
            {
                if (dict.ContainsKey(n)) 
                {
                    Console.WriteLine("This AddressBook is present");
                }
                else
                {
                    dict.Add(n, new List<Details>());
                }
            }
        }
        public int temp = 0;
        public void DiplayListOfAddressBook()
        {
            if (addressBookName.Count == 0)
            {
                Console.WriteLine("\nThere is no address book avilable");
                temp = 1;
            }
            else
            {
                foreach (string list in addressBookName)
                {
                    Console.WriteLine("\n\nList of existing Address Book Are : ");
                    Console.WriteLine(list);
                    Console.WriteLine();
                }
            }
        }
        public void DisplayDictionary()
        {
            foreach (var content in dict.Keys)
            {
                Console.WriteLine("\n\nAddress Book : " + content);
                int i = 1;
                foreach (var value in dict[content].ToList())
                {
                    Console.WriteLine("\nRecord : " + i);
                    Console.WriteLine("First Name : " + value.FirstName);
                    Console.WriteLine("Last Name : " + value.LastName);
                    Console.WriteLine("Address : " + value.Address);
                    Console.WriteLine("City : " + value.City);
                    Console.WriteLine("State : " + value.State);
                    Console.WriteLine("Email : " + value.Email);
                    Console.WriteLine("ZipCode code : " + value.ZipCode);
                    Console.WriteLine("Phone Number : " + value.PhoneNumber);
                    i++;
                }
            }
        }
        public void AddRecords(string name)
        {
            Details input = new Details();

            Console.WriteLine("\nEnter your First Name : ");
            input.FirstName = Console.ReadLine();
            Console.WriteLine("Enter your Last Name : ");
            input.LastName = Console.ReadLine();
            Console.WriteLine("Enter your Address : ");
            input.Address = Console.ReadLine();
            Console.WriteLine("Enter your City Name : ");
            input.City = Console.ReadLine();
            Console.WriteLine("Enter your State Name : ");
            input.State = Console.ReadLine();
            Console.WriteLine("Enter your ZipCode Code : ");
            input.ZipCode = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter your Phone Number : ");
            input.PhoneNumber = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter your Email Address: ");
            input.Email = Console.ReadLine();
            foreach (var content in dict.Keys)
            {
                if (content == name)
                {
                    if (dict[content].Count == 0)
                    {
                        dict[name].Add(input);
                        Console.WriteLine("\nRecord Added successfully in Address Book");
                    }
                    else
                    {
                        foreach (var value in dict[content].ToList())
                        {
                            if (value != input)
                            {
                                dict[name].Add(input);
                                Console.WriteLine("\nRecord Added successfully in Address Book");
                            }
                            else
                            {
                                Console.WriteLine("\nThis Record is already present in Address Book");
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Address Book Not Found");
                }
            }
        }

        string fn, ln;
        public void UpdateRecords(string ab)
        {
            foreach (var content in dict.Keys)
            {
                if (content == ab)
                {
                    Console.WriteLine("\nEnter your First Name : ");
                    fn = Console.ReadLine();
                    Console.WriteLine("Enter your Last Name : ");
                    ln = Console.ReadLine();
                    foreach (var value in dict[content].ToList())
                    {
                        if (value.FirstName == fn && value.LastName == ln)
                        {
                            Console.WriteLine("\n\nWhich field you want to update : ");
                            Console.WriteLine("\n1:First Name\n2.Last Name\n3.Address\n4.City\n5.State\n6.Email\n7.ZipCode Code\n8.PhoneNumber");
                            Console.WriteLine("\nEnter your Choice : ");
                            int choice = Convert.ToInt32(Console.ReadLine());
                            switch (choice)
                            {
                                case 1:
                                    Console.WriteLine("\nEnter new first name : ");
                                    string f = Console.ReadLine();
                                    value.FirstName = f;
                                    Console.WriteLine("\nFirst Name Updated Successfully");
                                    break;
                                case 2:
                                    Console.WriteLine("\nEnter new last name : ");
                                    string l = Console.ReadLine();
                                    value.LastName = l;
                                    Console.WriteLine("\nLast Name Updated Successfully");
                                    break;
                                case 3:
                                    Console.WriteLine("\nEnter new Address : ");
                                    string a = Console.ReadLine();
                                    value.Address = a;
                                    Console.WriteLine("\nAddress Updated Successfully");
                                    break;
                                case 4:
                                    Console.WriteLine("\nEnter new City name : ");
                                    string c = Console.ReadLine();
                                    value.City = c;
                                    Console.WriteLine("\nCity Name Updated Successfully");
                                    break;
                                case 5:
                                    Console.WriteLine("\nEnter new State : ");
                                    string s = Console.ReadLine();
                                    value.State = s;
                                    Console.WriteLine("\nState Name Updated Successfully");
                                    break;
                                case 6:
                                    Console.WriteLine("\nEnter new Email : ");
                                    string e = Console.ReadLine();
                                    value.Email = e;
                                    Console.WriteLine("\nEmail Updated Successfully");
                                    break;
                                case 7:
                                    Console.WriteLine("\nEnter new ZipCode Code : ");
                                    string z = Convert.ToString(Console.ReadLine());
                                    value.ZipCode = z;
                                    Console.WriteLine("\nZip Code Updated Successfully");
                                    break;
                                case 8:
                                    Console.WriteLine("\nEnter new Phone Number : ");
                                    string p = Convert.ToString(Console.ReadLine());
                                    value.PhoneNumber = p;
                                    Console.WriteLine("\nPhone Number Updated Successfully");
                                    break;
                                default:
                                    Console.WriteLine("\nEnter valid choice");
                                    break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Record not found");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Address book not found");
                }
            }
        }
        public void DeleteRecord(string ab)
        {
            foreach (var content in dict.Keys)
            {
                if (content == ab)
                {
                    Console.WriteLine("\nEnter your First Name : ");
                    fn = Console.ReadLine();
                    Console.WriteLine("Enter your Last Name : ");
                    ln = Console.ReadLine();
                    foreach (var value in dict[content].ToList())
                    {
                        if (value.FirstName == fn && value.LastName == ln)
                        {
                            dict[content].Remove(value);
                            Console.WriteLine("\nRecord Deleted Successfully");
                        }
                        else
                        {
                            Console.WriteLine("Record not found");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Address book not found");
                }
            }
        }
    }
}