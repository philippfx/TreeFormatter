using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace TreeFormatter
{
    public static class JsonFormatter
    {
        public static string PrettifyJson(this string source)
        {
            return JToken.Parse(source).ToString();
            //return JsonConvert.SerializeObject(source, Formatting.Indented);
        }

        public static string MinifyJson(this string source)
        {
            return Regex.Replace(source, @"(""(?:[^""\\]|\\.)*"")|\s+", "$1");
        }
    }
}
