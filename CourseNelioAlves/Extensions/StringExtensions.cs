
namespace System
{
    public static class StringExtensions
    {
        public static string Cut(this string content, int count)
        {
            if (content.Length <= count)
            {
                return content;
            }
            else
            {
                return content.Substring(0, count) + "...";
            }
        }
    }
}
