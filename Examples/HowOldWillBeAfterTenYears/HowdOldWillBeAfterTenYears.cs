using System;
using System.Text;

    class HowdOldWillBeAfterTenYears
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Въведете дата си на раждане:");
            DateTime inputYear = DateTime.Parse(Console.ReadLine());
            DateTime now = DateTime.Now;
            int myAge = now.Year - inputYear.Year;
            int afterTenYears = myAge + 10;
            Console.WriteLine("Аз съм на {0} годинишна възраст и след 10 години ще бъда на {1} години !!! ", myAge, afterTenYears);
        }
    }
