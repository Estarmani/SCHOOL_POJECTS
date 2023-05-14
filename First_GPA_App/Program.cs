using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_GPA_App
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("       WELCOME TO GPA CALCULATOR       ");

            Console.WriteLine("How many courses do you want to calculate? ");
            int TotalCourse = int.Parse(Console.ReadLine());
            // This will determine how many times the for loop will run

            string Course = "";
            int courseUnit = 0;
            char grade;
            int courseScore;
            int grade_unit = 0;
            string remark;
            double weightPoint = 0;
            double GPA;
            int totalCourseUnit = 0;
            int totalGradeUnit = 0;
            int total_course_unit_reg = 0;
            double total_course_unit_pass = 0;
            double total_weight_point = 0;
            string allPrint = "";

            try
            {
                for (int x = 0; x < TotalCourse; x++)
                {
                    Console.WriteLine("Enter course and code");
                    Course = Console.ReadLine();

                    Console.WriteLine($"Enter course unit for {Course} : ");
                    courseUnit = int.Parse(Console.ReadLine());

                    Console.WriteLine($"enter course score {Course} : ");
                    courseScore = int.Parse(Console.ReadLine());


                    if (courseScore >= 70 && courseScore <= 100)
                    {
                        grade = 'A';
                        grade_unit = 5;
                        remark = "Excellent";
                    }
                    else if (courseScore >= 60 && courseScore <= 69)
                    {
                        grade = 'B';
                        grade_unit = 4;
                        remark = "Very Good";
                    }
                    else if (courseScore >= 50 && courseScore <= 59)
                    {
                        grade = 'C';
                        grade_unit = 3;
                        remark = "Good";
                    }
                    else if (courseScore >= 45 && courseScore <= 49)
                    {
                        grade = 'D';
                        grade_unit = 2;
                        remark = "Fair";
                    }
                    else if (courseScore >= 40 && courseScore <= 44)
                    {
                        grade = 'E';
                        grade_unit = 1;
                        remark = "Pass";
                    }
                    else
                    {
                        grade = 'F';
                        grade_unit = 0;
                        remark = "Fail";
                    }
                    weightPoint += courseUnit * grade_unit;
                    total_weight_point += weightPoint;
                    totalCourseUnit += courseUnit;
                    totalGradeUnit += grade_unit;

                    allPrint += $"{Course}, {courseUnit}, {grade}, {grade_unit}, {remark}\n";

                }
                Console.Clear();
                GPA = total_weight_point / totalCourseUnit;
                total_course_unit_pass += totalGradeUnit;
                total_course_unit_reg += totalCourseUnit;

                Console.WriteLine(allPrint);

                Console.WriteLine("Total course unit registeres is {0}" ,(total_course_unit_reg));
                Console.WriteLine("Total course unit passed is {0} ", (total_course_unit_pass));
                Console.WriteLine("Total weight point is {0}" , (total_weight_point));
                Console.WriteLine("Your GPA is = {0:N2}", GPA);


            }

            catch (Exception)
            {
             Console.WriteLine("invalid");
                    
            }
               
        }
    }
}
