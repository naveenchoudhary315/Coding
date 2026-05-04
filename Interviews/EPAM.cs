using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace Interviews
{
    public class EPAM
    {
        List<Product> ProductData;
        public EPAM()
        {
            ProductData = new List<Product>
            {
                 new Product { ProductId = 1, Salary = 5,  Data = 2.0 },
                 new Product { ProductId = 1, Salary = 4,  Data = 1.0 },
                 new Product { ProductId = 2, Salary = 15, Data = 2.0 },
                 new Product { ProductId = 1, Salary = 5,  Data = 3.0 },
                 new Product { ProductId = 3, Salary = 5,  Data = 1.0 },
                 new Product { ProductId = 2, Salary = 15, Data = 2.0 }
            };
        }

        //write linq query group by ProdcutId, find sum of salary * data.
        public void LINQToFindProduct()
        {
            var result = ProductData
                .GroupBy(p => p.ProductId)
                .Select(g => new
                {
                    ProductId = g.Key,
                    Total = g.Sum(x => x.Salary * x.Data)
                })
               .ToList();

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

        }

        //Input = aaannbbccccddd Output = a2b2c3d3n2
        public void GetCustomCount(string input = "aaannbbccccddd")
        {
            Dictionary<char, int> keyValuePairs = new Dictionary<char, int>();

            for (int i = 0; i <= input.Length - 1; i++)
            {
                if (keyValuePairs.TryGetValue(input[i], out int val))
                {
                    keyValuePairs[input[i]] = ++val;
                }
                else
                {
                    keyValuePairs.Add(input[i], 1);
                }
            }
        }


    }

    public class Product
    {
        public int ProductId { get; set; }
        public int Salary { get; set; }
        public double Data { get; set; }
    }
}
