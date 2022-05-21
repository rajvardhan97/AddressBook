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
            Console.WriteLine("----------- \n Address Book \n ----------- \n");
            Contact contact = new Contact();
            Console.WriteLine("Choose an option \n 1.Create Contact");
            int number = Convert.ToInt32(Console.ReadLine());
            switch(number)
            {
                case 1:
                    contact.AddContact();
                    break;
                    Console.WriteLine("Invalid Choice");
                    break;
            }   
        }
    }
}
