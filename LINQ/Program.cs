using System.Collections;
using System.Linq.Expressions;
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
            // Element Operations (ElementAt, ElementAtOrDefault, First, FirstOrDefault, Last, LastOrDefault, Single, SingleOrDefault)
            // Sequence Equality (SequenceEqual)
            // Concatenation (Concat)
            // Aggregation (Aggregate, AggregateBy, Count, LongCount, CountBy, Max, MaxBy, Min, MinBy, Sum, Average)
            // Expression Trees

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
            //var allSkills = employees.SelectMany(e => e.Skills);
            //// SelectMany flattens the list of skills from all employees (works like the expand operator in JavaScript)
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

            // Element Operations (ElementAt, ElementAtOrDefault, First, FirstOrDefault, Last, LastOrDefault, Single, SingleOrDefault)

            //var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 7 };

            //var elementAt2 = numbers.ElementAt(2); // 3
            ////var elementAt10 = numbers.ElementAt(10); // argument out of range exception
            //var elementAtOrDefault10 = numbers.ElementAtOrDefault(10); // 0 (default for int)
            //Console.WriteLine($"element at 2: {elementAt2}");
            //Console.WriteLine($"element at 10 or default: {elementAtOrDefault10}");
            //Console.WriteLine("-----------------");

            //var firstElementGreaterThan2 = numbers.First(e => e > 2); // 3
            ////var firstElementGreaterThan10 = numbers.First(e => e > 10); // invalid operation exception
            //var firstElementGreaterThanOrDefault10 = numbers.FirstOrDefault(e => e > 10); // 0 (default for int)
            //Console.WriteLine($"first element greater than 2: {firstElementGreaterThan2}");
            //Console.WriteLine($"first element greater than 10 or default: {firstElementGreaterThanOrDefault10}");
            //Console.WriteLine("-----------------");

            //var lastElementLessThan6 = numbers.Last(e => e < 6); // 5
            ////var lastElementLessThanZero = numbers.Last(e => e < 0); // invalid operation exception
            //var lastElementLessThanOrDefaultZero = numbers.LastOrDefault(e => e < 0); // 0 (default for int)
            //Console.WriteLine($"last element less than 6: {lastElementLessThan6}");
            //Console.WriteLine($"last element less than 0 or default: {lastElementLessThanOrDefaultZero}");
            //Console.WriteLine("-----------------");

            //var singleElementEquals4 = numbers.Single(e => e == 4); // 4
            ////var singleElementEquals7 = numbers.Single(e => e == 7); // invalid operation exception
            ////var singleElementOrDefaultEquals7 = numbers.SingleOrDefault(e => e == 7); // invalid operation exception
            ////var singleElementEquals10 = numbers.Single(e => e == 10); // invalid operation exception
            //var singleElementOrDefaultEquals10 = numbers.SingleOrDefault(e => e == 10); // 0 (default for int)
            //Console.WriteLine($"single element equals 4: {singleElementEquals4}");
            //Console.WriteLine($"single element equals 10 or default: {singleElementOrDefaultEquals10}");

            // ----------------------------------------------

            // Sequence Equality (SequenceEqual)

            //var department1 = new Department { Id = 1, Title = "HR" };
            //var department2 = new Department { Id = 2, Title = "IT" };
            //var department3 = new Department { Id = 3, Title = "Finance" };

            //var sequence0 = new List<Department> { department1, department2, department3 };
            //var sequence1 = sequence0;
            //var sequence2 = sequence0;
            //Console.WriteLine($"sequence 1 equals sequence 2 ? {sequence1.SequenceEqual(sequence2)}");
            //// True because both reference the same object

            //var sequence3 = new List<Department> { department1, department2, department3 };
            //var sequence4 = new List<Department> { department1, department2, department3 };
            //Console.WriteLine($"sequence 3 equals sequence 4 ? {sequence3.SequenceEqual(sequence4)}");
            //// True because both have the same references in the same order

            //var sequence5 = new List<Department> {
            //    new Department { Id = 1, Title = "HR" },
            //    new Department { Id = 2, Title = "IT" },
            //    new Department { Id = 3, Title = "Finance" }
            //};
            //var sequence6 = new List<Department> {
            //    new Department { Id = 1, Title = "HR" },
            //    new Department { Id = 2, Title = "IT" },
            //    new Department { Id = 3, Title = "Finance" }
            //};
            //Console.WriteLine($"sequence 5 equals sequence 6 ? {sequence5.SequenceEqual(sequence6)}");
            //// False because both have different references even though the values are the same. To make it true,
            //// we have overridden the Equals method in the Department class to compare values instead of references.

            // ----------------------------------------------

            // Concatenation (Concat)

            //var person1 = new Person { Name = "Alice", Age = 30, Job = "Teacher" };
            //var person2 = new Person { Name = "Bob", Age = 25, Job = "Engineer" };
            //var person3 = new Person { Name = "Charlie", Age = 20, Job = "Doctor" };
            //var person4 = new Person { Name = "David", Age = 35, Job = "Doctor" };

            //var firstSequence = new List<Person> { person1, person2 };
            //var secondSequence = new List<Person> { person3, person4 };

            //var concatenatedSequence = firstSequence.Concat(secondSequence);
            //foreach (var person in concatenatedSequence)
            //{
            //    Console.WriteLine(person.Name);
            //}
            //Console.WriteLine("-----------------");

            ////var concatenatedSequence2 = new[] { firstSequence, secondSequence };    // Array of sequences (IEnumerable<IEnumerable<Person>>)
            //var concatenatedSequence2 = new[] { firstSequence, secondSequence }.SelectMany(s => s);
            //// SelectMany flattens the inner sequences (works like the expand operator in JavaScript)
            //foreach (var person in concatenatedSequence2)
            //{
            //    Console.WriteLine(person.Name);
            //}

            // ----------------------------------------------

            // Aggregation (Aggregate, AggregateBy, Count, LongCount, CountBy, Max, MaxBy, Min, MinBy, Sum, Average)

            //var numbers = new List<int> { 1, 2, 3, 4, 5 };

            //var employees = new List<Employee>
            //{
            //    new Employee { Name = "Alice", DepartmentId = 1, Salary = 6000, Skills = { "C#", "SQL"} },
            //    new Employee { Name = "Bob", DepartmentId = 2, Salary = 6000, Skills = { "HTML", "CSS", "JavaScript", "Node.js", "Express.js"} },
            //    new Employee { Name = "David", DepartmentId = 2, Salary = 7000, Skills = { ".NET", "Azure", "APIs", "Scripting"} },
            //    new Employee { Name = "Charlie", DepartmentId = 3, Salary = 5000, Skills = { "PHP", "Laravel", "SOLID"} },
            //    new Employee { Name = "Joe", DepartmentId = 3, Salary = 7000, Skills = { "Python", "Django", "Machine Learning", "Data Science", "AI"} }
            //};

            //// Aggregate
            //var sumAggregate = numbers.Aggregate(0, (last, current) => last + current);
            //Console.WriteLine($"Aggregate Sum: {sumAggregate}");

            //var namesConcatenated = employees.Aggregate("", (emp1, emp2) => $"{emp1}, {emp2.Name}", e => e).TrimStart(", ");
            //Console.WriteLine($"Names Concatenated: {namesConcatenated}");

            //// AggregateBy acts like: GroupBy => Aggregate each group
            //var maxSalaryPerDepartment = employees.AggregateBy(emp => emp.DepartmentId,
            //    employees[0].Salary, (sal, emp) => sal < emp.Salary ? emp.Salary : sal);
            //foreach (var kvp in maxSalaryPerDepartment)
            //{
            //    Console.WriteLine($"Department: {kvp.Key}, Max Salary: {kvp.Value}");
            //}

            //var employeesPerSalary = employees.AggregateBy(emp => emp.Salary, 0, (count, emp) => count + 1);
            //foreach (var kvp in employeesPerSalary)
            //{
            //    Console.WriteLine($"Salary: {kvp.Key}, Number of Employees: {kvp.Value}");
            //}
            //Console.WriteLine("-----------------");

            //// Count, LongCount, CountBy
            //var totalEmployees = employees.Count();
            //Console.WriteLine($"Total Employees: {totalEmployees}");

            //var totalEmployeesLong = employees.LongCount();     // Same as Count but used for large collections
            //Console.WriteLine($"Total Employees (LongCount): {totalEmployeesLong}");

            //var totalEmployeesWithSalaryAbove6000 = employees.Count(e => e.Salary > 6000);  // Count with predicate
            //Console.WriteLine($"Total Employees with Salary > 6000: {totalEmployeesWithSalaryAbove6000}");

            //var countBySalary = employees.CountBy(e => e.Salary);   // CountBy acts like: GroupBy => Count in each group
            //foreach (var kvp in countBySalary)
            //{
            //    Console.WriteLine($"Salary: {kvp.Key}, Count: {kvp.Value}");
            //}
            //Console.WriteLine("-----------------");

            //// Max, MaxBy, Min, MinBy
            //var maxSalary = employees.Max(e => e.Salary);
            //Console.WriteLine($"Max Salary: {maxSalary}");

            //var employeeWithMaxSalary = employees.MaxBy(e => e.Salary);
            //Console.WriteLine($"Employee with Max Salary: {employeeWithMaxSalary.Name}, Salary: {employeeWithMaxSalary.Salary}");

            //var minSalary = employees.Min(e => e.Salary);
            //Console.WriteLine($"Min Salary: {minSalary}");

            //var employeeWithMinSalary = employees.MinBy(e => e.Salary);
            //Console.WriteLine($"Employee with Min Salary: {employeeWithMinSalary.Name}, Salary: {employeeWithMinSalary.Salary}");
            //Console.WriteLine("-----------------");

            //// Sum, Average
            //var totalSalary = employees.Sum(e => e.Salary);
            //Console.WriteLine($"Total Salary: {totalSalary}");

            //var averageSalary = employees.Average(e => e.Salary);
            //Console.WriteLine($"Average Salary: {averageSalary}");

            // ----------------------------------------------

            // Expression Trees

            //// Taking leaves from Expression Trees
            //Expression<Func<int, bool>> myExpression = num => num > 5;

            //ParameterExpression parameterExpression = myExpression.Parameters[0]; // 'num' parameter

            //BinaryExpression bodyExpression = (BinaryExpression)myExpression.Body;  // 'num > 5' body
            //ConstantExpression constantExpression = (ConstantExpression)bodyExpression.Right;   // '5' constant

            //Console.WriteLine($"My Expression: " +
            //    $"{parameterExpression.Name} => {parameterExpression.Name} {bodyExpression.NodeType} {constantExpression.Value}");

            //// Constructing expression trees manually
            //// Expression: num => num % 2 == 0
            //ParameterExpression numEx = Expression.Parameter(typeof(int), "num");   // 'num' parameter
            //ConstantExpression twoEx = Expression.Constant(2, typeof(int));         // constant '2'
            //ConstantExpression zeroEx = Expression.Constant(0, typeof(int));        // constant '0'

            //BinaryExpression modEx = Expression.Modulo(numEx, twoEx);   // num % 2
            //BinaryExpression equalEx = Expression.Equal(modEx, zeroEx); // (num % 2) == 0

            //Expression<Func<int, bool>> isEvenExpression = Expression.Lambda<Func<int, bool>>(equalEx, numEx);

            //var isEvenFunc = isEvenExpression.Compile();
            //Console.WriteLine($"Is 4 even? {isEvenFunc(4)}");
            //Console.WriteLine($"Is 7 even? {isEvenFunc(7)}");

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
        public double Salary { get; set; }
    }

    public class Department
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public override bool Equals(object? obj)
        {
            if (obj is Department other)
            {
                return this.Id == other.Id && this.Title == other.Title;
            }
            return false;
        }
    }
}
