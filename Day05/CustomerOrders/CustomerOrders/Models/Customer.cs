using System;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CustomerOrders.Models
{
    public class Customer
    {
        public enum Gender { Male, Female}
        [Key]
        public int ID { get; set; }


        [Required(ErrorMessage = "You Should Enter a Name!")]
        [MaxLength(30, ErrorMessage = "Too long Name char!!!!!!")]
        [Display(Name = "CustomerName")]
        public string Name { get; set; }

        [Required]
        [EnumDataType(typeof(Gender))]
        public Gender gender { get; set; }

        [Required(ErrorMessage = "Enter Email....")]
        [DataType(DataType.EmailAddress)]
       
        public string Email { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string phoneNum { get; set; }
        public  ICollection<Order> orders { get; set; }

    }
//    Customer shoud have the following properties:
//- ID
//- Name
//- Gender
//- email
//- phoneNum
}