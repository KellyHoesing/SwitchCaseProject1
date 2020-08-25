using System;

namespace SwitchCaseProject1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your favorite classs?");
            string userInput = Console.ReadLine();
            switch(userInput.ToLower())
            {
                case "math":
                    Console.WriteLine("You're a logical person");
                    break;
                case "english":
                    Console.WriteLine("You have a poet's soul");
                    break;
                case "science":
                    Console.WriteLine("You love to experiment");
                    break;
                case "art":
                    Console.WriteLine("You have keen observation skills");
                    break;
                case "gym":
                    Console.WriteLine("You're staying fit!");
                    break;
                default:
                    Console.WriteLine("That's certainly interesting");
                    break;
            }
        }
    }
}
