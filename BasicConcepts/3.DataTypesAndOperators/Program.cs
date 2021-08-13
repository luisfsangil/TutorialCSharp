using System;

namespace DataTypesAndOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            byte userage = 27;
            //This is the tipical form to concatenate strings
            Console.WriteLine("The age of the user is " + userage + " years");
            //But in C# you can also make this to concatenate strings
            //This is the 'strings interpolation'
            Console.WriteLine($"The age of the user is {userage} years");
        }
    }
}