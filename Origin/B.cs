using System;

namespace FactoryTest
{
    class B
    {
        private string B1 { get; set; }
        public B(string b, string c1, string c2)
        {
            B1 = b;
            new C(c1, c2);
        }

        public B(string b)
        {
            B1 = b;
            CFactory.CreateC();
        }
    }
}