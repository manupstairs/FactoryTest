using System;

namespace FactoryTest
{
    class CFactory
    {
        public static C CreateC()
        {
            var c1 = AppContext.Instance.Parameter1InC;
            var c2 = AppContext.Instance.Parameter2InC;
            return new C(c1, c2);
        }
    }
}