using System;
using System.Threading;

namespace MultiplesOf3Or5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 0; i < 1000; i++)
            {
                if (MultiplesOf3Or5(i))
                    sum += i;
            }

            Console.WriteLine(sum);
            Thread.Sleep(-1);

        }
        static bool MultiplesOf3Or5(int number)
        {
            return number % 3 == 0 || number % 5 == 0;
        }
    }
}
