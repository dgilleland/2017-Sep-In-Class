using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topic.E
{
    public class Angle
    {
        public double Degrees { get; set; }
        public double Radians
        { get { return Degrees * (Math.PI / 180); } }
        public double Grads
        { get { return Radians * (200 / Math.PI); } }

        public Angle(double degrees)
        {
            Degrees = degrees;
        }

        public override string ToString()
        {
            return $"{Degrees}{'\u00B0'}";
        }
    }
}
