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
        public void Edit()
        {
            Console.Write("\n Enter the first name to edit the details : ");
            string edit = Console.ReadLine();
            if (Address_Book.Count > 0)
            {
                foreach (Details persons in Address_Book)
                {
                    if (edit == persons.Firstname)
                    {
                        Console.WriteLine("\n Enter a number to edit detail" + "\n1.First Name " + "\n2.Last Name " +
                            "\n3.Address " + "\n4.City " + "\n5.State \n6.Zipcode \n7.Phone Number \n8.Email ID");
                        Console.Write(" Enter your option : ");
                        int option = Convert.ToInt32(Console.ReadLine());
                        switch (option)
                        {
                            case 1:
                                Console.Write("Enter the new First Name : ");
                                persons.Firstname = Console.ReadLine();
                                break;
                            case 2:
                                Console.WriteLine("Enter the new Last name");
                                persons.LastName = Console.ReadLine();
                                break;
                            case 3:
                                Console.Write(" Enter the New Address : ");
                                persons.Address = Console.ReadLine();
                                break;
                            case 4:
                                Console.Write(" Enter the New City : ");
                                persons.City = Console.ReadLine();
                                break;
                            case 5:
                                Console.Write(" Enter the New State : ");
                                persons.State = Console.ReadLine();
                                break;
                            case 6:
                                Console.Write("Enter the New Zip Code : ");
                                persons.ZipCode = Console.ReadLine();
                                break;
                            case 7:
                                Console.Write(" Enter the New Phone Number : ");
                                persons.PhoneNumber = Console.ReadLine();
                                break;
                            case 8:
                                Console.Write(" Enter the New EMail-ID : ");
                                persons.Email = Console.ReadLine();
                                break;
                            default:
                                Console.WriteLine(" Please enter a valid input");
                                Edit();
                                break;
                        }
                        Console.WriteLine(" {0} contact has been successfully added", edit);
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine(" The Address Book is empty");
            }
        }
        public void Delete()
        {
            Console.Write("\n Enter the First Name to delete contact from Address Book: ");
            string delete = Console.ReadLine();
            if (Address_Book.Count > 0)
            {
                foreach (Details person in Address_Book)
                {
                    if (delete == person.Firstname)
                    {
                        Console.Write("To Delete This Contact Press 0 : ");
                        int confirm = Convert.ToInt32(Console.ReadLine());

                        if (confirm == 0)
                        {
                            Address_Book.Remove(person);
                            Console.WriteLine(" Contact Successfully Deleted");
                            break;
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Address Book is empty");
            }
        }
            public void Display()
            {
                Console.Write("\n Enter the name of the person to get all the contact details : ");
                string name = Console.ReadLine();
                foreach (Details contact in Address_Book)
                {
                    if (name == contact.Firstname)
                    {
                        Console.WriteLine(" First name: {0}", contact.Firstname);
                        Console.WriteLine(" Last name: {0}", contact.LastName);
                        Console.WriteLine(" Address: {0}", contact.Address);
                        Console.WriteLine(" City: {0}", contact.City);
                        Console.WriteLine(" State: {0}", contact.State);
                        Console.WriteLine(" Zip: {0}", contact.ZipCode);
                        Console.WriteLine(" Phone Number: {0}", contact.PhoneNumber);
                        Console.WriteLine(" EMail: {0}", contact.Email);
                    }
                    else
                    {
                        Console.WriteLine("\n Contact of the person {0} does not exist", name);
                    }
                }
        }
    }
}