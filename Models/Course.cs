using System;

namespace CourseManagementSystemFinal.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public DateTime StartDate { get; set; }
        public string Author { get; set; }

     //   public byte[] Image { get; set; }

    }
}
