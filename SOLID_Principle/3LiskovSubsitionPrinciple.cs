using LiskovSubsitionPrinciple_Problem;
using System;
using System.Collections.Generic;
using System.Text;

namespace LiskovSubsitionPrinciple_Problem
{
    public class Payment
    {
        public virtual void Pay(double amount)
        {
            Console.WriteLine("Processing payment");
        }
    }

    public class CreditCardPayment : Payment
    {
        public override void Pay(double amount)
        {
            Console.WriteLine("Paid via Credit Card");
        }
    }

    public class FreePayment : Payment
    {
        public override void Pay(double amount)
        {
            throw new Exception("No payment required");
        }
    }
    public class MainClass
    {
//        Parent expects “Pay works”
//👉 Child breaks contract → LSP violated
        public static void Main(string[] args)
        {
            Payment payment = new FreePayment();
            payment.Pay(100); // 💥 breaks expectation
        }
    }
}



namespace LiskovSubsitionPrinciple_Solution
{
    public interface IPayment
    {
        void Pay(double amount);
    }
    public class CreditCardPayment : IPayment
    {
        public void Pay(double amount)
        {
            Console.WriteLine("Paid via Credit Card");
        }
    }

    //Handle “free” scenario differently
    public class NoPaymentRequired
    {
        public void Process()
        {
            Console.WriteLine("No payment needed");
        }
    }
    public class MainClass
    {
        //        Parent expects “Pay works”
        //👉 Child breaks contract → LSP violated
        public static void Main(string[] args)
        {
            IPayment payment = new CreditCardPayment();
            payment.Pay(100);
            // var payment = new NoPaymentRequired(); // Handle “free” scenario separately
        }
    }
}