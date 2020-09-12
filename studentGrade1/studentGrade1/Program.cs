using System;
using static System.Console;

namespace studentGrade1
{
    class Program
    {
        static void Main(string[] args)
        {
            //enter student's score
            //print the letter grade from the score
            WriteLine("Enter a score");
            string gradeInput = ReadLine();
            int grade = Convert.ToInt32(gradeInput);
            if (grade >= 90)
            {
                WriteLine($"The letter grade of {grade} is A");
            }
            else if (grade >= 80)
            {
                WriteLine($"The letter grade of {grade} is B");
            }
            else if (grade >= 70)
            {
                WriteLine($"The letter grade of {grade} is C");
            }
            else if (grade >= 60)
            {
                WriteLine($"The letter grade of {grade} is D");
            }
            else
            {
                WriteLine($"The letter grade of {grade} is F");
            }
        }
    }
}