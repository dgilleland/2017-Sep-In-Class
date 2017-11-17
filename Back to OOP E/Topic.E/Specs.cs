using System;
using Topic.E.Examples.Specs;

namespace Topic.E
{
    public class Circle_Specs : E6_Circle
    {
        protected override string AssemblyName
            => GetType().Assembly.FullName;
        //  => is the "lambda operator"
        // gives us a "short-hand" way of expressing
        // our property's Getter method
        protected override string FullyQualifiedClassName
            => typeof(Circle).FullName;
    }
}
