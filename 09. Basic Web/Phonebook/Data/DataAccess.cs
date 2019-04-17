using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Phonebook.Data.Models;

namespace Phonebook.Data
{
    public class DataAccess
    {
        static DataAccess()
        {
            Contacts = new List<Contact>();
        }

        public static List<Contact> Contacts { get; set; }
    }
}
