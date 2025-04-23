using ProjectEuler.Core.Problems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Tests
{
    public class Problem003Tests
    {
        [Fact]
        public void Solve_Returns_CorrectAnswer()
        {
            var solver = new Problem003();
            Assert.Equal("6857", solver.Solve());
        }
    }
}
