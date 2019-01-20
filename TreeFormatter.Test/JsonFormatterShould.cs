using NUnit.Framework;

namespace TreeFormatter.Test
{
    [TestFixture]
    public class JsonFormatterShould
    {
        string unformattedJson = @"{
                                      ""name"":""John"",
                                      ""age"":30,
                                      ""cars"": [
                                        { ""name"":""Ford"", ""models"":[ ""Fiesta"", ""Focus"", ""Mustang"" ] },
                                        { ""name"":""BMW"", ""models"":[ ""320"", ""X3"", ""X5"" ] },
                                        { ""name"":""Fiat"", ""models"":[ ""500"", ""Panda"" ] }
                                      ]
                                    }";

        [Test]
        public void PrettifyJsonString()
        {
            var actualObjectResult = unformattedJson.PrettifyJson();
            var expectedJsonResult =
@"{
  ""name"": ""John"",
  ""age"": 30,
  ""cars"": [
    {
      ""name"": ""Ford"",
      ""models"": [
        ""Fiesta"",
        ""Focus"",
        ""Mustang""
      ]
    },
    {
      ""name"": ""BMW"",
      ""models"": [
        ""320"",
        ""X3"",
        ""X5""
      ]
    },
    {
      ""name"": ""Fiat"",
      ""models"": [
        ""500"",
        ""Panda""
      ]
    }
  ]
}";

            Assert.AreEqual(expectedJsonResult, actualObjectResult);
        }

        [Test]
        public void MinifyJsonString()
        {
            var actualObjectResult = unformattedJson.MinifyJson();
            var expectedJsonResult = "{\"name\":\"John\",\"age\":30,\"cars\":[{\"name\":\"Ford\",\"models\":[\"Fiesta\",\"Focus\",\"Mustang\"]},{\"name\":\"BMW\",\"models\":[\"320\",\"X3\",\"X5\"]},{\"name\":\"Fiat\",\"models\":[\"500\",\"Panda\"]}]}";

            Assert.AreEqual(expectedJsonResult, actualObjectResult);
        }

    }
}
