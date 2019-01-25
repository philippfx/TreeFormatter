namespace TreeFormatter
{
    using System.Text.RegularExpressions;
    using System.Xml.Linq;

    /// <summary>
    /// Defines the <see cref="XmlFormatter" />
    /// </summary>
    public static class XmlFormatter
    {
        /// <summary>
        /// Minifies an Xml string
        /// </summary>
        /// <param name="source">source xml <see cref="string"/></param>
        /// <returns>minified xml <see cref="string"/></returns>
        public static string MinifyXml(this string source)
        {
            return Regex.Replace(source, @">\s*<", "><").Trim();
        }

        /// <summary>
        /// Prettifies an Xml string
        /// </summary>
        /// <param name="source">source xml <see cref="string"/></param>
        /// <returns>Prettified xml <see cref="string"/></returns>
        public static string PrettifyXml(this string source)
        {
            XDocument doc = XDocument.Parse(source);
            return doc.ToString();
        }
    }
}
