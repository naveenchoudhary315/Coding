using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace NETFeatures
{
    internal class Reflection
    {
       public static void ReflectionTest()
        {
            // Get type information
            Type type = typeof(Person);

            Console.WriteLine("Type Name: " + type.Name);

            // List all properties
            foreach (var prop in type.GetProperties())
                Console.WriteLine("Property: " + prop.Name);

            // List all methods
            foreach (var method in type.GetMethods())
                Console.WriteLine("Method: " + method.Name);
        }

        public static void UsageReflection( )
        {
            Type type = typeof(Person);

            // Create instance
            object personObj = Activator.CreateInstance(type);

            // Set property via reflection
            PropertyInfo nameProp = type.GetProperty("Name");
            nameProp.SetValue(personObj, "Naveen");

            // Invoke method
            MethodInfo sayHello = type.GetMethod("SayHello");
            sayHello.Invoke(personObj, null);

        }

    }

   class PersonDemo
    {
        public string Name { get; set; }
        public void SayHello() => Console.WriteLine($"Hello, I’m {Name}");
    }

    
}
