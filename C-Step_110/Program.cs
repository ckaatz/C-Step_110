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
            mathAnswer1 = Addition(mathAnswer1);

            Math mathAnswer2 = new Math();
            mathAnswer2 = Subtraction(mathAnswer2);

            Math mathAnswer3 = new Math();
            mathAnswer3 = SquareIt(mathAnswer3);

            Console.ReadLine();
        }

        public static Math Addition(Math mathAnswer1)
        {
            Console.WriteLine("Pick a number:");
            int answer = Convert.ToInt32(Console.ReadLine());
            mathAnswer1.AddOne = answer + 1;
            Console.WriteLine(answer + " plus 1 equals " + mathAnswer1.AddOne);
            return mathAnswer1;
        }

        public static Math Subtraction(Math mathAnswer2)
        {
            Console.WriteLine("Pick another number:");
            int answer2 = Convert.ToInt32(Console.ReadLine());
            mathAnswer2.SubtractOne = answer2 - 1;
            Console.WriteLine(answer2 + " minus 1 equals " + mathAnswer2.SubtractOne);
            return mathAnswer2;
        }

        public static Math SquareIt(Math mathAnswer3)
        {
            Console.WriteLine("Pick a final number:");
            int answer3 = Convert.ToInt32(Console.ReadLine());
            mathAnswer3.Squared = answer3 * answer3;
            Console.WriteLine(answer3 + " squared equals " + mathAnswer3.Squared);
            return mathAnswer3;
        }
    }
}
