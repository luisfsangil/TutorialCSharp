using System;

namespace OwnExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            System.Console.WriteLine("Say the number of the month");
            byte numberOfMonth = byte.Parse(Console.ReadLine());
            try
            {
                sayTheMonth(numberOfMonth);
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
            }
        }
        static void sayTheMonth(byte p)
        {
            switch (p)
            {
                case 1:
                    System.Console.WriteLine("January");
                    break;
                case 2:
                    System.Console.WriteLine("February");
                    break;
                case 3:
                    System.Console.WriteLine("March");
                    break;
                case 4:
                    System.Console.WriteLine("April");
                    break;
                case 5:
                    System.Console.WriteLine("May");
                    break;
                case 6:
                    System.Console.WriteLine("June");
                    break;
                case 7:
                    System.Console.WriteLine("July");
                    break;
                case 8:
                    System.Console.WriteLine("August");
                    break;
                case 9:
                    System.Console.WriteLine("September");
                    break;
                case 10:
                    System.Console.WriteLine("October");
                    break;
                case 11:
                    System.Console.WriteLine("November");
                    break;
                case 12:
                    System.Console.WriteLine("December");
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
                    break;
            }
        }
    }
}