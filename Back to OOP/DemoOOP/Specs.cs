using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Topic.E.Examples.Specs;

namespace DemoOOP
{
    // All of the specification tests for the Topic.E.Example classes
    internal class Calculator_Specs
        : E1_Calculator
    {
        protected override string AssemblyName
        { get { return GetType().Assembly.FullName; } }
        protected override string FullyQualifiedClassName
        { get { return typeof(Calculator).FullName; } }
    }

    public class Person_Specs : E2_Person
    {
        protected override string AssemblyName
        { get { return GetType().Assembly.FullName; } }
        protected override string FullyQualifiedClassName
        { get { return typeof(Person).FullName; } }
    }
}
