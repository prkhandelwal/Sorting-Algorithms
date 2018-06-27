using System;
using System.Collections.Generic;
using System.Linq;

namespace TestConsole
{
    class Program
    {
        static string hackerrankInString(string s)
        {
            List<char> list = s.ToList();
            string str = "hackerrank";
            List<char> val = str.ToList();
            foreach (char item in val)
            {
                if (list.Remove(item) == false)
                {
                    return "NO";
                }
            }
            return "YES";

        }


        static void Main(string[] args)
        {
            int q = Convert.ToInt32(Console.ReadLine());

            for (int qItr = 0; qItr < q; qItr++)
            {
                string s = Console.ReadLine();

                string result = hackerrankInString(s);

                Console.WriteLine(result);
            }
        }
    }
}
