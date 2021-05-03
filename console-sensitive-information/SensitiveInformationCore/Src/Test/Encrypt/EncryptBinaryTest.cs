using NUnit.Framework;

using SensitiveInformationCore.Src.Main.Encrypt;

namespace SensitiveInformationCore.Src.Test.Encrypt
{
    public class EncryptBinaryTest
    {
        [Test]
        public void Test1() 
        { 
            string stringToEncrypt = "micky aguilar";
            string actualResult = EncryptBinary.StringToBinary(stringToEncrypt);
            string expectedResult = "01101101011010010110001101101011011110010010000001100001011001110111010101101001011011000110000101110010";
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Test2()
        {
            string stringToDescrypt = "01101101011010010110001101101011011110010010000001100001011001110111010101101001011011000110000101110010";
            string actualResult = EncryptBinary.BinaryToString(stringToDescrypt);
            string expectedResult = "micky aguilar";
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
