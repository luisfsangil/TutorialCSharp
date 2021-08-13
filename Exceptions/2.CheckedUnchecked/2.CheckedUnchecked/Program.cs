using System;

namespace checkedUnchecked
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //Using unchecked the program continues
            unchecked{
                int number = int.MaxValue + 1;
                System.Console.WriteLine(number);
            }
            */
            //Other form to do the same thing is
            int number = unchecked(int.Maxvalue + 1);
        }
    }
}