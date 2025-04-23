using ProjectEuler.Core.Problems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Tests
{
    public class Problem005Tests
    {
        [Fact]
        public void Solve_Returns_CorrectAnswer()
        {
            var solver = new Problem005();
            Assert.Equal("232792560", solver.Solve());
        }
    }
}
