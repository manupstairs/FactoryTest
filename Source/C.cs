using System;

namespace FactoryTest
{
    class C
    {
        private string C1 { get; set; }
        private string C2 { get; set; }
        public C(string c1, string c2)
        {
            C1 = c1;
            C2 = c2;
        }

        public C(AppContext context)
        {
            C1 = context.C1;
            C2 = context.C2;
        }
    }
}