using Runtime_Polymorphism;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compile_Time_Polymorphism
{
    public class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public double Add(double a, double b)
        {
            return a + b;
        }

        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }

        class MainClass
        {
            public void MainCall()
            {
                Calculator calc = new Calculator();

                calc.Add(10, 20);
                calc.Add(10.5, 20.5);
                calc.Add(10, 20, 30);
            }
        }
    }
}

namespace Runtime_Polymorphism
{
    public class NumbersCalculateClass  // Base Class can be abstract /interfac
    {
        public virtual void Print_NumbersCalculateClass()
        {
            Console.WriteLine("NumbersCalculateClass");
        }
        public virtual void CopyData()
        {
            Console.WriteLine("NumbersCalculateClass");
        }
    }

    public class TwoDigitNumberCalculator : NumbersCalculateClass // Derived Classes
    {
        //If virtual it will hide this method and execute base class method.
        public virtual void Print_NumbersCalculateClass()
        {
            Console.WriteLine("TwoDigitNumberCalculator");
        }
        public void Print_TwoDigitNumberCalculator()
        {
            Console.WriteLine("Two Digit Calculator");
        }
    }
    class MainClass
    {
        public void MainCall()
        {
            NumbersCalculateClass baseClass;

            #region Base class scenarios
            baseClass = new NumbersCalculateClass(); //Base class object.
            baseClass.Print_NumbersCalculateClass(); // It can call its methods only.

            //TwoDigitNumberCalculator numbersCalculateClass = new NumbersCalculateClass(); // Downcasting not allowed.
            #endregion

            //You can access all members of TwoDigitNumberCalculator and its base class.
            TwoDigitNumberCalculator twoDigitNumberCalculator = new TwoDigitNumberCalculator();


            // Compile - time type = NumbersCalculateClass  || Runtime type =TwoDigitNumberCalculator
            // This is upcasting.
            // You can access only members available in the base class reference.
            baseClass = new TwoDigitNumberCalculator();
            baseClass.Print_NumbersCalculateClass();
            baseClass.CopyData();
            //calculator.Print_TwoDigitNumberCalculator(); //  // Compile Error

            //because it gives flexibility, extensibility, and loose coupling.

            //If we use base type :  Later you can replace the implementation without changing the consuming code..
            baseClass = new ThreeDigitNumberCalculator();
            baseClass.Print_NumbersCalculateClass();
            baseClass.CopyData();
        }
    }

    // New requirement case for ThreeDigits.
    // So, we can use same functionality only we need to pass class.
    // Now, we can use Three printer.

    // "Program to an interface (or base class), not to an implementation."
    public class ThreeDigitNumberCalculator : NumbersCalculateClass
    {
        //If virtual it will hide this method and execute base class method.
        public override void Print_NumbersCalculateClass()
        {
            Console.WriteLine("TwoDigitNumberCalculator");
        }
        public void Print_ThreeDigitNumberCalculator()
        {
            Console.WriteLine("Three Digit Calculator");
        }
    }
}

