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

            Student student1 = new Student() { Age = 20 };
            Student student2 = new Student() { Age = 30 };

            Console.WriteLine(student1 + student2);
            Console.WriteLine(student1 - student2 + new Student() { Age = 10 });
            Console.WriteLine(1 - new Student() { Age = 10 });

            Console.ReadLine();
        }
    }

    public class Student
    {
        public int Age { get; set; }
        public string Name { get; set; }

        public static int operator +(Student student1, Student student2)
        {
            return student1.Age + student2.Age;
        }

        public static Student operator -(Student student1, Student student2)
        {
            return new Student() { Age = student1.Age - student2.Age };
        }

        public static int operator -(int student1, Student student2)
        {
            return student1 - student2.Age;
        }
    }

    public class Demo1
    {
        public virtual void Show()
        {
            Console.WriteLine("Demo 1");
        }

        public void Show(int a)
        {

        }

        public void Show(string a)
        {

        }

        public void Show(int a, string b)
        {

        }

        public void Show(string a, int b)
        {

        }

        public void Show(int a, int b)
        {

        }

        public int Show(bool a, int b)
        {
            return b;
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
