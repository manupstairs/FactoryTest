using System;

namespace FactoryTest
{
    class BFactory
    {
        public static B CreateB()
        {
            var b1 = AppContext.Instance().B1;
            return new B(b1);
        }
    }
}