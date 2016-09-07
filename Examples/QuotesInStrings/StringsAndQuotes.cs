using System;

    class StringsAndQuotes
    {
        static void Main()
        {
            string strOne = "The \"use\" of quotations causes difficulties";
            string strTwo = @"The ""use"" of quotations causes difficulties";
            Console.WriteLine(strOne);
            Console.WriteLine(strTwo);
        }
    }
