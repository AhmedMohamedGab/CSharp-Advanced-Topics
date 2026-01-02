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
            // Projection and Filtering (Select, Where, OfType, SelectMany, Zip)
            // Sorting (OrderBy, OrderByDescending, ThenBy, ThenByDescending, Reverse)
            // Quantifiers (Any, All, Contains)
            // Partitioning (Skip, SkipLast, SkipWhile, Take, TakeLast, TakeWhile, Chunk)
            // Set Operations (Distinct, DistinctBy, Except, ExceptBy, Intersect, IntersectBy, Union, UnionBy)
            // Joins (Join, LeftJoin, RightJoin, GroupJoin)
            // Grouping (GroupBy, ToLookup)
            // Generating Sequences (Range, Repeat, Empty, DefaultIfEmpty)

            // ----------------------------------------------

            // Projection and Filtering (Select, Where, OfType, SelectMany, Zip)

            //// Select, Where
            //var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            ////var result = from number in numbers where number > 5 select number; // LINQ Query Syntax
            //var result = numbers.Where(n => n > 5); // LINQ Method Syntax (Preferred)
            //// Note: result variable stores the query, not the result of the query which is called deferred execution.
            //// Deferred execution means that the query is not executed until you iterate over the result.
            //foreach (var number in result)  // Query Execution
            //{
            //    Console.WriteLine(number);
            //}
            //Console.WriteLine("----------");
            //numbers.AddRange(new int[] { 11, 12, 13, 14, 15 }); // Modifying the source collection
            //foreach (var number in result)  // Query Execution again reflects the changes in the source collection
            //{
            //    Console.WriteLine(number);
            //}
            //// In order to execute the query immediately and store the result, use ToList() or ToArray()

            // -----------------------

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

            // -----------------------

            //// Example of SelectMany
            //var employees = new List<Employee>
            //{
            //    new Employee { Name = "Alice", Skills = new List<string> { "C#", "SQL", "Azure" } },
            //    new Employee { Name = "Bob", Skills = new List<string> { "Java", "AWS" } },
            //    new Employee { Name = "Charlie", Skills = new List<string> { "Python", "Django", "Docker" } }
            //};
            //var allSkills = employees.SelectMany(e => e.Skills); // Flattens the list of skills from all employees
            //foreach (var skill in allSkills)
            //{
            //    Console.WriteLine(skill);
            //}

            // -----------------------

            //// Example of Zip
            //var colorNames = new List<string> { "Red", "Green", "Blue" };
            //var hexCodes = new List<string> { "FF0000", "00FF00", "0000FF" };
            //var colorHexPairs = colorNames.Zip(hexCodes, (name, hex) => new { Name = name, Hex = hex });
            //foreach (var pair in colorHexPairs)
            //{
            //    Console.WriteLine($"Color: {pair.Name}, Hex: {pair.Hex}");
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

            //var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            ////var result = numbers.Skip(3);
            ////var result = numbers.SkipLast(3);
            ////var result = numbers.SkipWhile(n => n <= 3);
            ////var result = numbers.Take(3);
            ////var result = numbers.TakeLast(3);
            ////var result = numbers.TakeWhile(n => n <= 3);

            ////foreach (var number in result)
            ////{
            ////    Console.WriteLine(number);
            ////}

            //var chunks = numbers.Chunk(3);
            //foreach (var chunk in chunks)
            //{
            //    foreach (var number in chunk)
            //    {
            //        Console.WriteLine(number);
            //    }
            //    Console.WriteLine("----------");
            //}

            // ----------------------------------------------

            // Set Operations (Distinct, DistinctBy, Except, ExceptBy, Intersect, IntersectBy, Union, UnionBy)

            //var numbers = new List<int> { 1, 1, 2, 2, 3, 3, 4, 5, 6, 7, 8, 9, 10 };
            //var anotherNumbers = new List<int> { -1, 0, 1, 2, 3, 4, 5, 6, 7 };

            ////var result = numbers.Distinct();
            ////var result = numbers.Except(anotherNumbers);
            ////var result = numbers.Intersect(anotherNumbers);
            //var result = numbers.Union(anotherNumbers).OrderBy(n => n);

            //foreach (var number in result)
            //{
            //    Console.WriteLine(number);
            //}

            // -----------------------

            //var people = new List<Person>
            //{
            //    new Person { Name = "Alice", Age = 30, Job = "Teacher" },
            //    new Person { Name = "Bob", Age = 25, Job = "Engineer" },
            //    new Person { Name = "Charlie", Age = 20, Job = "Doctor" },
            //    new Person { Name = "David", Age = 35, Job = "Doctor" },
            //    new Person { Name = "Kelly", Age = 37, Job = "Teacher" },
            //    new Person { Name = "John", Age = 37, Job = "Dentist" }
            //};
            //var anotherPeople = new List<Person>
            //{
            //    new Person { Name = "Jack", Age = 41, Job = "Lawyer" },
            //    new Person { Name = "Barns", Age = 25, Job = "Officer" },
            //    new Person { Name = "Kelly", Age = 27, Job = "Teacher" },
            //    new Person { Name = "Alice", Age = 35, Job = "Doctor" },
            //    new Person { Name = "John", Age = 32, Job = "Security" }
            //};

            //var resultOfDistinctBy = people.DistinctBy(p => p.Job);
            //foreach (var person in resultOfDistinctBy)
            //{
            //    Console.WriteLine($"Job: {person.Job}");
            //}
            //Console.WriteLine("-----------------");

            //var resultOfExceptBy = people.ExceptBy(anotherPeople.Select(p => p.Name), p => p.Name);
            //foreach (var person in resultOfExceptBy)
            //{
            //    Console.WriteLine($"Name: {person.Name}");
            //}
            //Console.WriteLine("-----------------");

            //var resultOfIntersectBy = people.IntersectBy(anotherPeople.Select(p => p.Name), p => p.Name);
            //foreach (var person in resultOfIntersectBy)
            //{
            //    Console.WriteLine($"Name: {person.Name}");
            //}
            //Console.WriteLine("-----------------");

            //var resultOfUnionBy = people.UnionBy(anotherPeople, p => p.Job);
            //foreach (var person in resultOfUnionBy)
            //{
            //    Console.WriteLine($"Job: {person.Job}");
            //}

            // ----------------------------------------------

            // Joins (Join, LeftJoin, RightJoin, GroupJoin)

            //var employees = new List<Employee>
            //{
            //    new Employee { Name = "Alice", DepartmentId = 1 },
            //    new Employee { Name = "Bob", DepartmentId = 2 },
            //    new Employee { Name = "Charlie", DepartmentId = 1 },
            //    new Employee { Name = "David", DepartmentId = 3 },
            //    new Employee { Name = "John", DepartmentId = 0 }
            //};
            //var departments = new List<Department>
            //{
            //    new Department { Id = 1, Title = "HR" },
            //    new Department { Id = 2, Title = "IT" },
            //    new Department { Id = 3, Title = "Finance" },
            //    new Department { Id = 4, Title = "Development" }
            //};

            //var innerJoinedData = employees.Join(
            //    departments,
            //    emp => emp.DepartmentId,
            //    dept => dept.Id,
            //    (emp, dept) => new { EmployeeName = emp.Name, DepartmentTitle = dept.Title });

            //foreach (var item in innerJoinedData)
            //{
            //    Console.WriteLine($"Employee: {item.EmployeeName}, Department: {item.DepartmentTitle}");
            //}
            //Console.WriteLine("-----------------");

            //var leftJoinedData = employees.LeftJoin(
            //    departments,
            //    emp => emp.DepartmentId,
            //    dept => dept.Id,
            //    (emp, dept) => new
            //    {
            //        EmployeeName = emp.Name,
            //        DepartmentTitle = dept == null ? "No Departments" : dept.Title
            //    });

            //foreach (var item in leftJoinedData)
            //{
            //    Console.WriteLine($"Employee: {item.EmployeeName}, Department: {item.DepartmentTitle}");
            //}
            //Console.WriteLine("-----------------");

            //var rightJoinedData = employees.RightJoin(
            //    departments,
            //    emp => emp.DepartmentId,
            //    dept => dept.Id,
            //    (emp, dept) => new
            //    {
            //        EmployeeName = emp == null ? "No Employees" : emp.Name,
            //        DepartmentTitle = dept.Title
            //    });

            //foreach (var item in rightJoinedData)
            //{
            //    Console.WriteLine($"Employee: {item.EmployeeName}, Department: {item.DepartmentTitle}");
            //}
            //Console.WriteLine("-----------------");

            //var groupJoinedData = departments.GroupJoin(
            //    employees,
            //    dept => dept.Id,
            //    emp => emp.DepartmentId,
            //    (dept, emps) => new
            //    {
            //        DepartmentTitle = dept.Title,
            //        Employees = emps.Select(e => e.Name)
            //    });

            //foreach (var item in groupJoinedData)
            //{
            //    Console.WriteLine($"Department: {item.DepartmentTitle}");
            //    foreach (var empName in item.Employees)
            //    {
            //        Console.WriteLine($" - Employee: {empName}");
            //    }
            //}

            // ----------------------------------------------

            // Grouping (GroupBy, ToLookup)

            //var employees = new List<Employee>
            //{
            //    new Employee { Name = "Alice", DepartmentId = 1 },
            //    new Employee { Name = "Bob", DepartmentId = 2 },
            //    new Employee { Name = "Charlie", DepartmentId = 1 },
            //    new Employee { Name = "David", DepartmentId = 3 },
            //    new Employee { Name = "John", DepartmentId = 0 }
            //};
            //var departments = new List<Department>
            //{
            //    new Department { Id = 1, Title = "HR" },
            //    new Department { Id = 2, Title = "IT" },
            //    new Department { Id = 3, Title = "Finance" },
            //    new Department { Id = 4, Title = "Development" }
            //};

            //var groupedData = employees.Join(
            //    departments,
            //    e => e.DepartmentId,
            //    d => d.Id,
            //    (e, d) => new
            //    {
            //        EmployeeName = e.Name,
            //        DepartmentTitle = d.Title
            //    }).GroupBy(item => item.DepartmentTitle);

            //foreach (var group in groupedData)
            //{
            //    Console.WriteLine($"Department: {group.Key}");
            //    foreach (var item in group)
            //    {
            //        Console.WriteLine($" - Employee: {item.EmployeeName}");
            //    }
            //}
            //Console.WriteLine("-----------------");

            //var lookupData = employees.Join(
            //    departments,
            //    e => e.DepartmentId,
            //    d => d.Id,
            //    (e, d) => new
            //    {
            //        EmployeeName = e.Name,
            //        DepartmentTitle = d.Title
            //    }).ToLookup(item => item.DepartmentTitle);

            //foreach (var group in lookupData)
            //{
            //    Console.WriteLine($"Department: {group.Key}");
            //    foreach (var item in group)
            //    {
            //        Console.WriteLine($" - Employee: {item.EmployeeName}");
            //    }
            //}

            // ----------------------------------------------

            // Generating Sequences (Range, Repeat, Empty, DefaultIfEmpty)

            //var rangeNumbers = Enumerable.Range(1, 10); // Generates numbers from 1 to 10
            //Console.WriteLine("Range:");
            //foreach (var number in rangeNumbers)
            //{
            //    Console.WriteLine(number);
            //}
            //Console.WriteLine("-----------------");

            //var repeatValues = Enumerable.Repeat("Hello", 5); // Repeats "Hello" 5 times
            //Console.WriteLine("Repeat:");
            //foreach (var value in repeatValues)
            //{
            //    Console.WriteLine(value);
            //}
            //Console.WriteLine("-----------------");

            //var emptySequence = Enumerable.Empty<int>(); // Generates an empty sequence of integers
            //Console.WriteLine("Empty:");
            //foreach (var number in emptySequence)
            //{
            //    Console.WriteLine(number); // No output
            //}
            //Console.WriteLine("-----------------");

            //var numbers = new List<int> { 1, 2, 3 };
            ////var numbers = new List<int> { };
            //var defaultIfEmptySequence = numbers.DefaultIfEmpty(0); // If numbers is empty, returns a sequence with a single element 0
            //Console.WriteLine("DefaultIfEmpty:");
            //foreach (var number in defaultIfEmptySequence)
            //{
            //    Console.WriteLine(number);
            //}

            // ----------------------------------------------
        }
    }

    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Job { get; set; }
    }

    public class Employee
    {
        public string Name { get; set; }
        public int DepartmentId { get; set; }
        public List<string> Skills { get; set; } = new();
    }

    public class Department
    {
        public int Id { get; set; }
        public string Title { get; set; }
    }
}
