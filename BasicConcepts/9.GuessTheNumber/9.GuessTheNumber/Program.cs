using System;

namespace _9.GuessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //Generating a random number
            Random number = new Random();
            int aleatorynumber = number.Next(0, 100);
            //At this moment, gameEnd is false
            bool gameEnd = false;
            //Asking the name to the user
            Console.Clear();
            System.Console.WriteLine("Guess the number between 0 and 100 ...");
            int resp = 0;
            while (!gameEnd)
            {
                resp = int.Parse(Console.ReadLine());
                if (resp < aleatorynumber)
                {
                    System.Console.WriteLine("its higher than " + resp);
                }
                else if (resp > aleatorynumber)
                {
                    System.Console.WriteLine("its lower than " + resp);
                }
                else
                {
                    System.Console.WriteLine("Yes! you Guess the number!!");
                    gameEnd = true;
                }
            }
        }
    }
}