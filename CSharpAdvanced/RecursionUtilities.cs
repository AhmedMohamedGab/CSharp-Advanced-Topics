using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpAdvanced
{
    internal static class RecursionUtilities
    {
        public static void ListContents(string path)
        {
            if (!Directory.Exists(path))
            {
                Console.WriteLine("The specified directory does not exist.");
                return;
            }

            int level = 0;

            static void ListContentsRecursive(string path, int level)
            {
                foreach (var directory in Directory.GetDirectories(path))
                {
                    Console.WriteLine($"{new string(' ', level)}/ {Path.GetFileName(directory)}");
                    ListContentsRecursive(directory, level + 1);
                }
                foreach (var file in Directory.GetFiles(path))
                {
                    Console.WriteLine($"{new string(' ', level)}- {Path.GetFileName(file)}");
                }
            }

            ListContentsRecursive(path, level);
        }

        public static int[] MergeSort(int[] array)
        {
            if (array.Length <= 1)
            {
                return array;
            }
            int mid = array.Length / 2;
            int[] left = new int[mid];
            int[] right = new int[array.Length - mid];
            Array.Copy(array, 0, left, 0, mid);
            Array.Copy(array, mid, right, 0, array.Length - mid);
            left = MergeSort(left);
            right = MergeSort(right);
            return Merge(left, right);
        }

        private static int[] Merge(int[] left, int[] right)
        {
            int[] result = new int[left.Length + right.Length];
            int i = 0, j = 0, k = 0;
            while (i < left.Length && j < right.Length)
            {
                if (left[i] <= right[j])
                {
                    result[k++] = left[i++];
                }
                else
                {
                    result[k++] = right[j++];
                }
            }
            while (i < left.Length)
            {
                result[k++] = left[i++];
            }
            while (j < right.Length)
            {
                result[k++] = right[j++];
            }
            return result;
        }
    }
}
