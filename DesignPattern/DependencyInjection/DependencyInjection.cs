using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.DependencyInjection
{
    public class Department
    {
        public void Work()
        {
            Console.WriteLine("Department working");
        }
    }

    public class Company
    {
        private readonly Department _dept;

        public Company()
        {
            // Company directly creates dependency
            _dept = new Department();
        }

        public void Execute()
        {
            _dept.Work();
        }
    }


    public class MainClass
    {

        public static void Main()
        {
            //Company is tightly coupled to Department.
            //If tomorrow you want to use HR instead of Department, you must modify Company.
            //required code changes. _dept = new HR();
            Company company = new Company();
            company.Execute();
        }
    }
}

namespace DependencyInjection_Solution
{
    public interface IDepartment
    {
        void Work();
    }

    public class Department : IDepartment
    {
        public void Work()
        {
            Console.WriteLine("Department working");
        }
    }

    public class HR : IDepartment
    {
        public void Work()
        {
            Console.WriteLine("HR working");
        }
    }

    public class Company
    {
        private readonly IDepartment _dept;

        // Dependency Injection through constructor
        public Company(IDepartment dept)
        {
            _dept = dept;
        }

        public void Execute()
        {
            _dept.Work();
        }
    }

    public class MainClass
    {
        public static void Main()
        {
            // Inject Department dependency
            Company company1 = new Company(new Department());
            company1.Execute();

            // Inject HR dependency
            Company company2 = new Company(new HR());
            company2.Execute();
        }
    }
}