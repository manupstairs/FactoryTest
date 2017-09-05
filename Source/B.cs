using System;

namespace FactoryTest
{
    class B
    {
        private string parameterInB;
        private C c;
        public B(string b, string c1, string c2)
        {
            parameterInB = b;
            c = new C(c1, c2);
        }

        public B(AppContext context)
        {
            parameterInB = context.ParameterInB;
            c = new C(context);
        }

        public B(string b)
        {
            parameterInB = b;
            c = CFactory.CreateC();
        }

        public override string ToString()
        {
            return string.Format("b1 value {0} in Class B.\n{1}\n", parameterInB, c);
        }
    }
}