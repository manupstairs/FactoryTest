using System;

namespace FactoryTest
{
    class CFactory
    {
        public static C CreateC()
        {
            var c1 = AppContext.Instance().C1;
            var c2 = AppContext.Instance().C2;
            return new C(c1, c2);
        }
    }
}