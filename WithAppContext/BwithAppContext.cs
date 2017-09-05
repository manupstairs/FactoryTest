using System;

namespace FactoryTest
{
    class BwithAppContext
    {
        private string B1 { get; set; }
        public BwithAppContext(AppContext context)
        {
            B1 = context.B;
            new C(context);
        }
    }
}