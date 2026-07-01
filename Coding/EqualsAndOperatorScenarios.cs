namespace Coding
{
    internal class EqualsAndOperatorScenarios
    {
        // For value types:  == compares values
        // Equals() also compares values
        public void ValueTypeScenario()
        {
            int a = 10;
            int b = 10;

            Console.WriteLine(a == b);   //True
            Console.WriteLine(a.Equals(b));//True
        }

        public void ReferenceTypeScenario()
        {
            Employee e1 = new Employee { id = 1 };
            Employee e2 = new Employee { id = 1 };

            Console.WriteLine(e1 == e2);  //False, because they are different objects in memory
            Console.WriteLine(e1.Equals(e2)); //False, because the default implementation of Equals() in the Object class also compares references

            Employee e3 = new Employee();
            Employee e4 = e3;

            Console.WriteLine(e3 == e4); //True, because they reference the same object in memory
            Console.WriteLine(e3.Equals(e4)); //True, because they reference the same object in memory
        }

        public void StringScenario()
        {
            string s1 = "Hello";
            string s2 = "Hello";
            Console.WriteLine(s1 == s2);  //True, because string literals are interned by the compiler
            Console.WriteLine(s1.Equals(s2)); //True, because they have the same content
        }

        public void ReferenceEqualsScenario()
        {
            Employee e1 = new Employee { id = 1 };
            Employee e2 = new Employee { id = 1 };

            Console.WriteLine(object.ReferenceEquals(e1, e2)); //False, because they are different objects in memory
        }
    }
}
