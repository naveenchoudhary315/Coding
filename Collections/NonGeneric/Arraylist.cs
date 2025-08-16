using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.NonGeneric
{
    internal class Arraylist
    {

        public void ArraylistTest()  
            {
                ArrayList list = new ArrayList();
                list.Add(10);
                list.Add("Hello");
                list.Add(true);

                Console.WriteLine("ArrayList Example:");
                foreach (var item in list)
                    Console.WriteLine(item);
            }
        
    }
}
