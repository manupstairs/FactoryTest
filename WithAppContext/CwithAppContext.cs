using System;

namespace FactoryTest
{
    class CwithAppContext
    {
        private string C1 { get; set; }
        private string C2 { get; set; }
        public CwithAppContext(AppContext context)
        {
            C1 = context.C1;
            C2 = context.C2;
        }
    }
}