namespace DataType.ValueType
{
    internal class ArrayProblems
    {
        internal void Merge2Arrays(int[] arr1, int[] arr2)
        {
            int[] mergedArray = new int[arr1.Length + arr2.Length];
            int i = 0, j = 0, k = 0;
            while (i < arr1.Length && j < arr2.Length)
            {
                if (arr1[i] < arr2[j])
                {
                    mergedArray[k++] = arr1[i++];
                }
                else
                {
                    mergedArray[k++] = arr2[j++];
                }
            }
            while (i < arr1.Length)
            {
                mergedArray[k++] = arr1[i++];
            }
            while (j < arr2.Length)
            {
                mergedArray[k++] = arr2[j++];
            }
            Console.WriteLine("Merged Array: " + string.Join(", ", mergedArray));
        }   
    
        internal void FindDuplicateElements(int[] arr)
        {
            HashSet<int> seen = new HashSet<int>();
            HashSet<int> duplicates = new HashSet<int>();
            foreach (var item in arr)
            {
                if (!seen.Add(item))
                {
                    duplicates.Add(item);
                }
            }
            Console.WriteLine("Duplicate Elements: " + string.Join(", ", duplicates));
        }

        internal void FindDuplicateElementsUsingLINQ(int[] arr)
        {
             var result = arr.GroupBy(x=>x).Where(g=>g.Count()>1).ToList();
            Console.WriteLine("Duplicate Elements: " + string.Join(", ", result));
        }

        internal void Find2ndLargestElement(int[] arr)
        {
            if (arr.Length < 2)
            {
                Console.WriteLine("Array must contain at least two elements.");
                return;
            }

            int first = int.MinValue, second = int.MinValue;

            foreach (var num in arr)
            {
                if (num > first)
                {
                    second = first;
                    first = num;
                }
                else if (num > second && num != first)
                {
                    second = num;
                }
            }
            if (second == int.MinValue)
            {
                Console.WriteLine("There is no second largest element.");
            }
            else
            {
                Console.WriteLine("Second Largest Element: " + second);
            }
        }


    }
}
