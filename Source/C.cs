using System;

namespace FactoryTest
{
    class C
    {
        private string c1;
        private string c2;
        public C(string c1, string c2)
        {
            this.c1 = c1;
            this.c2 = c2;
        }

        public C(AppContext context)
        {
            c1 = context.C1;
            c2 = context.C2;
        }

        public override string ToString()
        {
            return string.Format("c1 value {0} in Class C, c2 value {1} in Class C.", c1, c2);
        }
    }
}