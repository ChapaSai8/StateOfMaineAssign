using Microsoft.VisualStudio.TestTools.UnitTesting;
using PR4Assignment;
using System;
using System.IO;

namespace PR4Assignment.Tests
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void AddTwoRomanNumeralSucessfully()
        {
            // Arrange
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            var data = String.Join(Environment.NewLine, new[] {
                "MC",
                "CM"
            });

            var stringReader = new StringReader(data);
            Console.SetIn(stringReader);

            // Act
            Program.Main(new string[10]);

            // Assert
            var output = stringWriter.ToString();
            Assert.AreEqual("Enter First Roman Numeral: \r\nInteger: 1100\r\nEnter Second Roman Numeral: \r\nInteger: 900\r\nsum: 2000\r\nSum: MM\r\n", output);

        }

        [TestMethod]
        public void AddTwoRomanNumeralWithError()
        {
            // Arrange
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            var data = String.Join(Environment.NewLine, new[] {
                "MA",
                "CM"
            });

            var stringReader = new StringReader(data);
            Console.SetIn(stringReader);

            // Act and Assert
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => Program.Main(new string[10]));

        }
    }
}
