using System;

namespace FactoryTest
{
    class AFactory
    {
        public static A CreateA()
        {
            return new A();
        }
    }
}