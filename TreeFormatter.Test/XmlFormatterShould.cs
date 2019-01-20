using NUnit.Framework;

namespace TreeFormatter.Test
{
    [TestFixture]
    public class XmlFormatterShould
    {
        string unformattedXml = @"<?xml version=""1.0"" encoding=""UTF-8""?>
<bookstore>
  <book category=""cooking"">
    <title lang=""en"">Everyday Italian</title>
    <author>Giada De Laurentiis</author>
    <year>2005</year>
    <price>30.00</price>
  </book>
  <book category=""children""><title lang=""en"">Harry Potter</title><author>J K. Rowling</author><year>2005</year><price>29.99</price> </book>
</bookstore>";



          [Test]
        public void PrettifyXmlString()
        {
            var actualObjectResult = unformattedXml.PrettifyXml();
            var expectedXmlResult =
                @"<bookstore>
  <book category=""cooking"">
    <title lang=""en"">Everyday Italian</title>
    <author>Giada De Laurentiis</author>
    <year>2005</year>
    <price>30.00</price>
  </book>
  <book category=""children"">
    <title lang=""en"">Harry Potter</title>
    <author>J K. Rowling</author>
    <year>2005</year>
    <price>29.99</price>
  </book>
</bookstore>";

            Assert.AreEqual(expectedXmlResult, actualObjectResult);
        }

        [Test]
        public void MinifyXmlString()
        {
            var actualObjectResult = unformattedXml.MinifyXml();
            var expectedXmlResult = "<?xml version=\"1.0\" encoding=\"UTF-8\"?><bookstore><book category=\"cooking\"><title lang=\"en\">Everyday Italian</title><author>Giada De Laurentiis</author><year>2005</year><price>30.00</price></book><book category=\"children\"><title lang=\"en\">Harry Potter</title><author>J K. Rowling</author><year>2005</year><price>29.99</price></book></bookstore>";

            Assert.AreEqual(expectedXmlResult, actualObjectResult);
        }

    }
}
