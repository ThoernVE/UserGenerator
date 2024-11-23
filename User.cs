using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserGenerator
{
    internal class User
    {
        public string FirstName ="";
        public string LastName ="";
        public int BirthYear = 0;
        public int BirthMonth = 0;
        public int BirthDay = 0;
        public string Address = "";
        public int AddressNumber = 0;
        public int PostalCode = 0;

        public User(string firstName, string lastName, int birthYear, int birthMonth, int birthDay, string address, int addressNumber, int postalCode)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthYear = birthYear;
            BirthMonth = birthMonth;
            BirthDay = birthDay;
            Address = address;
            AddressNumber = addressNumber;
            PostalCode = postalCode;
        }

        public static List<string> firstNames = new List<string>{"James", "Mary", "Michael", "Patricia", "Robert", "Jennifer", "John", "Linda", "David",
            "Elizabeth", "William", "Barbara", "Richard", "Susan", "Joseph", "Jessica", "Thomas", "Karen", "Christopher", "Sarah", "Charles",
            "Lisa", "Daniel", "Nancy", "Matthew", "Sandra", "Anthony", "Betty", "Mark", "Ashley", "Donald", "Emily", "Steven", "Kimberly",
            "Andrew", "Margaret", "Paul", "Donna", "Joshua", "Kenneth", "Carol", "Kevin", "Amanda", "Brian", "Melissa", "Timothy", "Deborah", "Ronald", "Stephanie"};

        public static List<string> lastNames = new List<string>{"Andersson", "Johansson", "Karlsson", "Nilsson", "Eriksson", "Larsson", "Olsson", "Persson",
            "Svensson", "Gustafsson", "Pettersson", "Jonsson", "Jansson", "Hansson", "Bengtsson", "Jönsson", "Lindberg", "Jakobsson", "Magnusson",
            "Lindström", "Olofsson", "Lindqvist", "Lindgren", "Berg", "Axelsson", "Bergström", "Lundberg", "Lind", "Lundgren", "Mattsson",
            "Berglund", "Fredriksson", "Sandberg", "Henriksson", "Ali", "Forsberg", "Mohamed", "Sjöberg", "Wallin", "Engström", "Eklund",
            "Danielsson", "Lundin", "Håkansson", "Björk", "Bergman", "Gunnarsson", "Wikström", "Holm" };

        public static List<string> addresses = new List<string> {"Önskeringsvägen", "Villagatan", " Vidargatan", "Grönviksvägen",
            "Ehrenstrahlsvägen", "Margaretavägen", "Narvavägen", "Viktor Rydbergsgatan", "Vikbyvägen", "Skansvägen",
            "Önstanväg", "Doktorsvägen", "Kungsgårdsvägen", "Åsgatan", "Du Rietzvägen", "Timmerby Village", "Visborgsgatan",
            "Fyrbåksvägen", "Parkettgatan"};

        public static List<int> postalCodes = new List<int> {11235, 58257, 39677, 20357, 21357, 25986, 35126, 60354, 50768, 40986, 72658, 97651, 65312, 50321, 55317};
    }
}
