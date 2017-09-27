using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool Continue = true;
            while (Continue == true) 
            {
                int input;
                    
                    Console.WriteLine("Enter a number between 1 and 100");
                    input = int.Parse(Console.ReadLine());

                if (input % 2 == 1)
                {
                    Console.WriteLine(input + ". Odd");
                }

                else
                        if (input >= 0 && input <= 25)
                    {
                        Console.WriteLine(input + ". Even and less than 25.");
                    }
                       else if (input >= 26 && input <= 60) 
                    {
                        Console.WriteLine("Even");
                    }
                        else
                    {
                        Console.WriteLine(input + ". Even");
                    }


                string UserChoice;
                Console.WriteLine("Continue(Y/N)?");
                UserChoice = Console.ReadLine();
                if (UserChoice == "N" || UserChoice == "No" || UserChoice == "n" || UserChoice == "no")
                {
                    Continue = false;
                    Console.WriteLine("Goodbye! See you real soon!");
                }


            }
        }
    }
}
