using System.Collections;
using System.Numerics;

namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // LINQ - Language Integrated Query

            // Projection and Filtering (Select, Where, OfType)
            // Sorting (OrderBy, OrderByDescending, ThenBy, ThenByDescending, Reverse)
            // Quantifiers (Any, All, Contains)
            // Partitionaing (Skip, SkipWhile, Take, TakeWhile, Chunk)
            // Set Operations (Distinct, DistinctBy, Except, ExceptBy, Intersect, IntersectBy, Union, UnionBy)
            // Joins (Join, GroupJoin)
            // Grouping (GroupBy, ToLookup)

            // ----------------------------------------------

            // Projection and Filtering (Select, Where, OfType)

            var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //var result = from number in numbers where number > 5 select number; // LINQ Query Syntax
            var result = numbers.Where(n => n > 5); // LINQ Method Syntax (Preferred)
            // Note: result variable stores the query, not the result of the query which is called deferred execution.
            // Deferred execution means that the query is not executed until you iterate over the result.
            foreach (var number in result)  // Query Execution
            {
                Console.WriteLine(number);
            }
            numbers.AddRange(new int[] { 11, 12, 13, 14, 15 }); // Modifying the source collection
            foreach (var number in result)  // Query Execution again reflects the changes in the source collection
            {
                Console.WriteLine(number);
            }
            // In order to execute the query immediately and store the result, use ToList() or ToArray()

            // Example of OfType
            ArrayList arrayList = new ArrayList();
            arrayList.Add(1);
            arrayList.Add("Two");
            arrayList.Add(3);
            arrayList.Add("Four");
            var intResults = arrayList.OfType<int>();   // Filters only the integers from the ArrayList
            foreach (var item in intResults)
            {
                Console.WriteLine(item);
            }

            // ----------------------------------------------

        }
    }
}
