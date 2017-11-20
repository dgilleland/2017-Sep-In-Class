using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreBuilt
{
    class Program
    {
        static void Main(string[] args)
        {
            //Opening window, door, closet;
            // I could get the data from the user, but....
            var window = new Opening(2, 3, false);
            var door = new Opening(5, 2, true);
            var closet = new Opening(5, 4, true);
            //var age = 23;

            double totalAreaToSubtract = window.Area + door.Area + closet.Area;
            double casingToBuy = window.CasingLength + door.CasingLength + closet.CasingLength;
            double baseboardLengthToSubtract = window.BaseBoardOffset + door.BaseBoardOffset + closet.BaseBoardOffset;


        }
    }
}
