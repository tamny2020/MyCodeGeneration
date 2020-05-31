using RazorEngine;
using RazorEngine.Configuration;
using RazorEngine.Templating;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My.CodeGeneration.Common
{
    /// <summary>
    /// Razor帮助类
    /// </summary>
    public class RazorEngineHelper
    {
        static RazorEngineHelper()
        {
            Razor.SetTemplateService(new TemplateService(new TemplateServiceConfiguration()
            {
                BaseTemplateType = typeof(CustomRazorTemplate<>)
            }));
        }

        public static string Parse<T>(string virtualPath, T model)
        {
            var razorTemplate = Path.Combine(CommonHelper.BaseDirectory, virtualPath).ReadAllText();
            var parseHtml = Razor.Parse<T>(razorTemplate, model);
            return parseHtml;
        }

    }
}
