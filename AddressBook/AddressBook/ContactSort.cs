using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook
{
    class ContactSort : IComparer<AddressBook>
    {
        public enum sortBy
        {
            firstName,
            city,
            state,
            zip
        }
        public sortBy compareByFields;

        public int Compare(AddressBook x, AddressBook y)
        {
            switch (compareByFields)
            {
                case sortBy.firstName:
                    return x.firstName.CompareTo(y.firstName);
                case sortBy.city:
                    return x.city.CompareTo(y.city);
                case sortBy.state:
                    return x.state.CompareTo(y.state);
                case sortBy.zip:
                    return x.zip.CompareTo(y.zip);
                default: break;

            }
            return x.firstName.CompareTo(y.firstName);
        }
    }
}