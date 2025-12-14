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


            // Delegates

            //Console.Write("Enter a sentence :");
            //string mySentence = Console.ReadLine() ?? "";

            //DelegateStringMethods dlgMthds = new DelegateStringMethods();
            //StringProcessor processor = dlgMthds.UppercaseString;
            //processor += dlgMthds.ReverseString;
            //processor += dlgMthds.ReplaceSpacesWithHyphens;
            //processor(mySentence);


            // Events

            //DownloadManager downloadManager = new DownloadManager();
            //downloadManager.DownloadProgressChanged += DownloadManager_DownloadProgressChanged;
            //downloadManager.DownloadCompleted += DownloadManager_DownloadCompleted;
            //downloadManager.StartDownload();


            // MultiThreading

            //var thread1 = new Thread(Thread1);
            //var thread2 = new Thread(Thread2);
            //thread1.Start();
            //thread2.Start();


            // Task-based Asynchronous Pattern (TAP) - Async/Await

            //var cts = new CancellationTokenSource();
            //PerformAsyncOperation(cts);
            //Console.ReadLine();


            // Enumerables
        }

        // Events

        //private static void DownloadManager_DownloadProgressChanged(object? sender, DownloadEventArgs e)
        //{
        //    Console.WriteLine($"Download at {e.Percentage}%");
        //}

        //private static void DownloadManager_DownloadCompleted()
        //{
        //    Console.WriteLine($"Download Completed Successfully");
        //}


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
    }
}