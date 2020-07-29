using System;

namespace primenumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int limit = 100;
            int qty = 0;
            int incremenent = 1;
            for (int i = 2; i <= limit; i += incremenent)
            {
                if (i > 2)
                {
                    incremenent = 2;
                }
                int endLoop = (int) i / 2;
                bool isPrime = true;
                for (int j = 2; j < endLoop; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                    }
                }

                if (isPrime == true)
                {
                    Console.WriteLine(i);
                    qty++;

                }
            }

            Console.WriteLine("\n" + qty + " nombres sont premiers");
        }
    }
}
