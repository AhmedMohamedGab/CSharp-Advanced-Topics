using System.Collections;
using System.Numerics;

namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // LINQ - Language Integrated Query

            // Table of Contents:
            // Projection and Filtering (Select, Where, OfType)
            // Sorting (OrderBy, OrderByDescending, ThenBy, ThenByDescending, Reverse)
            // Quantifiers (Any, All, Contains)
            // Partitioning (Skip, SkipLast, SkipWhile, Take, TakeLast, TakeWhile, Chunk)
            // Set Operations (Distinct, DistinctBy, Except, ExceptBy, Intersect, IntersectBy, Union, UnionBy)
            // Joins (Join, GroupJoin)
            // Grouping (GroupBy, ToLookup)

            // ----------------------------------------------

            // Projection and Filtering (Select, Where, OfType)

            //var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            ////var result = from number in numbers where number > 5 select number; // LINQ Query Syntax
            //var result = numbers.Where(n => n > 5); // LINQ Method Syntax (Preferred)
            //// Note: result variable stores the query, not the result of the query which is called deferred execution.
            //// Deferred execution means that the query is not executed until you iterate over the result.
            //foreach (var number in result)  // Query Execution
            //{
            //    Console.WriteLine(number);
            //}
            //numbers.AddRange(new int[] { 11, 12, 13, 14, 15 }); // Modifying the source collection
            //foreach (var number in result)  // Query Execution again reflects the changes in the source collection
            //{
            //    Console.WriteLine(number);
            //}
            //// In order to execute the query immediately and store the result, use ToList() or ToArray()

            //// Example of OfType
            //ArrayList arrayList = new ArrayList();
            //arrayList.Add(1);
            //arrayList.Add("Two");
            //arrayList.Add(3);
            //arrayList.Add("Four");
            //var intResults = arrayList.OfType<int>();   // Filters only the integers from the ArrayList
            //foreach (var item in intResults)
            //{
            //    Console.WriteLine(item);
            //}

            // ----------------------------------------------

            // Sorting (OrderBy, OrderByDescending, ThenBy, ThenByDescending, Reverse)

            //var people = new List<Person>
            //{
            //    new Person { Name = "Alice", Age = 30 },
            //    new Person { Name = "Bob", Age = 25 },
            //    new Person { Name = "Bob", Age = 20 },
            //    new Person { Name = "Charlie", Age = 30 },
            //    new Person { Name = "David", Age = 35 }
            //};

            //var sortedPeople = people
            //    .OrderBy(p => p.Name)               // Primary sort by Name (ascending)
            //    .ThenByDescending(p => p.Age)       // Secondary sort by Age (descending)
            //    .Reverse();                         // Reverse the entire sorted sequence
            ////sortedPeople = from person in people
            ////               orderby person.Name, person.Age descending
            ////               select person;

            //foreach (var person in sortedPeople)
            //{
            //    Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
            //}

            // ----------------------------------------------

            // Quantifiers (Any, All, Contains)

            //var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //var resultOfAll = numbers.All(n => n > 5); // True if all numbers are greater than 5
            //var resultOfAny = numbers.Any(n => n > 5); // True if any number is greater than 5
            //var resultOfContains = numbers.Contains(5); // True if any number equals 5
            //Console.WriteLine($"All > 5 ? {resultOfAll}");
            //Console.WriteLine($"Any > 5 ? {resultOfAny}");
            //Console.WriteLine($"Contains 5 ? {resultOfContains}");

            // ----------------------------------------------

            // Partitioning (Skip, SkipLast, SkipWhile, Take, TakeLast, TakeWhile, Chunk)

            var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //var result = numbers.Skip(3);
            //var result = numbers.SkipLast(3);
            //var result = numbers.SkipWhile(n => n <= 3);
            //var result = numbers.Take(3);
            //var result = numbers.TakeLast(3);
            //var result = numbers.TakeWhile(n => n <= 3);

            //foreach (var number in result)
            //{
            //    Console.WriteLine(number);
            //}

            var chunks = numbers.Chunk(3);
            foreach (var chunk in chunks)
            {
                foreach (var number in chunk)
                {
                    Console.WriteLine(number);
                }
                Console.WriteLine("----------");
            }
        }
    }

    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
