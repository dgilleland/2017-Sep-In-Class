using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CP3Tests
{
    public class When_Using_Program_Methods
    {
        [Fact]
        public void Should_Display_Prompt_For_GetSafeInt()
        {
            // Arrange
            var originalConsoleOut = Console.Out;
            var writer = new StringWriter();
            string expected = "Enter a number: ";

            // Act
            Program.GetSafeInt(expected);

            // Assert
            writer.Flush();
            string actual;
            char[] buffer = new char[expected.Length];
            writer.GetStringBuilder().CopyTo(0, buffer, 0, expected.Length);
            actual = new string(buffer);
            Assert.Equal(expected, actual);
        }
//        int GetSafeInt(string prompt)

//    double GetSafeDouble(string prompt)

//    double CalculateCasingCost(double casingPrice, double casingLength)
//double CalculateBaseboardCost(double baseboardPrice, double baseboardLength)
//double CalculatePaintCost(int paintType, double wallArea, double ceilingArea)
//double CalculateFlooringCost(int flooringType, double floorArea)

    }
}
