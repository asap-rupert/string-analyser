using Microsoft.VisualStudio.TestTools.UnitTesting;
using InvestecStringAnalyser;
namespace InvestecStringAnalyserTests
{
    [TestClass]
    public class StringAnalyserUnitTests1
    {
      
        [TestMethod]
        public void DuplicateOperationsTest()
        {
            // Arrange
            string textToAnalyse = "Hello World";
            string expected = "Found the following Duplicates: lo";
            // Act
            InvestecStringAnalyser.Program.DuplicateOperations stringAnalyser = new InvestecStringAnalyser.Program.DuplicateOperations();
            string actual = stringAnalyser.TextOperation(textToAnalyse);
            // Assert
            Assert.AreEqual(expected, actual, "Duplicate Operation Not suceeded");
        }


        [TestMethod]
        public void VowelOperationsTest()
        {
            // Arrange
            string textToAnalyse = "Hello World";
            string expected = "The number of vowels is 2";
            // Act
            InvestecStringAnalyser.Program.VowelOperations stringAnalyser = new InvestecStringAnalyser.Program.VowelOperations();
            string actual = stringAnalyser.TextOperation(textToAnalyse);
            // Assert
            Assert.AreEqual(expected, actual, "Vowel Operation Not suceeded");
        }

        [TestMethod]
        public void VowelConsOperationsTest()
        {
            // Arrange
            string textToAnalyse = "Hello World";
            string expected = "The text has more non vowels than vowels";
            // Act
            InvestecStringAnalyser.Program.VowelConsOperations stringAnalyser = new InvestecStringAnalyser.Program.VowelConsOperations();
            string actual = stringAnalyser.TextOperation(textToAnalyse);
            // Assert
            Assert.AreEqual(expected, actual, "Vowel Consonant Operation Not suceeded");
        }
    }
}
