using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateOfWater
{
    class Program
    {
        static void Main(string[] args)
        {
            int userInput;
            Console.WriteLine("Enter the current temperature:");
            userInput = Int32.Parse(Console.ReadLine());

            if(userInput <= 0)
            {
                Console.WriteLine("The water will be a solid.");
            }else if(userInput >= 100){
                Console.WriteLine("The water will be a gas.");
            }
            else
            {
                Console.WriteLine("The water will be a liquid.");
            }
            Console.ReadLine();
        }
    }
}
