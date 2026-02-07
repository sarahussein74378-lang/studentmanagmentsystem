using System;
using System.Collections.Generic;
using System.Text;

namespace studentmanagmentsystem
{
    public class Student
    {
            public int StudentId { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }
            public List<Course> courses { get; set; }

         public Student (int studentId, string name, int age)
        {

             StudentId = studentId;

             Name = name;

             Age = age;

            List<Course> courses = new List<Course>();
        }
        public bool Enroll(Course course)
        {
            if (!courses.Contains(course))
            {
                courses.Add(course);
                return true;
            }
            return false;
        }

        public string PrintDetails()
        { 

            return $"ID: {StudentId}, Name: {Name}, Age: {Age}, Courses: {courses}";
        }
    }




}
