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

        public static void Run() //main-function that runs the program
        {
            Console.WriteLine("Hello and welcome to the UserGenerator! \n" +
                "How many Users would you like to generate?");
            try //try/catch to handle invalid inputs
            {
                int numberOfUsers = Convert.ToInt32(Console.ReadLine());
                RandomGenerator.GenerateUsers(numberOfUsers); //function that generates the amount of users that the user chooses
            }
            catch //catch-case that reruns the function in case of an invalid input.
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

        private static void optionSwitch()  //function that takes lets the user choose what they want to do with the data
        {

            switch (Console.ReadKey().Key)
            {

                case ConsoleKey.NumPad1:
                case ConsoleKey.D1:
                    Console.Clear();
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

        public static void Print() //function to print userdata
        {
            foreach (var user in User.users)
            {
                Console.WriteLine(user);
            }
        }

        private static void ConvertJSON() //function to convert data into a JSON-file in MyDocuments on the users local computer.
        {
            var serializedObject = Newtonsoft.Json.JsonConvert.SerializeObject(User.users, Formatting.Indented); //converts data into a var variable thats serialized into json.

            var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments); //defines where to put the json file
            var filepath = Path.Combine(path, "UserData.json"); //defines the filepath, where to put the file and what to name the file

            using (StreamWriter sw = new StreamWriter(filepath)) //streamwriter that writes the json-object into the file.
            {
                sw.Write(serializedObject);
            }

            Console.WriteLine("\nYour data has been placed in: 'MyDocuments', under the filename 'UserData.json'");
        }
    }
}