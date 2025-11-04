using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
//https://www.tutorialsteacher.com/linq/linq-standard-query-operators
namespace Interviews
{
    class Student
    {
        public int StudentID { get; set; }
        public String StudentName { get; set; }
        public int Age { get; set; }
        public int StandardID { get; set; }
    }
    public class Standard
    {
        public int StandardID { get; set; }
        public string StandardName { get; set; }
    }

    public class StudentComparer : IEqualityComparer<Student>
    {
        bool IEqualityComparer<Student>.Equals(Student? x, Student? y)
        {
            if (x.StudentID == y.StudentID)
                return true;
            return false;
        }

        int IEqualityComparer<Student>.GetHashCode(Student obj)
        {
            return obj.GetHashCode();
        }
    }
    internal class LINQ
    {
        List<int> coll = new List<int>() { 1, 4, 6, 7, 8, 66 };
        static Student[] studentArray = {
            new Student() { StudentID = 1, StudentName = "John", Age = 18 },
            new Student() { StudentID = 2, StudentName = "Steve",  Age = 21 },
            new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 },
            new Student() { StudentID = 4, StudentName = "Ram" , Age = 21 },
            new Student() { StudentID = 5, StudentName = "Ron" , Age = 18 },
            new Student() { StudentID = 6, StudentName = "Chris",  Age = 17 },
            new Student() { StudentID = 7, StudentName = "Rob",Age = 21  },
        };

        #region Filtering
        public static void Filtering_Where()
        {
            var res = from student in studentArray
                      where student.Age > 15 && student.Age < 20
                      select student;
        }

        public static void Filtering_OfType()
        {
            IList mixedList = new ArrayList();
            mixedList.Add(0);
            mixedList.Add("One");
            mixedList.Add("Two");
            mixedList.Add(3);
            mixedList.Add(new Student() { StudentID = 1, StudentName = "Bill" });

            var res = from s in mixedList.OfType<string>()
                      select s;
        }

        public static string FilterStringVal()
        {
            IList<string> stringList = new List<string>() {
    "C# Tutorials",
    "VB.NET Tutorials",
    "Learn C++",
    "MVC Tutorials" ,
    "Java" };
            var res = from val in stringList
                      where val.Contains("Tutorials")
                      select val;
            return res.First(); ;

        }

        #endregion

        #region Sorting

        public static void Sorting_OrderBy()
        {
            var ascendingResult = from student in studentArray
                                  orderby student.StudentName
                                  select student;

            var decendingResult = from student in studentArray
                                  orderby student.StudentName descending
                                  select student;

        }
        public static void Sorting_ThenBy()
        {
            var ascendingResult = studentArray.OrderBy(x => x.StudentName).ThenBy(x => x.Age);

            var decendingResult = studentArray.OrderBy(x => x.StudentName).ThenByDescending(x => x.Age);
        }

        #endregion

        #region Grouping
        public static void Sorting_GroupBy()
        {

            var groupedResult = from student in studentArray
                                group studentArray by student.Age;
            //iterate each group        
            foreach (var ageGroup in groupedResult)
            {
                //Console.WriteLine("Age Group: {0}", ageGroup.Key); //Each group has a key 

                foreach (var s in ageGroup) // Each group has inner collection
                {
                    Console.WriteLine("Student Name: {0}", s);
                }
            }
        }

        public static void Sorting_ToLookupBy()
        {
            var res = studentArray.ToLookup(x => x.Age);
        }

        #endregion

        #region Join

        public static void Joins()
        {
            IList<Student> studentList = new List<Student>() {
    new Student() { StudentID = 1, StudentName = "John", Age = 13, StandardID =1 },
    new Student() { StudentID = 2, StudentName = "Moin",  Age = 21, StandardID =1 },
    new Student() { StudentID = 3, StudentName = "Bill",  Age = 18, StandardID =2 },
    new Student() { StudentID = 4, StudentName = "Ram" , Age = 20, StandardID =2 },
    new Student() { StudentID = 5, StudentName = "Ron" , Age = 15 }
                };

            IList<Standard> standardList = new List<Standard>() {
    new Standard(){ StandardID = 1, StandardName="Standard 1"},
    new Standard(){ StandardID = 2, StandardName="Standard 2"},
    new Standard(){ StandardID = 3, StandardName="Standard 3"}
            };

            var joinResult = from student in studentList
                             join standard in standardList
                             on student.StudentID equals standard.StandardID
                             select new
                             {
                                 studentName = student.StudentName,
                                 studentId = student.StudentID,
                             };
        }

        public static void Group_Join()
        {
            IList<Student> studentList = new List<Student>() {
    new Student() { StudentID = 1, StudentName = "John", Age = 13, StandardID =1 },
    new Student() { StudentID = 2, StudentName = "Moin",  Age = 21, StandardID =1 },
    new Student() { StudentID = 3, StudentName = "Bill",  Age = 18, StandardID =2 },
    new Student() { StudentID = 4, StudentName = "Ram" , Age = 20, StandardID =2 },
    new Student() { StudentID = 5, StudentName = "Ron" , Age = 15 }
                };

            IList<Standard> standardList = new List<Standard>() {
    new Standard(){ StandardID = 1, StandardName="Standard 1"},
    new Standard(){ StandardID = 2, StandardName="Standard 2"},
    new Standard(){ StandardID = 3, StandardName="Standard 3"}
            };

            var joinResult = from student in studentList
                             join standard in standardList
                             on student.StudentID equals standard.StandardID
                             into studentGroup
                             select new
                             {
                                 Students = studentGroup,
                                 Name = student.StudentName,
                             };
        }

        #endregion

        #region Projection

        public static void Select_Projections()
        {
            var res = from student in studentArray
                      select new
                      {
                          Name = student.StudentName,
                          Id = student.StudentID,
                      };
        }

        public static void SelectMany_Projections()
        {
            List<string> phrases = ["an apple a day", "the quick brown fox"];

            var res = phrases.SelectMany(x => x.Split(' '));
        }
        #endregion

        #region QunatifierOperators

        public static void All_Projections()
        {
            var allResult = studentArray.All(x => x.Age > 20);
        }

        public static void Any_Projections()
        {
            var allResult = studentArray.Any(x => x.Age > 20);
        }

        public static void Contains_Projections()
        {
            Student stu1 = new Student() { Age = 17, StudentName = "Naveen" };
            Student stu2 = new Student() { StudentID = 2, StudentName = "Steve", Age = 21 };
            var allResult1 = studentArray.Contains(stu1);
            var allResult2 = studentArray.Contains(stu2, new StudentComparer());
        }
        #endregion

        #region Aggregate Functions

        public static void Aggreate()
        {
            IList<String> strList = new List<String>() { "One", "Two", "Three", "Four", "Five" };
            var commaSeperatedString =  strList.Aggregate((a,b) => a +" , "+ b);
        }

        public static void Average()
        {
            IList<int> intList = new List<int> () { 10, 20, 30 };
            var averageres = intList.Average();
        }

        public static void Count()
        {
            IList<int> intList = new List<int>() { 10, 21, 30, 45, 50 };
            var totalElements = intList.Count(); 
        }

        public static void Max()
        {
            IList<int> intList = new List<int>() { 10, 21, 30, 45, 50 };
            var totalElements = intList.Max();
        }
        public static void Min()
        {
            IList<int> intList = new List<int>() { 10, 21, 30, 45, 50 };
            var totalElements = intList.Min();
        }

        public static void Sum()
        {
            IList<int> intList = new List<int>() { 10, 21, 30, 45, 50 };
            var totalElements = intList.Sum(x =>
            {
                if (x > 20) return 1;
                else return 0;
            }
            );
        }
        #endregion

        #region Elements
        public static void Elements()
        {
            IList<int> intList = new List<int>() { 10, 21, 30, 45, 50, 87 };
            IList<string> strList = new List<string>() { "One", "Two", null, "Four", "Five" };

            Console.WriteLine("1st Element in intList: {0}", intList.ElementAt(0));
            Console.WriteLine("1st Element in strList: {0}", strList.ElementAt(0));

            Console.WriteLine("2nd Element in intList: {0}", intList.ElementAt(1));
            Console.WriteLine("2nd Element in strList: {0}", strList.ElementAt(1));

            Console.WriteLine("3rd Element in intList: {0}", intList.ElementAtOrDefault(2));
            Console.WriteLine("3rd Element in strList: {0}", strList.ElementAtOrDefault(2));

            Console.WriteLine("1st Element which is greater than 250 in intList: {0}",
                                intList.First(i=> i > 20));
            Console.WriteLine("1st Element which is greater than 250 in intList: {0}",
                                intList.FirstOrDefault(i => i > 250));

            Console.WriteLine("Last Element in intList: {0}", intList.Last());
            Console.WriteLine("Last Element in intList: {0}", strList.LastOrDefault());

            Console.WriteLine("Element less than 100 in intList: {0}", intList.Single(i => i <= 10));

            Console.WriteLine("Element less than 100 in intList: {0}",
                                                intList.SingleOrDefault(i => i  == 100));
        }

        public static void SequenceEqual()
        {
            IList<string> strList1 = new List<string>() { "One", "Two", "Three", "Four", "Three" };

            IList<string> strList2 = new List<string>() { "One", "Two", "Three", "Four", "Three" };

            bool isEqual = strList1.SequenceEqual(strList2); // returns true

        }
        #endregion

        #region Partitioning 
        // Skip,skipwhile,take,takewhile
        #endregion

        #region Concatenation 
        public static void Concatenation()
        {
            IList<string> collection1 = new List<string>() { "One", "Two", "Three" };
            IList<string> collection2 = new List<string>() { "Five", "Six" };

            var collection3 = collection1.Concat(collection2);

        }
        #endregion

        #region Generation 
        public static void DefaultIfEmpty()
        {
            IList<string> emptyList = new List<string>();

            var newList1 = emptyList.DefaultIfEmpty();
            var newList2 = emptyList.DefaultIfEmpty("No item found");

            Console.WriteLine("Count: {0}", newList1.Count());
            Console.WriteLine("Value: {0}", newList1.ElementAt(0));

            Console.WriteLine("Count: {0}", newList2.Count());
            Console.WriteLine("Value: {0}", newList2.ElementAt(0));

        }

        public static void Empty_Range_Repeat()
        {
            var emptyCollection1 = Enumerable.Empty<string>();
            var emptyCollection2 = Enumerable.Empty<Student>();

            Console.WriteLine("Count: {0} ", emptyCollection1.Count());
            Console.WriteLine("Type: {0} ", emptyCollection1.GetType().Name);

            Console.WriteLine("Count: {0} ", emptyCollection2.Count());
            Console.WriteLine("Type: {0} ", emptyCollection2.GetType().Name);

            var intCollection = Enumerable.Range(10, 10);
            Console.WriteLine("Total Count: {0} ", intCollection.Count());


            var repeatCollection = Enumerable.Repeat<int>(10, 10);
            Console.WriteLine("Total Count: {0} ", repeatCollection.Count());
             
        }



        #endregion

        #region Set Operators Distinct/Except/Interset/Union

        public static void Distinct()
        {
            IList<int> intList = new List<int>() { 1, 2, 3, 2, 4, 4, 3, 5 };

            var distinctList1 = intList.Distinct();
        }

        public static void Except()
        {
            IList<string> strList1 = new List<string>() { "One", "Two", "Three", "Four", "Five" };
            IList<string> strList2 = new List<string>() { "Four", "Five", "Six", "Seven", "Eight" };

            var result = strList1.Except(strList2);
        }

        public static void Intersect()
        {
            IList<string> strList1 = new List<string>() { "One", "Two", "Three", "Four", "Five" };
            IList<string> strList2 = new List<string>() { "Four", "Five", "Six", "Seven", "Eight" };

            var result = strList1.Intersect(strList2);

            foreach (string str in result)
                Console.WriteLine(str);
        }

        public static void Union()
        {
            IList<string> strList1 = new List<string>() { "One", "Two", "Three", "Four", "Five" };
            IList<string> strList2 = new List<string>() { "Four", "THREE", "Six", "Seven", "Eight" };

            var result = strList1.Union(strList2);

            foreach (string str in result)
                Console.WriteLine(str);
        }
        #endregion
    }
}