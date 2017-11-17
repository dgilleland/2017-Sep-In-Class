using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topic.E
{
    class Program
    {
        static void Main(string[] args)
        {
            DemoAngle();
        }

        private static void DemoAngle()
        {
            Angle right = new Angle(90);
            Console.WriteLine(right);
            Console.WriteLine($"A {right} angle in Grads is {right.Grads} Grads");
        }
    }
}
