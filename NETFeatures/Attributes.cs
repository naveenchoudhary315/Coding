using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETFeatures
{

    // [Required], [StringLength], [Range] → Validation attributes(ASP.NET Core).
    // [TestMethod], [Fact], [Theory] → Unit testing attributes(MSTest, xUnit).
    // [HttpGet], [HttpPost], [Route] → Web API routing attributes.
    // [NonSerialized] → Excludes field from serialization.
    // [ThreadStatic] → Creates thread-local storage.


    internal class Attributes
    { 
        [Obsolete("Use AddNumbers instead")]
        public int Add(int a, int b) => a + b;

       
        public int AddNumbers(int a, int b) => a + b;
    }

    [Serializable]
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

}
