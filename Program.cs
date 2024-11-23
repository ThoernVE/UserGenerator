using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            Console.WriteLine("Hello and welcome to the UserGenerator!/n" +
                "How many Users would you like to geenrate?");
            int numberOfUsers = Convert.ToInt32(Console.ReadLine());
            RandomGenerator.GenerateUsers(numberOfUsers);
        }
    }
}