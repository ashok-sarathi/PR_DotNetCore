using AccessModifiersLib;
using System;

namespace AccessModifiersConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class Demo3
    {
        //AccessModifiers.
        AccessModifiers.PublicClass pp = new ();
        public Demo3()
        {
            //pp.
        }
    }

    public class Demo4 : AccessModifiers
    {
        //AccessModifiers.
        AccessModifiers.PublicClass pp = new();

        public Demo4()
        {
            //pp.
        }
    }

    public class Demo5 : AccessModifiers.PublicClass
    {
        //AccessModifiers.

        public Demo5()
        {
            //SetValue2 = 0;
        }
    }


}
