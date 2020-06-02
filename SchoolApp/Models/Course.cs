using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolApp.Models
{
    public class Course
    {      
        public int CourseID { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public virtual ICollection<Course> Courses { get; set; }
    }
}
