using System;

namespace Conditionals
{
    class Program
    {
        static bool legalage(int _age) => _age >= 18;
        static void Main(string[] args)
        {
            Console.WriteLine("Whats your age?");
            int age = int.Parse(Console.ReadLine());
            if (legalage(age)) Console.WriteLine("You have the legal age");
            else Console.WriteLine("Sorry, you dont have the legal age");
        }
    }
}