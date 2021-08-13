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
                try
                {
                    resp = int.Parse(Console.ReadLine());
                }/*catch(FormatException ex){
                    System.Console.WriteLine("Please enter a number");
                }catch(OverflowException ex){
                    System.Console.WriteLine("Please enter a number between 0 and 100");
                }*/
                /*
                catch(FormatException ex){
                    System.Console.WriteLine("Text is not permited");
                }
                catch(Exception ex){
                    System.Console.WriteLine("Please enter a number between 0 and 100");
                    System.Console.WriteLine(ex.Message);
                }*/
                catch (Exception ex) when (ex.GetType() != typeof(FormatException))
                {
                    System.Console.WriteLine("Please enter a number between 0 and 100");
                    System.Console.WriteLine(ex.Message);
                }
                catch (FormatException ex)
                {
                    System.Console.WriteLine("Text is not permited");
                }

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