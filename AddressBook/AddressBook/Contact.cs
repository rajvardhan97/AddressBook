using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class Details
    {
        public string Firstname { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
    }
    class Contact
    {
        public List<Details> Address_Book = new List<Details>();
        Details person = new Details();

        public void AddContact()
        {
                Console.WriteLine(" Enter your First name : ");
                person.Firstname = Console.ReadLine();
                Console.WriteLine(" Enter your Last name : ");
                person.LastName = Console.ReadLine();
                Console.WriteLine(" Enter your Address : ");
                person.Address = Console.ReadLine();
                Console.WriteLine(" Enter your City : ");
                person.City = Console.ReadLine();
                Console.WriteLine(" Enter your State : ");
                person.State = Console.ReadLine();
                Console.WriteLine(" Enter your Zip code : ");
                person.ZipCode = Console.ReadLine();
                Console.WriteLine(" Enter your Phone Number : ");
                person.PhoneNumber = Console.ReadLine();
                Console.WriteLine(" Enter your Email ID : ");
                person.Email = Console.ReadLine();

                Address_Book.Add(person);
                Console.WriteLine("\n {0}'s contact succesfully added", person.Firstname);
        }
    }
}
