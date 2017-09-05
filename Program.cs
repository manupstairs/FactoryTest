using System;

namespace FactoryTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //use parametets directly
            var a = new A("b", "c1", "c2");
            Console.WriteLine(a);

            //use AppContext
            var appContext = new AppContext { ParameterInB = "1", Parameter1InC = "2", Parameter2InC = "3" };
            var awithAppContext = new A(appContext);
            Console.WriteLine(awithAppContext);

            //use factory
            AppContext.CreateInstance("test1", "test2", "test3");
            var aByFactory = AFactory.CreateA();
            Console.WriteLine(aByFactory);
        }
    }
}
