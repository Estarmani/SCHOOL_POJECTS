using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace First_GPA_App
{
    public class PrintTable:Program
    {
        

        public void PrintHeader()
        {
            

            Console.WriteLine("|-----------------|---------------|---------|------------|------------|");
            Console.WriteLine("| COURSE AND CODE |  COURSE UNIT  |  GRADE  | GRADE UNIT |   REMARK   |");
            Console.WriteLine("|-----------------|---------------|---------|------------|------------|");
            Console.Write(Program.allPrint);
            Console.WriteLine("|-----------------|---------------|---------|------------|------------|");
            Console.WriteLine("Total course unit registeres is {0}", (total_course_unit_reg));
            Console.WriteLine("Total course unit passed is {0} ", (total_course_unit_pass));
            Console.WriteLine("Total weight point is {0}", (total_weight_point));
            Console.WriteLine("Your GPA is = {0:N2}", GPA);
        }
       
    }
    public class Program
    {
        public string Course = "";
        public int courseUnit = 0;
        public char grade;
        public int courseScore;
        public int grade_unit = 0;
        public string remark;
        public double weightPoint = 0;
        public static double GPA;
        public int totalCourseUnit = 0;
        public int totalGradeUnit = 0;
        public static int total_course_unit_reg = 0;
        public static double total_course_unit_pass = 0;
        public static double total_weight_point = 0;
        public static string allPrint = "";

        public void Calculation()
        {

            Console.WriteLine("       WELCOME TO GPA CALCULATOR       ");

            Console.WriteLine("How many courses do you want to calculate? ");
            int TotalCourse = int.Parse(Console.ReadLine());
            // This will determine how many times the for loop will run

            try
            {

            }
            catch (Exception)
            {

                Console.WriteLine("invalide");
            }
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
                    weightPoint = courseUnit * grade_unit;
                    remark = "Excellent";
                }
                else if (courseScore >= 60 && courseScore <= 69)
                {
                    grade = 'B';
                    grade_unit = 4;
                    weightPoint = courseUnit * grade_unit;
                    remark = "Very Good";
                }
                else if (courseScore >= 50 && courseScore <= 59)
                {
                    grade = 'C';
                    grade_unit = 3;
                    weightPoint = courseUnit * grade_unit;
                    remark = "Good";
                }
                else if (courseScore >= 45 && courseScore <= 49)
                {
                    grade = 'D';
                    grade_unit = 2;
                    weightPoint = courseUnit * grade_unit;
                    remark = "Fair";
                }
                else if (courseScore >= 40 && courseScore <= 44)
                {
                    grade = 'E';
                    grade_unit = 1;
                    weightPoint = courseUnit * grade_unit;
                    remark = "Pass";
                }
                else
                {
                    grade = 'F';
                    grade_unit = 0;
                    weightPoint = courseUnit * grade_unit;
                    remark = "Fail";
                }

                total_weight_point += weightPoint;
                totalCourseUnit += courseUnit;
                totalGradeUnit += grade_unit;

                allPrint += $"| {Course,-15} | {courseUnit,-13} | {grade,-7} | {grade_unit,-10} | {remark, -10} |\n";

            }
            Console.Clear();
            GPA = total_weight_point / totalCourseUnit;
            total_course_unit_pass += totalGradeUnit;
            total_course_unit_reg += totalCourseUnit;
            
        }

        public static void Main()
        {
            var obj = new Program();
            obj.Calculation();
           var objTable = new PrintTable();
            objTable.PrintHeader();
        }
    }
}
