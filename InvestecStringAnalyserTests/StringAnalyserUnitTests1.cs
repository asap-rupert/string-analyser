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
            InvestecStringAnalyser.InvestecStringAnalyser.DuplicateOperations stringAnalyser = new InvestecStringAnalyser.InvestecStringAnalyser.DuplicateOperations();
            string actual = stringAnalyser.TextOperation(textToAnalyse);
            // Assert
            Assert.AreEqual(expected, actual, "Duplicate Operation Not suceeded");
        }

        [TestMethod]
        public void AltDuplicateOperationsTest()
        {
            // Arrange
            string textToAnalyse = "He World";
            string expected = "No duplicate values were found";
            // Act
            InvestecStringAnalyser.InvestecStringAnalyser.DuplicateOperations stringAnalyser = new InvestecStringAnalyser.InvestecStringAnalyser.DuplicateOperations();
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
            InvestecStringAnalyser.InvestecStringAnalyser.VowelOperations stringAnalyser = new InvestecStringAnalyser.InvestecStringAnalyser.VowelOperations();
            string actual = stringAnalyser.TextOperation(textToAnalyse);
            // Assert
            Assert.AreEqual(expected, actual, "Vowel Operation Not suceeded");
        }


        [TestMethod]
        public void AltVowelOperationsTest()
        {
            // Arrange
            string textToAnalyse = "JKL HHJG";
            string expected = "No vowels were found";
            // Act
            InvestecStringAnalyser.InvestecStringAnalyser.VowelOperations stringAnalyser = new InvestecStringAnalyser.InvestecStringAnalyser.VowelOperations();
            string actual = stringAnalyser.TextOperation(textToAnalyse);
            // Assert
            Assert.AreEqual(expected, actual, "Vowel Operation Not suceeded");
        }

        [TestMethod]
        public void VowelOrNonOperationsTest()
        {
            // Arrange
            string textToAnalyse = "Hello World";
            string expected = "The text has more non vowels than vowels";
            // Act
            InvestecStringAnalyser.InvestecStringAnalyser.VowelOrNonOperations stringAnalyser = new InvestecStringAnalyser.InvestecStringAnalyser.VowelOrNonOperations();
            string actual = stringAnalyser.TextOperation(textToAnalyse);
            // Assert
            Assert.AreEqual(expected, actual, "Vowel or Non Vowel Operation Not suceeded");
        }

        [TestMethod]
        public void AltVowelOrNonOperationsTest()
        {
            // Arrange
            string textToAnalyse = "AAA lll";
            string expected = "The text has an equal amount of vowels and non vowels";
            // Act
            InvestecStringAnalyser.InvestecStringAnalyser.VowelOrNonOperations stringAnalyser = new InvestecStringAnalyser.InvestecStringAnalyser.VowelOrNonOperations();
            string actual = stringAnalyser.TextOperation(textToAnalyse);
            // Assert
            Assert.AreEqual(expected, actual, "Vowel or Non Vowel Operation Not suceeded");
        }

        [TestMethod]
        public void OtherAltVowelOrNonOperationsTest()
        {
            // Arrange
            string textToAnalyse = "I ate an apple";
            string expected = "The text has more vowels than non vowels";
            // Act
            InvestecStringAnalyser.InvestecStringAnalyser.VowelOrNonOperations stringAnalyser = new InvestecStringAnalyser.InvestecStringAnalyser.VowelOrNonOperations();
            string actual = stringAnalyser.TextOperation(textToAnalyse);
            // Assert
            Assert.AreEqual(expected, actual, "Vowel or Non Vowel Operation Not suceeded");
        }
    }
}
