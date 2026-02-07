using System.ComponentModel;
using System.Transactions;

namespace studentmanagmentsystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student(1, "Alice Smith", 20);
            Instructor instructor1 = new Instructor(1, "John Doe", "Computer Science");
            Course course1 = new Course(1, "introduction to programming", instructor1);

            School school = new School();
            List<Student>students = new List<Student>();
             List<Instructor>instructors = new List<Instructor>();
             List<Course>courses = new List<Course>();
             school.AddStudent(student1);
             school.AddInstructor(instructor1);
             school.AddCourse(course1);
             int i;
            do
            {
                Console.WriteLine("welcome to student management system");
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. Add Instructor");
                Console.WriteLine("3. Add Course");
                Console.WriteLine("4. Enroll Student in Course");
                Console.WriteLine("5. show All Students");
                Console.WriteLine("6. show All Courses");
                Console.WriteLine("7. show All Instructors");
                Console.WriteLine("8.find the student by id or name");
                Console.WriteLine("9.find the course by id or name");
                Console.WriteLine("10. Exit");

                Console.WriteLine("Enter your choice");
                int Choice = Convert.ToInt32(Console.ReadLine());
                switch (Choice)
                {
                    case 1:
                        Console.WriteLine("student name");
                        string name = Console.ReadLine();
                        if (string.IsNullOrEmpty(name))
                        {
                            Console.WriteLine("Student name cannot be empty.");
                            break;
                        }
                        Console.WriteLine("age");
                        int age = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("student id");
                        int studentId = Convert.ToInt32(Console.ReadLine());
                        school.FindStudent(studentId);
                        school.AddStudent(new Student(studentId, name, age));
                        Console.WriteLine("student added sucssesfully");
                        break;
                    case 2:
                        Console.WriteLine(" instructor name");
                        string name1 = Console.ReadLine();
                        Console.WriteLine("specialization");
                        string specialization = Console.ReadLine();
                        Console.WriteLine("instructorId");
                        int instructorId = Convert.ToInt32(Console.ReadLine());
                        school.AddInstructor(new Instructor(instructorId, name1, specialization));
                        break;
                      
                    case 3:
                        Console.WriteLine("course name");
                        string courseName = Console.ReadLine();
                        if (string.IsNullOrEmpty(courseName))
                        {
                            Console.WriteLine("Course name cannot be empty.");
                            break;
                        }

                        Console.WriteLine("instructorId");
                        instructorId = Convert.ToInt32(Console.ReadLine());
                        Instructor foundInstructor = school.FindInstructor(instructorId);
                        if (foundInstructor == null)
                        {
                            Console.WriteLine("Instructor not found.");
                            break;
                        }
                        int newCourseId = school.courses.Count > 0 ? school.courses.Max(c => c.courseid) + 1 : 1;
                        school.AddCourse(new Course(newCourseId, courseName, foundInstructor));
                        Console.WriteLine("course added sucssesfully");
                        break;
                    case 4:
                        Console.WriteLine("student id");
                        int StudentId = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("course id");
                        int courseId = Convert.ToInt32(Console.ReadLine());
                        if (school.EnrollStudentInCourse(StudentId, courseId))
                        {
                            Console.WriteLine("student enrolled in course successfully");
                        }
                        else
                        {
                            Console.WriteLine("enrollment failed. Please check student ID and course ID.");
                        }
                        break;
                    case 5:
                        for (i = 0; i < school.students.Count; i++)
                        {
                        
                             Console.WriteLine(school.students[i].PrintDetails());
                        }
                        break;

                     case 6:
                        for (i = 0; i < school.courses.Count; i++)
                        {
                            Console.WriteLine(school.courses[i].PrintDetails());
                        }
                        break;

                     case 7:
                        for (i = 0; i < school.instructors.Count; i++)
                        {
                            Console.WriteLine(school.instructors[i].PrintDetails());
                        }
                        break;
                     case 8:
                        Console.WriteLine("Enter instructor Id or name to search:");
                        string InstructorId = Console.ReadLine();
                        school.FindInstructor(int.Parse(InstructorId));
                        break;
                     case 9:
                        Console.WriteLine("Enter course ID or name to search:");
                        string CourseId = Console.ReadLine();
                        school.FindCourse(int.Parse(CourseId));
                        break;

                     case 10:
                        Console.WriteLine("Exiting the program. Goodbye!");
                        return;

                }
            }
            while (true);
        }
    }
}
