using System;

namespace CS_Project
{
    class Program
    { 
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World\n\n");

            int i1 = 3;
            string s1 = "Hi";

            Console.WriteLine(i1 + " " + s1);
            Console.WriteLine("{0} {1}", i1, s1);
            Console.WriteLine($"{i1} {s1}");
            Console.ReadKey();
        }
    }
}
