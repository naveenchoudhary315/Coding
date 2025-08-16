using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataType.LINQ
{
    internal class SetOperations
    {
        public void SetOperationsExample()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
            List<int> numbers2 = new List<int> { 1, 2, 3, 4, 5 };
            var distinctNums = numbers.Distinct();
            var unionNums = numbers.Union(numbers2);
            var commonNums = numbers.Intersect(numbers2);
            var exceptNums = numbers.Except(numbers2);

        }
    }
}
