using System;
using System.Collections.Generic;
using System.Text;

namespace studentmanagmentsystem
{
    public class Course
    {
       public int courseid { get; set; }
       public string title { get; set; } 
       public Instructor  Insttructor { get; set; }
        public Course(int corseid , string title , Instructor instructor)
        {
            this.courseid = corseid;
            this.title = title;
            this.Insttructor = instructor;

        }
        public bool AddStudent(Student student)
        {

            return false;
        }
        public string PrintDetails()
        {
            return $"ID: {courseid}, Title: {title}, Instructor: {Insttructor}";
        }
    }

}
