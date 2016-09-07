using System;

    class CastStringAndObjects
    {
        static void Main()
        {
            string hello = "Hello";
            string world = "World";
            object helloWorld = hello + " " + world;
            string result = helloWorld.ToString();
            Console.WriteLine(result);
        }
    }
