using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    class ContactSort : IComparer<AddressBook>
    { 
        public enum sortBy
        {
            firstName
        }
        public sortBy compareByFields;
        public int Compare(AddressBook address, AddressBook book)
        {
            switch (compareByFields)
            {
                case sortBy.firstName:
                    return address.firstName.CompareTo(book.firstName);
                default: 
                    break;
            }
            return address.firstName.CompareTo(book.firstName);
        }
    }
}
