using CSharpAdvanced;
using System.Threading;

public delegate void StringProcessor(string myString);

namespace CSharpAdvanced
{
    class Program
    {
        static void Main(string[] args)
        {
            // Extension Methods

            //Console.Write("Enter a string to reverse: ");
            //string myString = Console.ReadLine() ?? "";
            //Console.WriteLine(myString.ReverseString());

            //Console.Write("Enter a sentence to capitalize all words: ");
            //string mySentence = Console.ReadLine() ?? "";
            //Console.WriteLine(mySentence.CapitalizeAllWords());

            // ----------------------------------------------

            // Recursion

            //Console.Write("Enter a directory path to find all of its contents: ");
            //string path = Console.ReadLine() ?? "";
            //RecursionUtilities.ListContents(path);

            //var unsortedArray = new int[] { 5, 3, 8, 1, 2 };
            //var sortedArray = RecursionUtilities.MergeSort(unsortedArray);
            //Console.Write("Unsorted Array:");
            //foreach (var item in unsortedArray) Console.Write(" " + item);
            //Console.Write("\nSorted Array:");
            //foreach (var item in sortedArray) Console.Write(" " + item);

            // ----------------------------------------------

            // Delegates

            //Console.Write("Enter a sentence :");
            //string mySentence = Console.ReadLine() ?? "";

            //DelegateStringMethods dlgMthds = new DelegateStringMethods();
            //StringProcessor processor = dlgMthds.UppercaseString;
            //processor += dlgMthds.ReverseString;
            //processor += dlgMthds.ReplaceSpacesWithHyphens;
            //processor(mySentence);

            // ----------------------------------------------

            // Events

            //DownloadManager downloadManager = new DownloadManager();
            //downloadManager.DownloadProgressChanged += DownloadManager_DownloadProgressChanged;
            //downloadManager.DownloadCompleted += DownloadManager_DownloadCompleted;
            //downloadManager.StartDownload();

            // ----------------------------------------------

            // MultiThreading

            //var thread1 = new Thread(Thread1);
            //var thread2 = new Thread(Thread2);
            //thread1.Start();
            //thread2.Start();

            // ----------------------------------------------

            // Task-based Asynchronous Pattern (TAP) - Async/Await

            //var cts = new CancellationTokenSource();
            //PerformAsyncOperation(cts);
            //Console.ReadLine();

            // ----------------------------------------------

            // Enumerables

            //var books = new EnumerableBooks();
            //books.AddBookItem("The Great Gatsby", "F. Scott Fitzgerald", 10.99);
            //books.AddBookItem("To Kill a Mockingbird", "Harper Lee", 7.99);
            //books.AddBookItem("1984", "George Orwell", 8.99);
            //// Enumerator
            //foreach (var book in books)
            //{
            //    Console.WriteLine($"{book.Title} by {book.Author} - ${book.Price}");
            //}
            //Console.WriteLine("\n");
            //// Indexer
            //for (int i = 0; i < books.Count(); i++)
            //{
            //    Console.WriteLine($"{books[i].Title} by {books[i].Author} - ${books[i].Price}");
            //}
            //Console.WriteLine("\n");

            //var myBook = books["The Great Gatsby"];
            //Console.WriteLine($"Indexer by Title: {myBook.Title} by {myBook.Author} - ${myBook.Price}");

            // ----------------------------------------------

            // Generics

            //var genCalc = new GenericCalculator<int>();
            //Console.WriteLine(genCalc.Add(10, 5));
            //Console.WriteLine(genCalc.Subtract(10, 5));
            //Console.WriteLine(genCalc.Multiply(10, 5));
            //Console.WriteLine(genCalc.Divide(10, 5));

            // ----------------------------------------------

            // Operator Overloading

            //Point p1 = new Point(10, 20);
            //Point p2 = new Point(40, 80);
            //// Arithmetic Operators
            //Point p3 = p1 + p2;
            //Console.WriteLine($"p1 + p2 = ({p3.XCoord}, {p3.YCoord})");
            //p3 = p2 - p1;
            //Console.WriteLine($"p2 - p1 = ({p3.XCoord}, {p3.YCoord})\n");
            //// Comparison Operators
            //Console.WriteLine($"p1 == p2 ? {p1 == p2}");
            //Console.WriteLine($"p1 != p2 ? {p1 != p2}\n");
            //// Conversion Operators
            //Point p4 = (15, 25); // Implicit conversion from (double, double) to Point
            //Console.WriteLine($"p4.XCoord = {p4.XCoord}, p4.YCoord = {p4.YCoord}");
            //(double, double) coords = p4; // Implicit conversion from Point to (double, double)
            //Console.WriteLine($"xCoord = {coords.Item1}, yCoord = {coords.Item2}\n");

            // ----------------------------------------------

            // Object Method Overrides

            //Point p5 = new Point(10, 20);
            //Point p6 = new Point(10, 20);
            //// Equals Override
            //Console.WriteLine($"p2.Equals(p1) ? {p5.Equals(p6)}\n");
            //// ToString Override
            //Console.WriteLine($"Point p5: {p5}\n");
            //// GetHashCode Override
            //Console.WriteLine($"Point p5 HashCode: {p5.GetHashCode()}");
            //Console.WriteLine($"Point p6 HashCode: {p6.GetHashCode()}");

            // ----------------------------------------------

            // Records

            ////var person1 = new PersonRecord { FirstName = "John", LastName = "Doe" };    // Standard record initialization
            //var person1 = new PersonRecord("John", "Doe");    // Positional record initialization
            //var person2 = new PersonRecord("John", "Doe");
            //// Records Already Overrides Equals, GetHashCode, and ToString methods by default
            //Console.WriteLine($"person2.Equals(person1) ? {person2.Equals(person1)}\n");
            //Console.WriteLine($"person1: {person1}\n");
            //Console.WriteLine($"person1 HashCode: {person1.GetHashCode()}");
            //Console.WriteLine($"person2 HashCode: {person2.GetHashCode()}\n");
            //// Deconstruction of Positional Records
            //var (firstName, lastName) = person1;
            //Console.WriteLine($"First Name: {firstName}, Last Name: {lastName}\n");
            //// Copy and Modify with 'with' Expression
            //var person3 = person1 with { FirstName = "Simon" };
            //Console.WriteLine($"person3: {person3}");
        }

        // ----------------------------------------------

        // Events

        //private static void DownloadManager_DownloadProgressChanged(object? sender, DownloadEventArgs e)
        //{
        //    Console.WriteLine($"Download at {e.Percentage}%");
        //}

        //private static void DownloadManager_DownloadCompleted()
        //{
        //    Console.WriteLine($"Download Completed Successfully");
        //}

        // ----------------------------------------------

        // MultiThreading

        //private static object _lockObject = new();
        //private static void Thread1()
        //{
        //    for (int i = 1; i <= 5; i++)
        //    {
        //        lock (_lockObject)
        //        {
        //            Console.ForegroundColor = ConsoleColor.Green;
        //            Console.WriteLine($"Thread 1 - Count {i}");
        //            Thread.Sleep(500);
        //            Console.ForegroundColor = ConsoleColor.White;
        //        }
        //    }
        //}

        //private static void Thread2()
        //{
        //    for (int i = 6; i <= 10; i++)
        //    {
        //        lock (_lockObject)
        //        {
        //            Console.ForegroundColor = ConsoleColor.Red;
        //            Console.WriteLine($"Thread 2 - Count {i}");
        //            Thread.Sleep(500);
        //        }
        //    }
        //}

        // ----------------------------------------------

        // Task-based Asynchronous Pattern (TAP) - Async/Await

        //private static async void PerformAsyncOperation(CancellationTokenSource cts)
        //{
        //    var operationTask = LongOperation(cts.Token);
        //    //cts.Cancel();
        //    try
        //    {
        //        Console.WriteLine("Starting async operation...");
        //        Console.WriteLine($"Async task status: {operationTask.Status}");
        //        await operationTask;
        //        Console.WriteLine("Async operation completed.");
        //        Console.WriteLine($"Async task status: {operationTask.Status}");
        //    }
        //    catch (OperationCanceledException)
        //    {
        //        Console.WriteLine("Async operation was canceled.");
        //        Console.WriteLine($"Async task status: {operationTask.Status}");
        //    }
        //}

        //private static async Task LongOperation(CancellationToken token)
        //{
        //    await Task.Delay(50);
        //    for (int i = 1; i <= 5; i++)
        //    {
        //        token.ThrowIfCancellationRequested();

        //        Console.WriteLine($"Thread 1 - Count {i}");
        //        Thread.Sleep(500);
        //    }
        //}

        // ----------------------------------------------

        // Records

        // Avoid using complex types like classes or arrays as properties in records
        // to maintain immutability ( = avoid shallow immutability) and value-based equality.

        //public record PersonRecord(string FirstName, string LastName);  // Positional record

        //public record PersonRecord  // Standard record
        //{
        //    public string FirstName { get; set; }
        //    public string LastName { get; set; }
        //}
    }
}