using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataType.ValueType
{

    internal class IntExample
    {
        public void IntTest()
        {
            
            // Integral types
            byte smallByte = 255; // 0 to 255
            sbyte signedByte = -128; // -128 to 127
            short smallShort = -32768; // -32768 to 32767
            ushort unsignedShort = 65535; // 0 to 65535
            int number = 2147483647; // -2,147,483,648 to 2,147,483,647  // 2 Billion
            uint unsignedInt = 4294967295; // 0 to 4,294,967,295
            long bigLong = 9223372036854775807L; // -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
            ulong unsignedLong = 18446744073709551615UL; // 0 to 18,446,744,073,709,551,615
            decimal preciseDecimal = 79228162514264337593543950335M; // High precision decimal type
             

        }
    }
}
