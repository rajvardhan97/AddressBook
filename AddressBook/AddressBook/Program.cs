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
            Console.WriteLine("Choose an option \n 1.Add Contact \n 2.Edit Contact \n 3.Delete Contact \n 4. Display \n");
            int number = Convert.ToInt32(Console.ReadLine());
            switch(number)
            {
                case 1:
                    contact.AddContact();
                    break;
                case 2:
                    contact.Edit();
                    break;
                case 3:
                    contact.Delete();
                    break;
                case 4:
                    contact.Display();
                    break;
                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }   
        }
    }
}