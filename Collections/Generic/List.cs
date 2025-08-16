using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.Generic
{
    internal class List
    {
          public  static void LisTest()
         {
            List<string> fruits = new List<string> { "Apple", "Banana", "Mango" };
            fruits.Add("Orange");
            fruits.Remove("Banana");

            Console.WriteLine("List<T> Example:");
            foreach (var fruit in fruits)
                Console.WriteLine(fruit);
        }
    }
}
