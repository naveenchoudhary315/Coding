using System;
using System.Collections.Generic;
using System.Text;

namespace OpenForExtenstion_ClosedForModification_Problem
{
    public class DiscountCalculator
    {
        public double GetDiscount(string customerType, double amount)
        {
            if (customerType == "Regular")
                return amount * 0.1;
            else if (customerType == "Premium")
                return amount * 0.2;
            else if (customerType == "VIP")
                return amount * 0.3;

            return 0;
        }
    }
}
namespace OpenForExtenstion_ClosedForModification_Solution
{
    public interface IDiscountStrategy
    {
        double GetDiscount(double amount);
    }
    public class RegularCustomerDiscount : IDiscountStrategy
    {
        public double GetDiscount(double amount)
        {
            return amount * 0.1;
        }
    }
    public class PremiumCustomerDiscount : IDiscountStrategy
    {
        public double GetDiscount(double amount)
        {
            return amount * 0.2;
        }
    }
    public class VIPCustomerDiscount : IDiscountStrategy
    {
        public double GetDiscount(double amount)
        {
            return amount * 0.3;
        }
    }

    public class DiscountService
    {
        public double Calculate(IDiscountStrategy customer, double amount)
        {
            return customer.GetDiscount(amount);
        }
    }

    public class MainClass
    { 
        public void Main() {

            var customer = new PremiumCustomerDiscount();
            var service = new DiscountService();

            double discount = service.Calculate(customer, 1000);

        }
    }
}
