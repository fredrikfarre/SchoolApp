using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolApp.Models
{
    public class Assignment
    {
        public int ID { get; set; }
        [Required]
        [Column(TypeName = "varchar(20)")]
        public string AssignmentName { get; set; }
        public virtual ICollection<Assignment> Assignments { get; set; }
    }
}
