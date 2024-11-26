using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace UserGenerator
{
    internal class RandomGenerator
    {
        public static Random random = new Random();

        public static void GenerateUsers(int usersNumber) //function that generates users based on the amount that the user inputs.
        {
            for (int i = 0; i < usersNumber; i++)
            {
                string firstName = firstNames[random.Next(firstNames.Count)];
                string lastName = lastNames[random.Next(lastNames.Count)];
                int birthYear = random.Next(1924, 2024);
                int birthMonth = random.Next(1, 12);
                int birthDay = DaysPerMonth(birthYear, birthMonth);
                string address = addresses[random.Next(addresses.Count)];
                int addressNumber = random.Next(1, 100);
                int postalCode = postalCodes[random.Next(postalCodes.Count)];

                users.Add(new User(firstName, lastName, birthYear, birthMonth, birthDay, address, addressNumber, postalCode));

            }
        }

        static int DaysPerMonth(int birthYear, int birthMonth)
        {
            if (birthYear % 4 == 0 && birthMonth == 2) //if/else statements to account for different amount of days per months aswell as leap year.
            {
                return random.Next(1, 29);
            }
            else if (birthMonth == 2)
            {
                return random.Next(1, 28);
            }
            else if (birthMonth == 1 || birthMonth == 3 || birthMonth == 5 || birthMonth == 7 || birthMonth == 8 || birthMonth == 10 || birthMonth == 12)
            {
                return random.Next(1, 31);
            }
            else
            {
                return random.Next(1, 30);
            }
        }

        //lists that contains the data that will be randomized from
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

        public static List<int> postalCodes = new List<int> { 11235, 58257, 39677, 20357, 21357, 25986, 35126, 60354, 50768, 40986, 72658, 97651, 65312, 50321, 55317 };

        //list to be able to save tha userdata.
        public static List<User> users = new List<User>();

    }
}
