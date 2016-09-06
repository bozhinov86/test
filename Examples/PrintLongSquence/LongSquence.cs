using System;
using System.Collections.Generic;

class LongSequence
    {
        static void Main()
        {
            List<int> listNumbers = new List<int>();
            for (int i = 2; i < 1000; i++)
            {
                
                if (i % 2 == 0)
                {
                    listNumbers.Add(i);
                }
                else
                {
                    listNumbers.Add(-i);
                }
            }
            foreach (int item in listNumbers)
            {
                Console.Write(item + ",");
            } 
        }
    }
