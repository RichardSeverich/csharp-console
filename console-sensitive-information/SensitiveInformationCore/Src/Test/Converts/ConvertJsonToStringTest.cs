using Newtonsoft.Json.Linq;
using NUnit.Framework;

using SensitiveInformationCore.Src.Main.Converts;

namespace SensitiveInformationCore.Src.Test.Converts
{
    public class ConvertJsonToStringTest
    {
        [Test]
        public void JsonToStringTest1()
        {
            string jsonString = "{'Email':'james@example.com','Active':true,'Roles':['User','Admin']}";
            JObject jsonObj = ConvertStringToJson.Convert(jsonString);
            string actualResult = ConvertJsonToString.Convert(jsonObj);
            string expectedResult = "{\r\n  \"Email\": \"james@example.com\",\r\n  \"Active\": true,\r\n  \"Roles\": [\r\n    \"User\",\r\n    \"Admin\"\r\n  ]\r\n}";
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void JsonToStringTest2()
        {
            string expectedResult = @"{
  ""Email"": ""james@example.com"",
  ""Active"": true,
  ""Roles"": [
    ""User"",
    ""Admin""
  ]
}";
            JObject jsonObj = ConvertStringToJson.Convert(expectedResult);
            string actualResult = ConvertJsonToString.Convert(jsonObj);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void JsonToStringTest3()
        {
            string expectedResult = "{\r\n  \"Email\": \"james@example.com\",\r\n  \"Active\": true,\r\n  \"Roles\": [\r\n    \"User\",\r\n    \"Admin\"\r\n  ]\r\n}";
            JObject jsonObj = ConvertStringToJson.Convert(expectedResult);
            string actualResult = ConvertJsonToString.Convert(jsonObj);
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
