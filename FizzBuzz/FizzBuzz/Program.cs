using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {



            for (int i = 1; i <= 50; i++)
            {

                if (i % 3 == 0 && i % 5 == 0) // wenn i vielfaches von 5 und 3 ist dann fizzbuzz
                {
                    Console.WriteLine("fizzbuzz");

                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("fizz");

                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");

                }
                else
                {
                    Console.WriteLine(i);
                }

            }

            for (int i = 1; i <= 50; i++)
            {
                switch(i % 15)
                {
                    case 0:
                        Console.WriteLine("Fizzbuzz");
                        break;

                    case 3:
                    case 6:
                    case 9:
                    case 12:
                        Console.WriteLine("Fizz");
                        break;

                    case 5:
                    case 10:
                        Console.WriteLine("Buzz");
                        break;

                    default:
                        Console.WriteLine(i);
                        break;
                }

            }



            Console.ReadKey();

        }
    }
}
