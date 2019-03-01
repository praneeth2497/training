using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractexample
{
    abstract class AbstractExample
    {
        public abstract void msg();
    }
    class AbstracT1 : AbstractExample
    {
        public override void msg()
        {
            Console.WriteLine("hello");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
