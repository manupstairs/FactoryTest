using System;

namespace FactoryTest
{
    class B
    {
        private string b1;
        private C c;
        public B(string b, string c1, string c2)
        {
            b1 = b;
            c = new C(c1, c2);
        }

        public B(AppContext context)
        {
            b1 = context.B1;
            c = new C(context);
        }

        public B(string b)
        {
            b1 = b;
            c = CFactory.CreateC();
        }

        public override string ToString()
        {
            return string.Format("b1 value {0} in Class B.\n{1}\n", b1, c);
        }
    }
}