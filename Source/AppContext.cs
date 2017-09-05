using System;

namespace FactoryTest
{
    class AppContext
    {
        public static AppContext Instance {get; private set;}

        public string B1 { get; set; }
        public string C1 { get; set; }
        public string C2 { get; set; }

        public static void CreateInstance(string b, string c1, string c2)
        {
            Instance = new AppContext { B1 = b, C1 = c1, C2 = c2 };
        }
    }
}