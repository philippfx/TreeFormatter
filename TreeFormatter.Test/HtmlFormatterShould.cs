using NUnit.Framework;

namespace TreeFormatter.Test
{
    [TestFixture]
    public class HtmlFormatterShould
    {
        string unformattedHtml 
            = @"
                <!DOCTYPE html>
                <html>
                <body>

                <h2>The href Attribute</h2>
                <p>HTML links are defined with the a tag. The link address is specified in the href attribute:</p>

                <a href=""https://www.w3schools.com"">This is a link</a>
                <div><button disabled>You cannot click me!</button></div>

                </body>
                </html>
            ";

        [Test]
        public void PrettifyHtmlString()
        {
            var actualObjectResult = unformattedHtml.MinifyHtml().PrettifyHtml();
            var expectedHtmlResult =
                @"<!DOCTYPE html>
<html>
  <body>
    <h2>
      The href Attribute
    </h2>
    <p>
      HTML links are defined with the a tag. The link address is specified in the href attribute:
    </p>
    <ahref=""https://www.w3schools.com"" >
      This is a link
    </a>
    <div>
      <buttondisabled="""" >
        You cannot click me!
      </button>
    </div>
  </body>
</html>
";

            Assert.AreEqual(expectedHtmlResult, actualObjectResult);
        }

        [Test]
        public void MinifyHtmlString()
        {
            var actualResult = unformattedHtml.MinifyHtml();
            var expectedResult = "<!DOCTYPE html><html><body><h2>The href Attribute</h2><p>HTML links are defined with the a tag. The link address is specified in the href attribute:</p><a href=\"https://www.w3schools.com\">This is a link</a><div><button disabled>You cannot click me!</button></div></body></html>";

            Assert.AreEqual(expectedResult, actualResult);
        }

    }
}
