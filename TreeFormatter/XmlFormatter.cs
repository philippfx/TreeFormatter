using System;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using HtmlAgilityPack;
using Newtonsoft.Json.Linq;

namespace TreeFormatter
{
    public static class XmlFormatter
    {
        public static string MinifyXml(this string source)
        {
            return Regex.Replace(source, @">\s*<", "><").Trim();
        }

        public static string PrettifyXml(this string source)
        {
            XDocument doc = XDocument.Parse(source);
            return doc.ToString();
        }
    }
}
