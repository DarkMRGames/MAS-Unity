namespace Assets.Scripts.Common
{
    public static class Extensions
    {
        public static bool Between(this int num, int lower, int upper, bool inclusive = false)
        {
            return inclusive
                ? num >= lower && num <= upper
                : num > lower && num < upper;
        }
    }
}
