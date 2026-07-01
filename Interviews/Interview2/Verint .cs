using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interviews.Interview_4
{
    internal class Verint
    {
        List<string> logs = new List<string>
{
    "api/ui/get/Log1",
    "api/ui/post/Log2",
    "api/ui/get/Log3",
    "api/ui/get/Log4",
    "api/ui/get/Log1",
    "api/ui/post/Log4",
    "api/ui/get/Log2"
};
        public void FindSingleOccurance()
        {
            // Step 1: Count frequency
            var frequency = new Dictionary<string, int>();

            foreach (var log in logs)
            {
                frequency[log] = frequency.GetValueOrDefault(log) + 1;
            }

            // Step 2: Find first element occurring once
            string firstSingle = logs.FirstOrDefault(log => frequency[log] == 1);

        }
    }


}
