using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Grade_Calculator_using_2D_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] subjects = new string[5];
            int[] marks = new int[5];

            Console.WriteLine("Enter the names and marks of 5 subjects:");
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Subject {i + 1} Name: ");
                subjects[i] = Console.ReadLine();

                Console.Write($"Marks for {subjects[i]}: ");
                marks[i] = Convert.ToInt32(Console.ReadLine());
            }

            int totalMarks = 0;
            for (int i = 0; i < 5; i++)
            {
                totalMarks += marks[i];
            }

            double percentage = (double)totalMarks / 500 * 100;

            string grade;
            if (percentage >= 90)
                grade = "A+";
            else if (percentage >= 80)
                grade = "A";
            else if (percentage >= 70)
                grade = "B";
            else if (percentage >= 60)
                grade = "C";
            else if (percentage >= 50)
                grade = "D";
            else
                grade = "F";

            Console.WriteLine($"\nTotal Marks: {totalMarks}");
            Console.WriteLine($"Percentage: {percentage:F2}%");
            Console.WriteLine($"Grade: {grade}");
        }
    }
}
