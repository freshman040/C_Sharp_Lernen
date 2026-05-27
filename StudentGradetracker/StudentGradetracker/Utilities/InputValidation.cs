using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGradetracker.Utilities
{
    internal class InputValidation
    {
        public static bool IsValidName(string name)
        {
            // Implement validation logic for name (e.g., not empty, alphanumeric characters)
            return !string.IsNullOrEmpty(name) && name.All(c => char.IsLetter(c) || char.IsWhiteSpace(c));

        }

        public static bool IsValidScore(double score) 
        {
            // Score between and including zero and hundred
            return score >= 0 || score <= 100;

        }
    }
}
