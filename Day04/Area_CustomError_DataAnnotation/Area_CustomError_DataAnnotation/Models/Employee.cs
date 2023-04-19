using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace Area_CustomError_DataAnnotation.Models
{
    public class Employee
    {
        public enum Gender { Male, Female }
        [Key]
        public int ID { get; set; }
        [Required(ErrorMessage = "You Should Enter a Name!")]
        [MaxLength(30, ErrorMessage = "Too long Name char!!!!!!")]
        [Display(Name = "EmployeeName")]
        public string Name { get; set; }
        public string Username { get; set; }
        [Required(ErrorMessage = "You Must Enter Password!")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        [EnumDataType(typeof(Gender))]
        public Gender gender { get; set; }
        public decimal Salary { get; set; }
        [Required, DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime joinDate { get; set; }

        [Required(ErrorMessage = "Enter Email....")]
        [DataType(DataType.EmailAddress)]
        public string email { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string phoneNum { get; set; }
    }
//    - empID
//- Name
//- Username
//- Password
//- Gender
//- Salary
//- joinDate
//- email
//- phoneNum
}