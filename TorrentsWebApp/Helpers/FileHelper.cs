using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using TorrentsWebApp.Entities;

namespace TorrentsWebApp.Helpers
{
    public static class FileHelper
    {
        public static HtmlString CreateList(this IHtmlHelper html, File[] items)
        {
            string result = "<ul>";
            foreach (File item in items)
            {
                result += $"<li>{item}</li>";
            }
            result += "</ul>";
            return new HtmlString(result);
        }
    }
}

