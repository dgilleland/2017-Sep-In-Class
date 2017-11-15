using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDemos
{
    public class Calculator_Specs
        : Topic.E.Examples.Specs.E1_Calculator
    {
        protected override string AssemblyName
        { get { return GetType().Assembly.FullName; } }
        protected override string FullyQualifiedClassName
        { get { return typeof(Calculator).FullName; } }
    }

    public class Person_Specs
        : Topic.E.Examples.Specs.E2_Person
    {
        protected override string AssemblyName
        { get { return GetType().Assembly.FullName; } }
        protected override string FullyQualifiedClassName
        { get { return typeof(Person).FullName; } }
    }
}
