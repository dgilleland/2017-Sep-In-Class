using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarkCalculator
{
    public class WeightedMark
    {
        public string Name { get; set; }
        public double Weight { get; set; }

        // adding a ? to a value type allows it to store a null value
        public double? _EarnedMark; // a field as the "backing store"
        public double? EarnedMark // Explicitly implement the get/set
        {
            get
            {
                return _EarnedMark;
            }
            set
            {
                if (value < 0 || value > Weight)
                    throw new ArgumentException($"Earned marks must be from zero to {Weight}");
                _EarnedMark = value;
            }
        }

        public WeightedMark(string name, double weight)
        {
            // Validate the info coming in
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentNullException(nameof(name), "Weighted marks must have a name");
            if (name.Length > 10)
                throw new ArgumentException("Cannot store names longer than 10 characters");
            if (weight <= 0 || weight > 100)
                throw new ArgumentException("Weighted marks must be greater than zero and less than or equal to 100");

            // Store the input
            Name = name.Trim(); // "Sanitize" by removing leading/trailing spaces
            Weight = weight;
        }
    }
}
