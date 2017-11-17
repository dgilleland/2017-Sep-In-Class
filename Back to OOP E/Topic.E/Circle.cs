using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topic.E
{
    public class Circle
    {
        public double Diameter { get; set; }
        public double Radius
        { get { return Diameter / 2; } }
        public double Area
        { get { return Math.PI * Radius * Radius; } }
        public double Circumference
        { get { return 2 * Math.PI * Radius; } }

        public Circle(double d)
        {
            // the job of a constructor is to 
            // ensure that all the fields/properties
            // have "meaningful" values
            Diameter = d;
        }
    }
}
