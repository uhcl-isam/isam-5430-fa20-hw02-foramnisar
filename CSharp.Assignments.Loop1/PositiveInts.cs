﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Assignments.Loop1
{
    public class PositiveInts
    {
        /// <summary>
        /// First prompt for the value of n, then Write all the positive integers up to the integer n on separate lines. [Demonstration]
        /// </summary>
        public static void Main()
        {
            Console.Error.WriteLine("Enter the value of n");
            // write your codes here.
            string input;
            int n;
            input=Console.ReadLine();
            n = Convert.ToInt32(input);
            for (int i=1;i<=n;i++)
            {
                Console.WriteLine(i);
            }
                        
            
        }
    }
}
