using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreBuilt
{
    public class Opening
    {
        // Properties for storing information
        public double Height { get; private set; }
        public double Width { get; private set; }
        public bool ExtendsToFloor { get; private set; }

        // Properties for calculating information
        public double Area { get { return Height * Width; } }
        public double CasingLength
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

        // Constructor
        public Opening(double height, double width, bool extendsToFloor)
        {
            // Store this info in the properties
            Height = height;
            Width = width;
            ExtendsToFloor = extendsToFloor;
        }
    }
}
