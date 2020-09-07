using System;

namespace Class_02
{
    class Program
    {
        static void Main(string[] args)
        {
            //enter student's grade
            string gradeInput = Console.ReadLine();
            int grade = Convert.ToInt32(gradeInput);
            //display pass if passed
            if (grade >= 70)
            {
                Console.WriteLine("Passed");
            }
            // display fail if not passed
            else
            //if(!(grade>=70))
            {
                Console.WriteLine("Failed");
            }
            
        }
    }
}
