using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace UserGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Run();
        }

        public static void Run()
        {
            Console.WriteLine("Hello and welcome to the UserGenerator! \n" +
                "How many Users would you like to generate?");
            try
            {
                int numberOfUsers = Convert.ToInt32(Console.ReadLine());
                RandomGenerator.GenerateUsers(numberOfUsers);
            }
            catch
            {
                Console.WriteLine("Invalid input, please try again");
                Console.Clear();
                Run();
            }
            Console.WriteLine("What would you like to do with the data? Please type the correspondning number to choose\n" +
                "1. Print\n" +
                "2. Convert to JSON");
            optionSwitch();
        }

        private static void optionSwitch()
        {

            switch (Console.ReadKey().Key)
            {

                case ConsoleKey.NumPad1:
                case ConsoleKey.D1:
                    Print();
                    break;
                case ConsoleKey.NumPad2:
                case ConsoleKey.D2:
                    ConvertJSON();
                    break;
                default:
                    Console.WriteLine("\nThat input was not possible. Press any button to try again");
                    Console.ReadKey();
                    Console.Clear();
                    Run();
                    break;
            }


        }

        public static void Print()
        {
            foreach (var user in User.users)
            {
                Console.WriteLine(user);
            }
        }

        private static void ConvertJSON()
        {
            var serializedObject = Newtonsoft.Json.JsonConvert.SerializeObject(User.users, Formatting.Indented);

            var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var filepath = Path.Combine(path, "UserData.json");

            using (StreamWriter sw = new StreamWriter(filepath))
            {
                sw.Write(serializedObject);
            }

            Console.WriteLine("\nYour data has been placed in: 'MyDocuments', under the filename 'UserData.json'");
        }
    }
}