using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FirstMVCApp_43.Models
{
    public class CarList
    {
       public static List<Car> Cars = new List<Car>()
       { 
            new Car() { Num = 873, Color = "Red", Model = "2022", Manfacture = "Good Engine" },
            new Car() { Num = 589, Color = "Black", Model = "1990", Manfacture = "High Speed" },
            new Car() { Num = 394, Color = "Silver", Model = "2016", Manfacture = "Good Engine" },
            new Car() { Num = 599, Color = "Gold", Model = "1900", Manfacture = "Good Engine" },
           
       };
    }
}