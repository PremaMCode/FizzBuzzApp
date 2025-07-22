using System;

class Program
{
    static void Main()
    {
        for (int i = 1; i <= 100; i++)
        {
            //Print FizzBuzz for the multiples of 3 and 5
            if (i % 15 == 0)
                Console.WriteLine("FizzBuzz");
            //Print FizzBuzz for the multiples of 3 
            else if (i % 3 == 0)
                Console.WriteLine("Fizz");
            //Print FizzBuzz for the multiples of 5
            else if (i % 5 == 0)
                Console.WriteLine("Buzz");
            else
                Console.WriteLine(i);
        }
    }
}