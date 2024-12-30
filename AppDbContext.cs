using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace UserGenerator
{
    internal class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"DataSource=(localdb)\MSSQLLocalDB;InitialCatalog=TrialAndError;Trusted_Connection=True;");
        }
    }

    public class User
    {
        public string FirstName = "";
        public string LastName = "";
        public int BirthYear = 0;
        public int BirthMonth = 0;
        public int BirthDay = 0;
        public string Address = "";
        public int AddressNumber = 0;
        public int PostalCode = 0;

        public User(string firstName, string lastName, int birthYear, int birthMonth, int birthDay, string address, int addressNumber, int postalCode) //concstructor to user
        {
            //FirstName = firstName;
            LastName = lastName;
            BirthYear = birthYear;
            BirthMonth = birthMonth;
            BirthDay = birthDay;
            Address = address;
            AddressNumber = addressNumber;
            PostalCode = postalCode;
        }

        public override string ToString() //toString override to print data correctly
        {
            return FirstName + " " + LastName + " " + BirthYear + "-" + BirthMonth + "-" + BirthDay + " " + Address + " " + AddressNumber + " " + PostalCode;
        }
    }
}
