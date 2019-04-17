using System;
using System.Collections.Generic;
using System.Text;

namespace TipAndTricks
{
    public class Student
    {
        public string Name { get; set; }
        public IList<double> Scores { get; } = new List<double>();
    }
}
