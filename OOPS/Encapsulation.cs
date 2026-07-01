using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_without_Encapsulation
{

    public class BankAccount
    {
        public decimal Balance;
    }

    public class MainClass
    {
        public void MainMethod()
        {
            var account = new BankAccount();

            //Anyone can modify Balance. |  No validation. | Object state can become invalid.
            account.Balance = -10000; // Invalid
        }
    }
}


namespace Solution_with_Encapsulation
{
    public class BankAccount
    {
        private decimal _balance;

        public decimal Balance
        {
            get { return _balance; }
        }
    }
    public class MainClass
    {
        public void MainMethod()
        {
            var account = new BankAccount();

            // Now, not all can change Balance.
            account.Balance = -10000; // Invalid
        }
    }
}


namespace Encapsualtion_Using_Properties
{
    public class Employee
    {
        public string Name { get; set; }

        private decimal _salary;

        public decimal Salary
        {
            get => _salary;

            set
            {
                if (value < 0)
                    throw new ArgumentException("Salary cannot be negative");

                _salary = value;
            }
        }
    }

    public class MainClass
    {
        public void MainMethod()
        {
            var emp = new Employee();

            emp.Salary = 50000;   // OK
            emp.Salary = -1000;   // Exception
        }
    }
}