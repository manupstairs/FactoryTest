using System;

namespace FactoryTest
{
    class C
    {
        private string parameter1InC;
        private string parameter2InC;
        public C(string c1, string c2)
        {
            this.parameter1InC = c1;
            this.parameter2InC = c2;
        }

        public C(AppContext context)
        {
            parameter1InC = context.Parameter1InC;
            parameter2InC = context.Parameter2InC;
        }

        public override string ToString()
        {
            return string.Format("c1 value {0} in Class C, c2 value {1} in Class C.", parameter1InC, parameter2InC);
        }
    }
}