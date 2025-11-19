using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guesser_2._0
{
    internal class Engine
    {


        public void Do(int randomNumber)
        {
            Console.WriteLine("The number");
            string? userInput = Console.ReadLine();
            int guess = Convert.ToInt32(userInput);

            while (guess == randomNumber) 
            {
                if (guess > randomNumber)
                {
                    Console.WriteLine("Try smaller");
                }
                else
                {
                    Console.WriteLine("Try bigger");
                }
            }
            Console.WriteLine("You won....");
        }
    }
}
