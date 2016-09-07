using System;
  class ExchangeValues
    {
        static void Main()
        {
            int a = 5;
            int b = 10;
            Console.WriteLine("Values before exchange with values {0} and {1}", a,b);
            b -= a;
            a += a;
            Console.WriteLine("Values after exchange with values {0} and {1}", a, b);
        }
    }

