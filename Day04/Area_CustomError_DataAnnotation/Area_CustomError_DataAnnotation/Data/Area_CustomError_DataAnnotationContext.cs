using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Area_CustomError_DataAnnotation.Data
{
    public class Area_CustomError_DataAnnotationContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public Area_CustomError_DataAnnotationContext() : base("name=Area_CustomError_DataAnnotationContext")
        {
        }

        public System.Data.Entity.DbSet<Area_CustomError_DataAnnotation.Models.Employee> Employees { get; set; }
    }
}
