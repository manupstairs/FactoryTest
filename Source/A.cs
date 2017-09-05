using System;

namespace FactoryTest
{
    class A
    {
        private B b;
        public A(string b, string c1, string c2)
        {
            this.b = new B(b, c1, c2);
        }

        public A(AppContext context)
        {
            b = new B(context);
        }

        public A()
        {
            b = BFactory.CreateB();
        }

        public override string ToString()
        {
            return b.ToString();
        }
    }
}