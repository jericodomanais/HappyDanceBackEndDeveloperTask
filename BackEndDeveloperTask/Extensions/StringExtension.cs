using System.Net;
using System.Text.RegularExpressions;
using Microsoft.AspNetCore.Html;

namespace BackEndDeveloperTask.Extensions
{
    public static class StringExtension
    {
        public static string StripHTML(this string input)
        {
            var result = WebUtility.HtmlDecode(input);
            return Regex.Replace(result, "<.*?>", string.Empty);
        }

        public static IHtmlContent Truncate(this string input, int length = 100)
        {
            if (string.IsNullOrEmpty(input))
            {
                return new HtmlString(string.Empty);
            }

            input = input.StripHTML();

            if (input.Length > length)
            {
                return new HtmlString(input[..100] + "...");
            }
            else
            {
                return new HtmlString(input);
            }
        }
    }
}
