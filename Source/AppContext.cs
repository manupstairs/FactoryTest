using System;

namespace FactoryTest
{
    class AppContext
    {
        public static AppContext Instance {get; private set;}

        public string ParameterInB { get; set; }
        public string Parameter1InC { get; set; }
        public string Parameter2InC { get; set; }

        public static void CreateInstance(string b, string c1, string c2)
        {
            Instance = new AppContext { ParameterInB = b, Parameter1InC = c1, Parameter2InC = c2 };
        }
    }
}