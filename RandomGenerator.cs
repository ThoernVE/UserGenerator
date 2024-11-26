using System;
using System.Collections.Generic;
using System.Linq;
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
                int birthDay = random.Next(1, 31);
                string address = User.addresses[random.Next(User.addresses.Count)];
                int addressNumber = random.Next(1, 100);
                int postalCode = User.postalCodes[random.Next(User.postalCodes.Count)];

                User.users.Add(new User(firstName, lastName, birthYear, birthMonth, birthDay, address, addressNumber, postalCode));

                
            }
        }
    }
}
