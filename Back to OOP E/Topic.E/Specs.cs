using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Topic.E.Examples.Specs; // The namespace of the tests

namespace Topic.E
{
    public class Circle_Specs : E6_Circle
    {
        // Another way to identify the Class and Assembly names
        protected override string FullyQualifiedClassName
            => typeof(Circle).FullName;
        //  =>  is called the "lambda operator"; nice shorthand
        protected override string AssemblyName
            => GetType().Assembly.FullName;
    }
    public class Square_Specs : E7_Square
    {
        // Another way to identify the Class and Assembly names
        protected override string FullyQualifiedClassName
            => typeof(Square).FullName;
        //  =>  is called the "lambda operator"; nice shorthand
        protected override string AssemblyName
            => GetType().Assembly.FullName;
    }
    public class Angle_Specs : E9_Angle
    {
        // Another way to identify the Class and Assembly names
        protected override string FullyQualifiedClassName
            => typeof(Angle).FullName;
        //  =>  is called the "lambda operator"; nice shorthand
        protected override string AssemblyName
            => GetType().Assembly.FullName;
    }
}
