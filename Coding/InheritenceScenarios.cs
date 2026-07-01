using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding
{
    public class InheritenceScenarios
    {
        public void MainMethod()
        {
            Animal a = new Dog();    // Dog IS-A Animal. Upcasting

            // Dog a = new Animal(); // Downcasting not allowed |  compile-time error | Animal is NOT always a Dog
            Dog d = (Dog)a;       // Downcasting allowed with explicit cast | compile-time error | Animal is NOT always a Dog
            a.Sound();
        }

        class Animal // Base class or Parent class or Super class or Generalized class
        {
            public virtual void Sound()
            {
                Console.WriteLine("Animal Sound");
            }
        }

        class Dog : Animal // Derived class or Child class or Sub class or Specialized class
        {
            public override void Sound()
            {
                Console.WriteLine("Dog Bark");
            }
        }
    }


    #region Scenaio 2: Virtual Method Call in Constructor
    // It will print -------------- Naveen .
    class Parent // Base class or Parent class or Super class
    {
        public Parent()
        {
            Display();
        }

        public virtual void Display()
        {
            Console.WriteLine("Parent");
        }
    }

    class Child : Parent // Derived class or child class or Sub class
    {
        private string name = "Naveen";

        public override void Display()
        {
            Console.WriteLine(name);
        }
    }
    #endregion

    #region Real Senior-Level Interview Scenario
    class Parent1
    {
        public Parent1()
        {
            Print();
        }

        public virtual void Print()
        {
            Console.WriteLine("Parent");
        }
    }

    class Child1 : Parent1
    {
        int x = 10;

        public override void Print()
        {
            Console.WriteLine(x);
        }
    }

    class MainClass
    {
        public static void Main()
        {
            Child1 c = new Child1();
        }
    }

    #endregion


    #region Constructor + Virtual Method Dangerous Scenario
    class Base
    {
        public Base()
        {
            Print();
        }

        public virtual void Print()
        {
            Console.WriteLine("Base");
        }
    }

    class Derived : Base
    {
        string name = "Naveen";

        public override void Print()
        {
            Console.WriteLine(name.Length);
        }
    }

    class MainClass2
    {
        public static void Main2()
        {
            Derived d = new Derived();
        }
    }
    #endregion
}
