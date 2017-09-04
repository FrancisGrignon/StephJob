namespace StephJob
{
    public static class StringExtensions
    {
        public static string EndWithDots(this string value)
        {
            if (20 < value.Length)
            {
                return value.Substring(0, 20) + "...";
            }

            return value;
        }
    }
}
