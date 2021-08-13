using System;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            bool incorrectOption = true;
            string option = "";
            while (incorrectOption)
            {
                System.Console.WriteLine("MAIN MENU:\n\n1.Start game\n2.Exit");
                option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        System.Console.WriteLine("Starting game, please wait ....");
                        incorrectOption = false;
                        break;
                    case "2":
                        System.Console.WriteLine("Thanks for playing!");
                        incorrectOption = false;
                        break;
                    default:
                        Console.Clear();
                        incorrectOption = true;
                        break;
                }
            }
        }
    }
}