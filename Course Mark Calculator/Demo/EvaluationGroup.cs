using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public class EvaluationGroup
    {
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

        public EvaluationGroup(string name, bool passAsGroup)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentNullException(nameof(name), "A name is required for this evaulation group");
            GroupName = name.Trim();
            PassAsGroup = passAsGroup;

            Items = new List<WeightedMark>();
        }


    }
}
