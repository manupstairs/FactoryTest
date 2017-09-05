using System;

namespace FactoryTest
{
    class A
    {
        public A(string b, string c1, string c2)
        {
            new B(b, c1, c2);
        }

        public A(AppContext context)
        {
            new B(context);
        }

        public A()
        {
            BFactory.CreateB();
        }
    }
}