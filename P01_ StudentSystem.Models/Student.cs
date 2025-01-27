using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_StudentSystem.P01__StudentSystem.Models
{
    internal class Student
    {
       public int StudentId { get; set; }
        public string Name { get; set; }
       public string PhoneNumber { get; set; }
        public DateTime RegisteredOn { get; set; }

        public string Birthday { get; set; }

        public ICollection<Homework> Posts { get; } = new List<Homework>();
        public List<StudentCourse> studentcourses { get; } = [];


    }
}
