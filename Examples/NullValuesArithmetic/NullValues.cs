using System;

    class NullValues
    {
        static void Main()
        {
            int? number = null;
            double? doubleNumber = null;
            Console.WriteLine(number);
            Console.WriteLine(doubleNumber);
            int notNullInt = number ?? 2;
            double notNullDouble = doubleNumber ?? 3.45;
            Console.WriteLine(notNullInt);
            Console.WriteLine(notNullDouble);
        }
    }
