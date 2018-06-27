using System;
using System.Collections.Generic;
using System.Linq;

namespace MergeSort
{
    class Program
    {
        private static List<int> MergeSort(List<int> arr)
        {
            if(arr.Count == 1)
            {
                return arr;
            }
            List<int> left = new List<int>();
            List<int> right = new List<int>();

            int middle = arr.Count / 2;

            for (int i = 0; i < arr.Count; i++)
            {
                if(i<middle)
                {
                    left.Add(arr[i]);
                }
                else
                {
                    right.Add(arr[i]);
                }
            }


            left = MergeSort(left);
            right = MergeSort(right);

            return Merge(left, right);
        }

        private static List<int> Merge(List<int> left, List<int> right)
        {
            List<int> result = new List<int>();

            while (left.Count > 0 || right.Count > 0)
            {
                if(left.Count > 0 && right.Count > 0)
                {
                    if(left.First() <= right.First())
                    {
                        result.Add(left.First());
                        left.Remove(left.First());
                    }
                    else
                    {
                        result.Add(right.First());
                        right.Remove(right.First());
                    }
                }

                else if(left.Count > 0)
                {
                    result.Add(left.First());
                    left.Remove(left.First());
                }
                else if(right.Count > 0)
                {
                    result.Add(right.First());
                    right.Remove(right.First());
                }
            }
            return result;
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of inputs :");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the sumbers to sort :");

            List<int> arr = (from item in Console.ReadLine().Split(' ')
                         select int.Parse(item)).ToList();

            List<int> result = MergeSort(arr);

            Console.WriteLine("Sorted array is");
            for(int i = 0; i<arr.Count; i++)
            {
                Console.Write(result[i] + " ");
            }

            Console.ReadLine();
        }
    }
}
