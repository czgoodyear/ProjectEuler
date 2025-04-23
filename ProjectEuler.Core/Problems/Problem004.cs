namespace ProjectEuler.Core.Problems
{
    [EulerProblem(4, "Largest Palindrome Product")]
    public class Problem004 : EulerProblemBase
    {
        public override int Number => 4;
        public override string Title => "Largest Palindrome Product";

        public override string Solve()
        {
            int largestPalindrome = 0;

            // Iterate downward from 999 to 100 so we find large products first
            for (int i = 999; i >= 100; i--)
            {
                for (int j = i; j >= 100; j--)
                {
                    int prod = i * j;
                    // If product is already less than current max, no need to keep checking smaller j
                    if (prod <= largestPalindrome)
                        break;

                    if (IsPalindrome(prod))
                        largestPalindrome = prod;
                }
            }

            return largestPalindrome.ToString();
        }

        private static bool IsPalindrome(int value)
        {
            var s = value.ToString();
            var rev = new string(s.Reverse().ToArray());
            return s == rev;
        }
    }
}
