using ProjectEuler.Core.Problems;

namespace ProjectEuler.Tests
{
    public class Problem001Tests
    {
        [Fact]
        public void Solve_Returns_CorrectAnswer()
        {
            var solver = new Problem001();
            Assert.Equal("233168", solver.Solve());
        }
    }
}