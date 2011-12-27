using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FizzBuzz;


namespace FizzBuzz
{
    class Fizz
    {
        public static Object[] fizzbuzzfunc(int start, int end)
        {
            Object[] myArray = new Object[end+1 - start];

            for (int i = start; i <= end; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    myArray[i - start] = "Fizzbuzz";
                }
                else if (i % 3 == 0)
                {
                    myArray[i - start] = "Fizz";
                }
                else if (i % 5 == 0)
                {
                    myArray[i - start] = "Buzz";
                }
                else
                {
                    myArray[i - start] = i;
                }
            }
            return myArray;
        }
    }
}

namespace CodingExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int s = 5;
            int e = 200;
            Object[] fizzy = Fizz.fizzbuzzfunc(s,e);
            foreach (Object elem in fizzy) 
            {
                Console.WriteLine(elem);
            }
        }
    }
}
