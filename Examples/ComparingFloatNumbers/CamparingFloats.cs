using System;

    class CamparingFloats
    {
        static void Main()
        {
            double precision = 0.000001;
            float nuberOne = 5.3f;
            float numberTwo = 6.01f;
            double result = (double)(Math.Abs(nuberOne));
            if(result < precision)
            Console.WriteLine(result);
            
        }
    }
