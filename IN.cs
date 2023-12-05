using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IN
{
     class IN
    {
        static void Foo(in int value)
        {
            
            Console.WriteLine(value);
        }

        static void Main(string[] args)
        {
            int a = 5;
            Foo(a);
        }
    }
}
