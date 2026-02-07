using System;
using System.Collections.Generic;
using System.Text;

namespace studentmanagmentsystem
{
    internal partial class School
    {
        public List<Student> students { get; set; }
        public List<Instructor> instructors { get; set; }
        public List<Course> courses { get; set; }
        public School()
        {
            students = new List<Student>();
            instructors = new List<Instructor>();
            courses = new List<Course>();
        }

        public bool AddStudent(Student student)
        {
            students.Add(student);
            return true;
        }

        public bool AddInstructor(Instructor instructor)
        {
            instructors.Add(instructor);
            return true;
        }

        public bool AddCourse(Course course)
        {
            courses.Add(course);
            return true;
        }

        public Student FindStudent(int studentId)
        {
            return students.Find(s => s.StudentId == studentId);
        }

        public Course FindCourse(int courseId)
        {
            return courses.Find(c => c.courseid == courseId);
        }

        public Instructor FindInstructor(int instructorId)
        {
            return instructors.Find(i => i.InstructorId == instructorId);
        }

        public bool EnrollStudentInCourse(int studentId, int courseId)
        {
            Student student = FindStudent(studentId);
            Course course = FindCourse(courseId);
            if (student == null || course == null)
            {
                return false;
            }
            course.AddStudent(student);
            student.courses.Add(course);
            return true;
        }
    }
}
