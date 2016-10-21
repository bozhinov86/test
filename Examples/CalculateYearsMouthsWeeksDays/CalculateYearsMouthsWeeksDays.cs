using System;
using System.Text;

    class CalculateYearsMouthsWeeksDays
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Моля, въведете дата на раждане:");
            DateTime now = DateTime.Now;
            string bDay = Console.ReadLine();
            DateTime birthDate = Convert.ToDateTime(bDay);

            birthDate = birthDate.Date;
            now = now.Date;

            var days = now.Day - birthDate.Day;
            if (days < 0)
            {
                var newNow = now.AddMonths(-1);
                days += (int)(now - newNow).TotalDays;
                now = newNow;
            }
            var months = now.Month - birthDate.Month;
            if (months < 0)
            {
                months += 12;
                now = now.AddYears(-1);
            }
            var years = now.Year - birthDate.Year;
            string strdays;
            string strMonths;
            if (years == 0)
            {
                if (months == 0)
                {
                   strdays = days.ToString() + " дни";
                }
                    
                else
                    strMonths = months.ToString() + " месеца";
            }
            string strYears = years.ToString() + "години";
            Console.WriteLine("Вие сте на {0} {1}месеца и {2}дни",strYears, months,days);

        }
    }
