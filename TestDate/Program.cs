using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDate
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d = DateTime.Now;
            DateTime utc = DateTime.UtcNow;
            DateTimeOffset dss = DateTime.Now;
            DateTimeOffset ds = DateTime.UtcNow;
            MyClass1 f = new MyClass1();
            int ff= f.Method();
            Console.ReadKey();
        }
    }
    public abstract class MyClass
    {
        public abstract int MyProperty { get;}
        public int Method()
        {
            return MyProperty;
        }
    }
    class MyClass1 : MyClass
    {
        public MyClass1()
        {
        }

        public override int MyProperty { get { return 1; } }
    }
}
