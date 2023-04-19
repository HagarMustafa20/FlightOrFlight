
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace CustomerOrders_Core.Model
{
    public class Student
    {
        public enum Gender { Male, Female }
        [Key]
        public int ID { get; set; }


        [Required(ErrorMessage = "You Should Enter a Name!")]
        [MaxLength(30, ErrorMessage = "Too long Name char!!!!!!")]
        [Display(Name = "Student Name")]
        public string Name { get; set; }

        [Required]
        [EnumDataType(typeof(Gender))]
        public Gender gender { get; set; }

        [Required(ErrorMessage = "Enter Email....")]
        [DataType(DataType.EmailAddress)]

        public string Email { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string phoneNum { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime Birthdate { get; set; }

        public ICollection<Course> Courses { get; set; }

    }
}
