using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;

namespace CustomerOrders_Core.Model
{
    public class Course
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string Topic { get; set; }

        [Required]
        public int CourseGrade { get; set; }

        public int StudentID { get; set; }
        [ForeignKey("StudentID")]
        public Student student { get; set; }

    }
}
