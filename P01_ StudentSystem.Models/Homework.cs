using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_StudentSystem.P01__StudentSystem.Models
{
    public enum ContentType
    {
        Application,
        Pdf,
        Zip
    }
    internal class Homework
    {
        public int HomeworkId { get; set; }
        public string Content { get; set; }
        public ContentType ContentType { get; set; }

        public TimeOnly SubmissionTime { get; set; }
        public int StudentId { get; set; }

        public int CourseId { get; set; }
    }
}
