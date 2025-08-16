using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataType.ValueType
{
    internal class TupleTypes
    {
        static void TupleTest()
        {
            // Creating a tuple with 3 elements
            Tuple<int, string, bool> person = Tuple.Create(1, "Alice", true);

            // Accessing items
            Console.WriteLine($"ID: {person.Item1}");
            Console.WriteLine($"Name: {person.Item2}");
            Console.WriteLine($"IsActive: {person.Item3}");
        }

        static void MValueTupleTestin()
        {
            // Creating a ValueTuple with named fields
            (int Id, string Name, bool IsActive) employee = (101, "Bob", true);

            // Accessing by name
            Console.WriteLine($"ID: {employee.Id}");    
            Console.WriteLine($"Name: {employee.Name}");
            Console.WriteLine($"Is Active: {employee.IsActive}");

            // Accessing by position
            Console.WriteLine($"First Item: {employee.Item1}");
        }

        static void MultipleValue()
        {
            var (sum, product) = Calculate(5, 3);
            Console.WriteLine($"Sum = {sum}, Product = {product}");
        }

        static (int, int) Calculate(int a, int b)
        {
            return (a + b, a * b); // returns a tuple
        }

    }
}
