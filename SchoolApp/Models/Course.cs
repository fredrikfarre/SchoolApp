using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolApp.Models
{
    public class Course
    {      
        public int CourseID { get; set; }
        public string Title { get; set; }
        public virtual ICollection<Course> Courses { get; set; }
    }
}
