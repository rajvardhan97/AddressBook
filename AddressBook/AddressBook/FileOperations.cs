using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    class FileOperations
    {
        const string filepath = @"G:\RFP\AddressBook\AddressBook\AddressBook\File.txt";

        public static void GetDictionary(Dictionary<string, List<AddressBook>> addressbooknames)
        {
            File.WriteAllText(filepath, string.Empty);
    
            foreach (KeyValuePair<string, List<AddressBook>> kvp in addressbooknames)
            {
                File.AppendAllText(filepath, "Address Book: " + kvp.Key + "\n");
                foreach (var member in kvp.Value)
                {
                    File.AppendAllText(filepath, member.ToString());
                }

                File.AppendAllText(filepath, Environment.NewLine);
                Console.WriteLine("The Content written in the file");
          
                ReadAddressBook();
            }

        }
        public static void ReadAddressBook()
        {
            try
            {
                string[] text = File.ReadAllLines(filepath);
                foreach (var mem in text)
                    Console.WriteLine(mem);
                Console.WriteLine("\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
