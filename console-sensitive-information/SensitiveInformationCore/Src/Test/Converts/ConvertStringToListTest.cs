using NUnit.Framework;

using SensitiveInformationCore.Src.Main.Converts;
using SensitiveInformationCore.Src.Main.Models;
using System.Collections.Generic;

namespace SensitiveInformationCore.Src.Test.Converts
{
    public class ConvertStringToListTest
    {
        [Test]
        public void ConvertJsonArrStringToListTest1()
        {
            string jsonString = @"[""Ford"",""BMW"",""Fiat""]";
            List<string> actualResult = ConvertStringToList<string>.Convert(jsonString);
            List<string> expectedResult = new List<string>() { "Ford", "BMW", "Fiat" };
            CollectionAssert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void ConvertJsonArrStringToListTest2()
        {
            string user1 = @"{
  ""id"": 0,
  ""uuid"": ""5AAB1A5B-48C4-4698-9830-1A401F286D00"",
  ""username"": ""naruto"",
  ""password"": ""sasuke""
}";
            string user2 = @"{
  ""id"": 1,
  ""uuid"": ""5AAB1A5B-48C4-4698-9830-1A401F286D01"",
  ""username"": ""goku"",
  ""password"": ""kakaroto""
}";
            string user3 = @"{
  ""id"": 2,
  ""uuid"": ""5AAB1A5B-48C4-4698-9830-1A401F286D02"",
  ""username"": ""seiya"",
  ""password"": ""sahori""
}";
            string jsonString = $"[{user1},{ user2},{user3}]";
            List<ModelUser> actualResult = ConvertStringToList<ModelUser>.Convert(jsonString);
            ModelUser userOne = new ModelUser();
            userOne.id = 0;
            userOne.uuid = "5AAB1A5B-48C4-4698-9830-1A401F286D00";
            userOne.username = "naruto";
            userOne.password = "sasuke";
            ModelUser userTwo = new ModelUser();
            userTwo.id = 1;
            userTwo.uuid = "5AAB1A5B-48C4-4698-9830-1A401F286D01";
            userTwo.username = "goku";
            userTwo.password = "kakaroto";
            ModelUser userThree = new ModelUser();
            userThree.id = 2;
            userThree.uuid = "5AAB1A5B-48C4-4698-9830-1A401F286D02";
            userThree.username = "seiya";
            userThree.password = "sahori";
            List<ModelUser> expectedResult = new List<ModelUser>() { userOne, userTwo, userThree };
            CollectionAssert.AreEqual(expectedResult, actualResult);
        }
    }
}
