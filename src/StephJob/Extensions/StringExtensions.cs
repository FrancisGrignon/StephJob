namespace StephJob
{
    public static class StringExtensions
    {
        public static string EndWithDots(this string value)
        {
            const int max = int.MaxValue;

            if (max < value.Length)
            {
                return value.Substring(0, max) + "...";
            }

            return value;
        }
    }
}
