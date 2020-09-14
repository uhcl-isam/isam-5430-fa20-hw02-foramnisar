using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Assignments.Loop1
{
    public class OddNumbers
    {
        /// <summary>
        /// First prompt for the start and the end number. Then, Write all odd integers between start and ending number inclusive 
        /// (in ascending order) on separate lines.
        /// </summary>

        public static void Main()
        {
            Console.Error.WriteLine("Enter the starting number");
            // Codes to enter start
            string input1, input2;
            int num1, num2;
            input1 = Console.ReadLine();
            num1 = Convert.ToInt32(input1);
            Console.Error.WriteLine("Enter the ending number");
            // Codes to enter end.
            input2 = Console.ReadLine();
            num2 = Convert.ToInt32(input2);
            for (int i = num1; i <= num2; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
                
            }
        }
    }
}
