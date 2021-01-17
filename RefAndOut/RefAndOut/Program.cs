using System;

namespace RefAndOut
{
    class Program
    {
        static void Main(string[] args)
        {
            int r = 15;
            double result = CircleSquare(r);

            MultiplyResultByTwo(out result);
            Console.WriteLine(result);
        }

        // ref needs to be initialized before function execution
        // out needs to be initialized before usage

        //static void CircleSquare(int r, ref double result)  /*******ERROR - NO INITIALIZATION********/
        //{
        //    result = 2 * Math.PI* Math.Pow(r, 2);
        //}

        //static void CircleSquare(out double result, int r = 15) // working, because we don't have to use unitialized variable
        //{
        //    result = 2 * Math.PI * Math.Pow(r, 2);
        //}

        static void MultiplyResultByTwo(out double result) // 
        {
            result = 0; // Won't work without this line
            result *= 2;
        }

        static double CircleSquare(int r = 15)
        {
            return 2 * Math.PI * Math.Pow(r, 2);
        }
    }
}
