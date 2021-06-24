using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            BestCodingPractices bestCoding = new BestCodingPractices();
            Console.WriteLine(""+bestCoding.Addition(5,7));
        }
    }
}
