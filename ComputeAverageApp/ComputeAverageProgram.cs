using System;

namespace ComputeAverageApp
{
    internal class ComputeAverageProgram
    {
        static double grades, totalG, totalAve;
        static void Main(string[] args)
        {
           
            Console.WriteLine("Enter 5 grades separated by new line:");

            for (int i = 0; i < 5; i++)
            {

                grades = Convert.ToDouble(Console.ReadLine());

                totalG += grades;
            
            }

            totalAve = totalG / 5;

            Console.WriteLine("The average is " + totalAve + " and round off to " + Math.Round(totalAve));

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();

        }
    }
}