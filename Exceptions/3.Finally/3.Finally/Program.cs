using System;

namespace Finally
{
    class Program
    {
        static void Main(string[] args)
        {
            System.IO.StreamReader file = null;
            try
            {
                string line = "", path = "/home/noob";
                byte cont = 0;
                file = new System.IO.StreamReader(path);
                while ((line = file.ReadLine()) != null)
                {
                    System.Console.WriteLine(line);
                    cont++;
                }
            }
            catch (Exception ex)
            {
                System.Console.WriteLine("An error ocurred reading the file");
                System.Console.WriteLine(ex.Message);
            }
            finally
            {
                if (file != null) file.Close();
                System.Console.WriteLine("Conexion with the file closed");
            }
        }
    }
}