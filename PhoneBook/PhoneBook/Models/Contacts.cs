using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PhoneBook.Models
{
    public class Contacts
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Num { get; set; }
        public string Adress { get; set; }
    }
    public class ContactsDBContext :DbContext
    {
        public DbSet<Contacts> Contacts { get; set; }
    }
}