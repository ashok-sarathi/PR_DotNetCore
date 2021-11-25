using System;

namespace TestInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //Demo1 demo1 = new();
            //Demo2 demo2 = new();
            //Demo3 demo1 = new Demo1();
            //demo1.Show();
            //demo1.Hide();

            Console.ReadLine();
        }
    }

    public class Demo1
    {
        public virtual void Show()
        {
            Console.WriteLine("Demo 1");
        }
    }

    public class Demo2 : Demo1
    {
        public override void Show()
        {
            Console.WriteLine("Demo 2");
        }
    }

    public class Demo3 : Demo2
    {
        public override void Show()
        {
            Console.WriteLine("Demo 3");
        }

        public void Hide()
        {
            Console.WriteLine("Demo 3");
        }
    }
}
