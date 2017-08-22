using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tech_interview_questions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int number = int.Parse(Console.ReadLine());

            if (number % 3 == 0 && number % 5 == 0)
            {
                Console.WriteLine("FIZZ BUZZ");
            }
            else if (number % 3 == 0)
            {
                Console.WriteLine("FIZZ");
            }
            else if (number % 5 == 0)
            {
                Console.WriteLine("BUZZ");
            }

            else 
            {
                Console.WriteLine("Your number is not divisible by 3 or 5");
            }
                        
        }
    }
}
