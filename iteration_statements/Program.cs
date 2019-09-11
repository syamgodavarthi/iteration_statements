using System;

namespace Iteration_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
         Console.Write("How many years of experience do you have in professional programming?");
            try
            {
                string input = Console.ReadLine();
                int exp = int.Parse(input);
                for (int i = 0; i < exp; i++)
                    {
                        Console.WriteLine("you have:" + i.ToString() + " years of experience");
                    }
                    Console.WriteLine("Press any key to exit the program ...");
                    Console.ReadKey(true);
            } 
            catch
            {
                Console.WriteLine("Please enter an valid input ...");
                Console.WriteLine("Press any key to exit the program ...");
                Console.ReadKey(true);
            } 
        } 
    } 
} 
