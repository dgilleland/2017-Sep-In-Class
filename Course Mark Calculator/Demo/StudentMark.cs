using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public class StudentMark
    {
        #region Properties/Fields
        public string Name { get; private set; }
        public string Course { get; private set; }
        public List<EvaluationGroup> EvaluationItems { get; private set; }
            = new List<EvaluationGroup>(); // Create the list by default

        // Calculated values/properties
        public bool IsComplete
        {
            get
            {
                bool allMarksEntered = true;
                // See if any aren't, then change the result
                foreach (var evalGroup in EvaluationItems)
                    foreach (var item in evalGroup.Items)
                        if (!item.EarnedMark.HasValue)
                            allMarksEntered = false;

                return allMarksEntered;
            }
        }
        #endregion

        #region Constructors
        public StudentMark(string name, string course)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentNullException(nameof(name), "A student name is required");
            if (string.IsNullOrWhiteSpace(course))
                throw new ArgumentNullException(nameof(course), "A course name is required");
            Name = name;
            Course = course;
        }
        #endregion

        #region Methods
        #endregion
    }
}
