using System;

namespace FactoryTest
{
    class B
    {
        private string B1 { get; set; }
        public B(string b, string c1, string c2)
        {
            new C(c1, c2);
        }
    }
}