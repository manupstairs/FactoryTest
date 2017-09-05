using System;

namespace FactoryTest
{
    class AppContext
    {
        public string B1 { get; set; }
        public string C1 { get; set; }
        public string C2 { get; set; }

        public static AppContext Instance()
        {
            return new AppContext { B1 = "b", C1 = "c1", C2 = "c2" };
        }
    }
}