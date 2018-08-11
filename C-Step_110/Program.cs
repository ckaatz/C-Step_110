using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Step_110
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Math mathAnswer1 = new Math();

            Console.WriteLine("Pick a number:");
            int answer = Convert.ToInt32(Console.ReadLine());
            int sum = mathAnswer1.Addition(answer);
            Console.WriteLine("Your number plus 1 equals " + sum);

            int difference = mathAnswer1.Subtraction(answer);
            Console.WriteLine("Your number minus 1 equals " + difference);

            int square = mathAnswer1.SquareIt(answer);
            Console.WriteLine("Your number squared is " + square);

            Console.ReadLine();
        }

        

        
    }
}
