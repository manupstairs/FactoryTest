using System;

namespace FactoryTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new A("b", "c1", "c2");
            Console.WriteLine(a);
        }
    }
}
