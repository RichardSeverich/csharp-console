using NUnit.Framework;

using SensitiveInformationCore.Src.Main.Converts;
using System.Collections.Generic;

namespace SensitiveInformationCore.Src.Test.Converts
{
    public class ConvertListToStringTest
    {
        [Test]
        public void ConvertListToStringJsonArrayTest()
        {
            List<string> list = new List<string>(){ "Ford", "BMW", "Fiat" };
            string expectedResult = ConvertListToString<string>.Convert(list);
            string actualResult = @"[""Ford"",""BMW"",""Fiat""]";
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
