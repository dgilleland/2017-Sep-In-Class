using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarkCalculator
{
    public class EvaluationGroup
    {
        #region Properties/Fields
        public string GroupName { get; private set; }
        public bool PassAsGroup { get; private set; }
        public List<WeightedMark> Items { get; private set; }
        public double TotalWeight
        {
            get
            {
                double total = 0;
                foreach (WeightedMark mark in Items)
                    total += mark.Weight;
                return total;
            }
        }
        #endregion

        #region Constructors
        public EvaluationGroup(string name, bool passAsGroup)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentNullException(nameof(name), "A name is required for this evaluation group");
            GroupName = name.Trim();
            PassAsGroup = passAsGroup;

            // Initialize/set up the Items as an "empty" list
            Items = new List<WeightedMark>();
        }
        #endregion
    }
}
