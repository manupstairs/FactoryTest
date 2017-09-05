using System;

namespace FactoryTest
{
    class AwithAppContext
    {
        public AwithAppContext(AppContext context)
        {
            new BwithAppContext(context);
        }
    }
}