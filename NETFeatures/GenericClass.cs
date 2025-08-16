using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETFeatures
{
    internal class GenericClass
    {
    }

    public class Box<T>
    {
        private T _value;

        public void Add(T item) => _value = item;
        public T Get() => _value;
    }
    public class GenericClassDemo
    {
        public static void Main()
        {
            // Create a box for integers
            Box<int> intBox = new Box<int>();
            intBox.Add(123);
            Console.WriteLine("Integer in box: " + intBox.Get());
            // Create a box for strings
            Box<string> strBox = new Box<string>();
            strBox.Add("Hello Generics");
            Console.WriteLine("String in box: " + strBox.Get());
        }
    }

    //Generic Constraints
    public class Repository<T> where T : class, new()
    {
        public T Create()
        {
            return new T(); // works because we restricted to "new()"
        }
    }

    //Generic Methods
    public class Utils
    {
        public static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
    }


}
