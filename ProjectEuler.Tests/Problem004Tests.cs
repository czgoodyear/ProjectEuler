using ProjectEuler.Core.Problems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Tests
{
    public class Problem004Tests
    {
        [Fact]
        public void Solve_Returns_CorrectAnswer()
        {
            var solver = new Problem004();
            Assert.Equal("906609", solver.Solve());
        }
    }
}
