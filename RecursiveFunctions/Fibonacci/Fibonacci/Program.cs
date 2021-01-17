using System;
using System.Collections.Generic;

namespace Fibonacci
{
    class Program
    {
        static int count = 0;
        static Dictionary<int, int> keyValuePairs = new Dictionary<int, int>();
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int result = Fibonachi(2000);
            Console.WriteLine("result " + result + " count " + count);
        }

        static int Fibonachi(int n)
        {
            count++;
            if (n == 0)
            {
                return 0;
            }
            else if (n == 1)
            {
                return 1;
            }
            else
            {
                if (!keyValuePairs.ContainsKey(n))
                {
                    keyValuePairs.Add(n, Fibonachi(n - 1) + Fibonachi(n - 2));
                }

                return keyValuePairs[n];
            }
        }
    }
}
