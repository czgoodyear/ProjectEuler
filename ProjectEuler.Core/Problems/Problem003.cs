namespace ProjectEuler.Core.Problems
{
    [EulerProblem(3, "Largest Prime Factor")]
    public class Problem003 : EulerProblemBase
    {
        public override int Number => 3;
        public override string Title => "Largest Prime Factor";

        public override string Solve()
        {
            long n = 600_851_475_143;
            long maxFactor = 0;

           //Test odd divisors up to sqrt(n)
            for (long i = 3; i * i <= n; i += 2)
            {
                while (n % i == 0)
                {
                    maxFactor = i;
                    n /= i;
                }
            }

            // If n is now > 1, then whatever remains is prime
            if (n > 1)
                maxFactor = n;

            return maxFactor.ToString();
        }
    }
}
