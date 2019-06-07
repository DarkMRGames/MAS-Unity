using UnityEngine;

namespace Assets.Scripts.Common
{
    public static class Extensions
    {
        public static bool Between(this int self, int lower, int upper, bool inclusive = false)
        {
            return inclusive
                ? self >= lower && self <= upper
                : self > lower && self < upper;
        }

        public static void MoveTo(this GameObject self, Transform transform)
        {
            self.transform.position = transform.position;
            self.transform.rotation = transform.rotation;
        }
    }
}
