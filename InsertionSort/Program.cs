using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert the elements to sort: ");
            string[] k = (Console.ReadLine().Split(' '));
            int[] array = new int[k.Length];
            for (int i = 0; i < k.Length; i++)
            {
                array[i] = int.Parse(k[i]);
            }

            Console.WriteLine("Inserted  Array: ");

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();
            //Insertion Sort
            for (int i = 1; i < array.Length; i++)
            {
                int j = i;
                while (j > 0)
                {
                    if (array[j] < array[j - 1])
                    {
                        int temp = array[j - 1];
                        array[j - 1] = array[j];
                        array[j] = temp;
                        j--;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            stopwatch.Stop();

            Console.WriteLine("Time Taken" + stopwatch.Elapsed);

            Console.WriteLine("The sorted array is: ");

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.ReadKey();
        }
    }
}
