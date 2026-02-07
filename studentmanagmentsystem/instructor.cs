using System;
using System.Collections.Generic;
using System.Text;

namespace studentmanagmentsystem
{
    public class Instructor
    {
        public int InstructorId { get; set; }
        public string Name { get; set; }

        public string Specialization { get; set; }
        public Instructor(int instructorId, string name, string specialization)
        {
            this.InstructorId = instructorId;
            this.Name = name;
            this.Specialization = specialization;
        }
        public string PrintDetails()
        {
            return $"ID: {InstructorId}, Name: {Name}, Specialization: {Specialization}";
        }
    }
}

