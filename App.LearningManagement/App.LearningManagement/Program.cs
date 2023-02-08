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
                Console.WriteLine("2. Update a student enrollment");
                Console.WriteLine("3. List all enrolled students");
                Console.WriteLine("4. Search for a student");
                Console.WriteLine("5. Add a new course");
                Console.WriteLine("6. Update a course");
                Console.WriteLine("7. List all courses");
                Console.WriteLine("0. Exit");
                var input = Console.ReadLine();

                if (int.TryParse(input, out int result))
                {                    
                    if (result == 1)//add
                    {
                        studentHelper.CreateStudentRecord();
                    }
                    if (result == 2) // update
                    {
                        studentHelper.UpdateStudentRecord();
                    }
                    else if (result == 3)//list
                    {
                        studentHelper.ListStudents();
                    }
                    else if (result == 4)//search
                    {
                        studentHelper.SearchStudents();
                    }
                    else if (result == 5) // add course
                    {
                        courseHelper.CreateCourseRecord();
                    }
                    else if(result == 6)
                    {
                        courseHelper.UpdateCourseRecord();
                    }
                    else if (result == 7) // list courses
                    {
                        courseHelper.ListCourses();
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