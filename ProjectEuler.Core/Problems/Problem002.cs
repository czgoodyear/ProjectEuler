namespace ProjectEuler.Core.Problems
{
    [EulerProblem(2, "Even Fibonacci numbers")]
    public class Problem002 : EulerProblemBase
    {
        public override int Number => 2;
        public override string Title => "Even Fibonacci numbers";

        public override string Solve()
        {
            long sum = 0;
            long a = 1;
            long b = 2;

            // Iterate until the current term exceeds four million
            while (a <= 4_000_000)
            {
                if ((a & 1) == 0)  // even check
                {
                    sum += a;
                }

                long next = a + b;
                a = b;
                b = next;
            }

            return sum.ToString();
        }
    }
}
