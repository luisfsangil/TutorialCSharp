using System;

namespace Methods
{
    class Program
    {
        static void ScreenMessage(string a)
        {
            Console.WriteLine(a);
        }
        //When a method have only one line of code and it is the line that
        //content the return, in C# its posible use the operator '=>'
        static int sum(int n1, int n2) => n1 + n2;
        //this is an example of the overload of methods.
        //Both methods have the same name but diferent number or type of parameters
        static int sum(int n1, int n2, int n3) => n1 + n2 + n3;
        //This is a method with optional parameter
        static int mult(int n1, int n2 = 1) => n1 * n2;

        static void Main(string[] args)
        {
            ScreenMessage("Hi guys!!");
            Console.WriteLine(sum(3, 2));
            Console.WriteLine(mult(5));
            Console.WriteLine(mult(5, 5));
        }
    }
}