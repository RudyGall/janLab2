using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2Jan
{
    class Program
    {
        static void Main(string[] args)
        {
            char doAgain;
            bool runP = true;
            while (runP == true)
            {
                Console.WriteLine("Please enter the length of the classroom.");
                int cLength = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("You entered: {0}, Please enter the width of the classroom.",
                    cLength);
                int cWidth = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("You entered {0} and {1}, " +
                    "Lets check the perimeter and the area of the classroom.",
                    cLength, cWidth);
                int areaAnswer = (cLength * cWidth);
                Console.WriteLine("The area of the classroom is {0}.", areaAnswer);
                int perimeterAnswer = ((cLength * 2) + (cWidth * 2));
                Console.WriteLine("The perimeter of the classroom is {0}.", perimeterAnswer);
                Console.WriteLine("\nWould you like to try again? (y or n)");
                doAgain = Convert.ToChar(Console.ReadLine().ToLower());
                if (doAgain == 'n')
                {
                    Console.WriteLine("Thank you, Goodbye!");
                    Console.ReadLine();
                    runP = false;
                }
                else if (doAgain == 'y')
                {
                    runP = true;
                }
                else
                    Console.WriteLine("Invalid entry, try again");
            }
        }
    }
}
