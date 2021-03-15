using System;

namespace Bubblesort
{
    class Program
    {
        static void Main(string[] args)
        {
            //komplexität
            // n indiziertes array
            int[] n = { 45, 45, 12, 79, 18,123, 23,44,77,88 };

            int[] sorted = bubbleSort(n);
          
            
            foreach (var item in sorted)
            {
                Console.WriteLine("sorted = " + item);
            }

            Console.ReadKey(false);
        }
        static int[] bubbleSort(int[] n)
        {
            int ta; 
            //geht durch array , bzw zähler für array, 
            for (int i = 0; i <= n.Length - 2; i++)
            {
                //sortiert und tauscht position
                for (int j = 0; j <= n.Length - 2; j++)
                {
                    if (n[j] > n[j + 1])
                    {
                        ta = n[j + 1];
                        n[j + 1] = n[j];
                        n[j] = ta;
                        
                    }
                }

            }
            return n;
        }
    }
}
