using System;

namespace FactoryTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //use parametets directly
            var a = new A("b", "c1", "c2");
            //Console.WriteLine(a);

            //use AppContext
            var appContext = new AppContext { B1 = "b", C1 = "c1", C2 = "c2" };
            var awithAppContext = new AwithAppContext(appContext);

            //use factory
            var aByFactory = AFactory.CreateA();
        }
    }
}
