
using System;

namespace Constants
{
    class Program
    {
        static void Main(string[] args)
        {
            //The constants have to be initialiced at the same tame of the declaration
            //Its a good practice to call the constants in capital letters
            const float PI = 3.1416F;
            Console.WriteLine("Introduce the radious please ");
            float radious = float.Parse(Console.ReadLine());
            double area = PI * Math.Pow(radious, 2);
            Console.WriteLine("The area of the circle with " + radious + " m of radio is " + area + " m²");
        }
    }
}