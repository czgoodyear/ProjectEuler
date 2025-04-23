using ProjectEuler.Core.Problems;

namespace ProjectEuler.Tests
{
    public class Problem002Tests
    {
        [Fact]
        public void Solve_Returns_CorrectAnswer()
        {
            var solver = new Problem002();
            Assert.Equal("4613732", solver.Solve());
        }
    }
}
