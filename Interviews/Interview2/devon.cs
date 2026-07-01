using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interviews.Interview_4
{
    internal class devon
    {
        public decimal CalculateDiscount(List<decimal> prices, decimal percentage)
        {
            //prices = new List<decimal> { 10.00m, 20.00m, 30.00m };
            //percentage = 10.00m;

            var totalPrices = prices.Sum(x => x);
            var discount = (totalPrices * percentage) / 100;
            var actualCost = totalPrices - discount;
            return actualCost;
        }
    }

    //How to replace ifelse.
    // Solution  : stragy pattern.
    public static class CustomerDiscountFactory
    {
        //public static Func<CustomerType, decimal> CreateCustomer = static customerType =>
        //{
        //    //switch (customerType)
        //    //{
        //    //    case CustomerType.Normal:
        //    //        return _ => 10;
        //    //    case CustomerType.Premium:
        //    //        return _ => 20;
        //    //    default:
        //    //        throw new ArgumentException("Invalid customer type");
        //    //}
        //};

    }
    public class CustomerType
    {
    }



}
