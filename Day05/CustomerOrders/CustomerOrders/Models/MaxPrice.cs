using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CustomerOrders.Models
{
    public class MaxPrice : ValidationAttribute
    {

        int Value;
        public MaxPrice(int num)
        {
            Value = num;
        }
        public override bool IsValid(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            else
            {
                if (obj is decimal)
                {
                    decimal suppliedValue = (decimal)obj;
                    if (suppliedValue < Value)
                    {
                        return true;
                    }
                    else
                    {
                        ErrorMessage = "Maximum value for Price should be < " + Value; //user validation error
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
        }
    }
}