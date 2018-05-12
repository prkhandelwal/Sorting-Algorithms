using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort
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

            //Selection sort
            for (int i = 0; i < array.Length; i++)
            {
                int sindex = i;
                for (int j = i; j < array.Length; j++)
                {
                    if (array[j] < array[sindex])
                    {
                        sindex = j;
                    }
                }
                int temp = array[i];
                array[i] = array[sindex];
                array[sindex] = temp;
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
