namespace ProjectEuler.Core.Problems
{
    [EulerProblem(1, "Multiples of 3 and 5")]
    public class Problem001 : EulerProblemBase
    {
        public override int Number => 1;
        public override string Title => "Multiples of 3 and 5";

        public override string Solve()
            => Enumerable.Range(1, 999)
                         .Where(n => n % 3 == 0 || n % 5 == 0)
                         .Sum()
                         .ToString();
    }
}
