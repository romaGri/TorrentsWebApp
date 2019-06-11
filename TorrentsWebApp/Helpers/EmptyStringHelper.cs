using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TorrentsWebApp.Helpers
{
    public static class EmptyStringHelper
    {
        public static string SourceStr (this IHtmlHelper html, string source, string defValue = "")
        {
            return source ?? defValue;
        }
    }
}
