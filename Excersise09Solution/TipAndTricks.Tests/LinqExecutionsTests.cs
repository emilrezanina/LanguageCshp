using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace TipAndTricks.Tests
{
    [TestFixture]
    public class LinqExecutionsTests
    {
        private IList<int> values;

        // SetUp method is called before each tests
        [SetUp]
        public void Init() => values = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        [Test]
        public void ImmidiateExecutionTest()
        {
            var count = (from value in values
                        where value % 2 == 0
                        select value).Count();
            values.Add(10);
            Assert.AreEqual(4, count);
        }

        [Test]
        public void DefferedExecutionTest()
        {
            var query = from value in values
                        where value % 2 == 0
                        select value;
            values.Add(10);
            Assert.AreEqual(5, query.Count());
        }

        [Test]
        public void LiqnOnInnerEnumerableAttribute()
        {
            IList<Student> students = new List<Student>();
            Student first = new Student() { Name = "First" };
            first.Scores.Add(10.0);
            first.Scores.Add(110.0);
            first.Scores.Add(150.0);
            students.Add(first);

            var scoreQuery = from student in students
                             from score in student.Scores
                             where score > 90.0
                             select new { Name = student.Name, Score = score };

            Assert.AreEqual(2, scoreQuery.Count());
        }
    }
}
