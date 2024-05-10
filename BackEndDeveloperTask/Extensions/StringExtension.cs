using System.Net;
using System.Text.RegularExpressions;

namespace BackEndDeveloperTask.Extensions
{
    public static class StringExtension
    {
        public static string StripHTML(this string input)
        {
            var result = WebUtility.HtmlDecode(input);
            return Regex.Replace(result, "<.*?>", string.Empty);
        }
    }
}
