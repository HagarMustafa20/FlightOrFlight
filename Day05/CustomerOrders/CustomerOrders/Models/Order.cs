using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CustomerOrders.Models
{
    public class Order
    {
        [Key]
        public int ID { get; set; }

        [Required, DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime Date { get; set; }

        [DataType(DataType.Currency)]
        [MaxPrice(9999)]
        public decimal TotalPrice { get; set; }
        
        
        
        public int CustomerID { get; set; }
        [ForeignKey("CustomerID")]
        public  Customer customer { get; set; }

    }
//    Order shoud have the following properties:
//- ID
//- Date
//- TotalPrice
//[ForeignKey("Customer")]
//- CustID
}