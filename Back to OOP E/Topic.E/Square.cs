using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topic.E
{
    public class Square
    {
        public double Side { get; set; }
        public double Area { get { return Side * Side; } }
        public double Perimeter { get { return Side * 4; } }

        public Square(double side)
        {
            Side = side;
        }
    }
}
