using System;

namespace DeclarationAndConversionVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            //This is a implicit declaration of the variable 'agePerson'
            //Using the keyword 'var', the compiler asign in the execution time the type of the variable.
            //In this example the compiler asign the type 'int' because we say agePerson=27
            //A diference between others languages is that if you make a implicit declaration like this one,
            //you have to respect the data type, yo can't change it. Other diference between other languages is
            //that if you make a implicit declaration like this one, you have to inicialize (asing a value) in the same declaration.
            var agePerson = 27;
            Console.WriteLine(agePerson);
            /*
            This is not possible in C# because the declaration and the initialitation are in diferent lines of the code.
            var agePerson;
            agePerson=27;
            */

            /*
            This is not possible in C# because the data type of agePerson change from int to string
            var agePerson = 27;
            agePerson = "27";
            */
            /*
            This is not possible in C# because the data type of agePerson change from int to string
            int number = 1;
            number ="1";
            */

            //This is an example of casting, called also explicit conversion
            //When you make a casting, you have to respect the rules. Not all the posibilities of casting are permited, 
            //it depends of the types
            float temperature = 37.56F;
            int aproxTemperature = (int)temperature;

            Console.WriteLine(temperature);
            Console.WriteLine(aproxTemperature);

            //To convert a text in other type you have to use the method parse
            Console.WriteLine("How old are you?");
            string years = Console.ReadLine();
            int yearsnext = int.Parse(years);
            yearsnext++;
            Console.WriteLine("The next year you will have " + yearsnext + " years");
        }
    }
}