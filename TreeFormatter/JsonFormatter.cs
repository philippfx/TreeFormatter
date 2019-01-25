namespace TreeFormatter
{
    using Newtonsoft.Json.Linq;
    using System.Text.RegularExpressions;

    /// <summary>
    /// Defines the <see cref="JsonFormatter" />
    /// </summary>
    public static class JsonFormatter
    {
        /// <summary>
        /// Prettifies a json string
        /// </summary>
        /// <param name="source">source json <see cref="string"/></param>
        /// <returns>prettiefied json <see cref="string"/></returns>
        public static string PrettifyJson(this string source)
        {
            return JToken.Parse(source).ToString();
        }

        /// <summary>
        /// Minifies a json string
        /// </summary>
        /// <param name="source">source json <see cref="string"/></param>
        /// <returns>minified json <see cref="string"/></returns>
        public static string MinifyJson(this string source)
        {
            return Regex.Replace(source, @"(""(?:[^""\\]|\\.)*"")|\s+", "$1");
        }
    }
}
