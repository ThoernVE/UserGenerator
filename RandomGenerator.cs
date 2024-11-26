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
        public static Random random = new Random(); //defining a random.

        public static void GenerateUsers(int usersNumber) //function that generates users based on the amount that the user inputs.
        {
            for (int i = 0; i < usersNumber; i++)
            {
                string firstName = User.firstNames[random.Next(User.firstNames.Count)];
                string lastName = User.lastNames[random.Next(User.lastNames.Count)];
                int birthYear = random.Next(1924, 2024);
                int birthMonth = random.Next(1, 12);
                int birthDay = DaysPerMonth(birthYear, birthMonth);
                string address = User.addresses[random.Next(User.addresses.Count)];
                int addressNumber = random.Next(1, 100);
                int postalCode = User.postalCodes[random.Next(User.postalCodes.Count)];

                User.users.Add(new User(firstName, lastName, birthYear, birthMonth, birthDay, address, addressNumber, postalCode));

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

    }
}
