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
            firstName, city, state, zip
        }
        public sortBy compareByFields;
        public int Compare(AddressBook address, AddressBook book)
        {
            switch (compareByFields)
            {
                case sortBy.firstName:
                    return address.firstName.CompareTo(book.firstName);
                case sortBy.city:
                    return address.city.CompareTo(book.city);
                case sortBy.state:
                    return address.state.CompareTo(book.state);
                case sortBy.zip:
                    return address.zip.CompareTo(book.zip);
                default: 
                    break;
            }
            return address.firstName.CompareTo(book.firstName);
        }
    }
}
