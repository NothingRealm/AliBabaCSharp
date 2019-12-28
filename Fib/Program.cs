using System;
using System.Collections.Generic;
using System.Linq;

namespace Fib
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = 10.clac_fib();
            Console.WriteLine("--------Fibs--------");
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
            var sum = numbers.Sum();
            Console.WriteLine("--------Sum--------");
            Console.WriteLine(sum);
            var odd = numbers.Where(x => x % 2 != 0).ToArray();
            Console.WriteLine("--------Odds--------");
            foreach (var item in odd)
            {
                Console.WriteLine(item);
            }
            var sum_odd = odd.Sum();
            Console.WriteLine("--------SumOfOdds--------");
            Console.WriteLine(sum_odd);
        }
    }

    public static class FibExt
    {
        public static int[] clac_fib(this int end_fib)
        {
            int number1 = 1;
            int number2 = 1;
            int number3 = 0;
            var numbers = new int[end_fib];
            for (int i = 0; i < end_fib; i++)
            {
                number3 = number1 + number2;
                number2 = number1;
                number1 = number3;
                numbers[i] = number3;
            }
            return numbers;
        }
    }

}
