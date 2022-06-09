using CsvHelper;
using Newtonsoft.Json;
using System;
using System.Globalization;

namespace AddressBook
{
    public class CSVOperations
    {
        public static void CSVOperation(Dictionary<string, List<AddressBook>> addressbooknames)
        {
            string csvFilePath = @"G:\RFP\AddressBook\AddressBook\AddressBook\AddressBookCsvFile.csv";
            File.WriteAllText(csvFilePath, string.Empty);
            foreach (KeyValuePair<string, List<AddressBook>> kvp in addressbooknames)
            {
                using var stream = File.Open(csvFilePath, FileMode.Append);
                using var writer = new StreamWriter(stream);
                using var csvWriter = new CsvWriter(writer, CultureInfo.InvariantCulture);

                foreach (var value in kvp.Value)
                {
                    List<AddressBook> list = new List<AddressBook>();
                    list.Add(value);
                    csvWriter.WriteRecords(list);
                }
                csvWriter.NextRecord();
            }
            using (var reader = new StreamReader(csvFilePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<AddressBook>().ToList();

                foreach (AddressBook data in records)
                {
                    if (data.firstName == "firstName")
                    {
                        Console.WriteLine("\n");
                        continue;
                    }
                    Console.WriteLine(data.ToString());
                }
            }
        }
    }
}
