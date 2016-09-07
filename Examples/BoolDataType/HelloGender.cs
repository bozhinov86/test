using System;
using System.Text;

class HelloGender
    {
        static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine("Вашият пол е мъжки(M) или женски(F):");
        string gender = Console.ReadLine();
        bool isFemale = (gender == "F" || gender == "f");
        bool isMale = (gender == "M" || gender == "m");
        if (isFemale)
        {
            Console.WriteLine("Добър ден г-жа..");
        }
        else if(isMale)
        {
            Console.WriteLine("Добър ден г-н...");
        }
        else
        {
            Console.WriteLine("Моля, Въведете един от символите(M/F)"); 
        }
    }
    }

