using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_StudentSystem.P01__StudentSystem.Models
{ 
    public enum ResourceType
        {
            Video,
            Presentation,
            Document,
            Other
        }
    internal class Resource
    {
       
        public int ResourceId { get; set; }
        public string Name { get; set; }
        public string url { get; set; }

        public ResourceType ResourceType { get; set; }

        public int CourseId { get; set; }
    }
}
