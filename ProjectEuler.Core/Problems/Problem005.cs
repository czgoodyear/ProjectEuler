namespace ProjectEuler.Core.Problems
{
    [EulerProblem(5, "Smallest Multiple")]
    public class Problem005 : EulerProblemBase
    {
        public override int Number => 5;
        public override string Title => "Smallest Multiple";

        public override string Solve()
        {
            long lcm = 1;

            for (int n = 2; n <= 20; n++)
            {
                lcm = Lcm(lcm, n);
            }

            return lcm.ToString();
        }

        private static long Lcm(long a, long b)
            => a / Gcd(a, b) * b;

        private static long Gcd(long a, long b)
            => b == 0 ? a : Gcd(b, a % b);

    }
}
