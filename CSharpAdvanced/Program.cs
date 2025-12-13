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
    }
}