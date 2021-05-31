using NUnit.Framework;

using SensitiveInformationCore.Src.Main.Converts;
using SensitiveInformationCore.Src.Main.EntityDomain;

namespace SensitiveInformationCore.Src.Test.Converts
{
    public class ConvertObjectToStringJsonIdentTest
    {
        [Test]
        public void ConvertObjToJsonObjStringIdentTest() 
        {
            User user = new User();
            user.id = 2;
            user.uuid = "5AAB1A5B-48C4-4698-9830-1A401F286D02";
            user.username = "naruto";
            user.password = "sasuke";
            string actualResult = ConvertObjectToStringJsonIdent<User>.Convert(user);
            string expectedResult = @"{
  ""id"": 2,
  ""uuid"": ""5AAB1A5B-48C4-4698-9830-1A401F286D02"",
  ""username"": ""naruto"",
  ""password"": ""sasuke""
}";
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
