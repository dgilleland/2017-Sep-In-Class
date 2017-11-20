using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreBuilt
{
    public class Opening
    {
        public double Height { get; private set; }
        public double Width { get; private set; }
        public bool ExtendsToFloor { get; set; }

        public double Area { get { return Height * Width; } }
        public double Casing
        {
            get
            {
                double length = Height * 2 + Width * 2;
                if (ExtendsToFloor)
                    length -= Width;
                return length;
            }
        }
        public double BaseBoardOffset
        {
            get
            {
                double length = 0;
                if (ExtendsToFloor)
                    length = Width;
                return length;
            }
        }

        public Opening(double height, double width, bool extendsToFloor)
        {
            Height = height;
            Width = width;
            ExtendsToFloor = extendsToFloor;
        }
    }
}
