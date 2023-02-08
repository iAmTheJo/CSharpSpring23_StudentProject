using System;
using App.LearningManagement.Helpers;
using Library.LearningManagement.Models;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var studentHelper = new StudentHelper();
            var courseHelper = new CourseHelper();

            bool cont = true;

            while (cont)
            {
                Console.WriteLine("Choose an action:");                
                Console.WriteLine("1. Add a student enrollment");
                Console.WriteLine("2. List all enrolled students");
                Console.WriteLine("3. Search for a student");
                Console.WriteLine("4. Add a new course");
                Console.WriteLine("0. Exit");
                var input = Console.ReadLine();

                if (int.TryParse(input, out int result))
                {                    
                    if (result == 1)//add
                    {
                        studentHelper.CreateStudentRecord();
                    }
                    else if (result == 2)//list
                    {
                        studentHelper.ListStudents();
                    }
                    else if (result == 3)//search
                    {
                        studentHelper.SearchStudents();
                    }
                    else if (result == 4) // add course
                    {
                        courseHelper.CreateCourseRecord();
                    }
                    else if (result == 0)//exit
                    {
                        cont = false;
                    }
                }
            }
        }
    }
}