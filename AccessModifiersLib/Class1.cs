using System;

namespace AccessModifiersLib
{
    public class AccessModifiers
    {
        public class PublicClass
        {
            protected internal int SetValue { get; set; }
            protected int SetValue2 { get; set; }
        }

        protected class ProtectedClass
        {

        }

        internal class InternalClass
        {

        }

        protected internal class ProtectedInternalClass
        {

        }

        private class PrivateClass
        {

        }
    }

    public class Demo1
    {
        //AccessModifiers.
        AccessModifiers.PublicClass pp = new ();

        public Demo1()
        {
            pp.SetValue = 0;
        }

    }

    public class Demo2 : AccessModifiers
    {
        //AccessModifiers.
        PublicClass pp = new();

        public Demo2()
        {
            pp.SetValue = 0;
        }
    }
}
