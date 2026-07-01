using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Inheritance
{
    public class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Animal is eating");
        }
    }

    public class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("Dog is barking");
        }
    }

    class MainClass
    {
        public void MainMethod()
        {
            Dog dog = new Dog(); //Benefit of inheritence it uses functionality of parent/base class.

            dog.Eat();   // Inherited
            dog.Bark();  // Own method
        }
    }
}


namespace Constructor_Execution_Order
{
    public class Animal
    {
        public Animal()
        {
            Console.WriteLine("Animal Constructor");
        }
    }

    public class Dog : Animal
    {
        public Dog()
        {
            Console.WriteLine("Dog Constructor");
        }
    }

    class MainClass
    {
        public void MainMethod()
        {
            Dog dog = new Dog();

            // Output:
            // Animal Constructor
            // Dog Constructor



        }
    }
}

namespace Calling_Base_Constructor
{
    public class Animal
    {
        public Animal(string name)
        {
            Console.WriteLine(name);
        }
    }

    public class Dog : Animal
    {
        public Dog(string name) : base(name)
        {
        }
    }

    class MainClass
    {
        public void MainMethod()
        {
            Dog dog = new Dog("Tommy");

            // Output: Tommy
        }
    }
}
