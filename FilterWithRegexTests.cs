using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using net_core_regex;
using net_core_regex.Models;

namespace net_core_regex
{
    [TestClass]
    public class FilterWithRegexTests
    {
        [TestMethod]
        public void WithinTwoValues_Test()
        {
            // Arrange
            var filterWithRegex = new FilterWithRegex("<my-email@gmail.com>");
            String start = "<";
            String end = ">";

            // Act
            var result = filterWithRegex.WithinTwoValues(
                start,
                end);
            
            // Assert
            Assert.AreEqual("my-email@gmail.com", result);
        }

        [TestMethod]
        public void Password_Test()
        {
            // Arrange
            var filterWithRegex = new FilterWithRegex("MyPassword123456+*");
            Mpassword mPassword = new Mpassword{
                UpperCase = true,
                LowerCase = true,
                Number = true,
                SpecialCharacter = true,
                Longitude = new Mlongitude
                {
                    Start = 6,
                    End = 20
                }};

            // Act
            var result = filterWithRegex.Password(
                mPassword);

            // Assert
            Assert.AreEqual("MyPassword123456+*", result);
        }

        [TestMethod]
        public void Email_Test()
        {
            // Arrange
            var filterWithRegex = new FilterWithRegex(@"antonio_17@gmail.com");

            // Act
            var result = filterWithRegex.Email();

            // Assert
            Assert.AreEqual("antonio_17@gmail.com", result);
        }

        [TestMethod]
        public void Url_Test()
        {
            // Arrange
            var filterWithRegex = new FilterWithRegex(@"https://github.com/antonioolvera1995/net_Core-regex");

            // Act
            var result = filterWithRegex.Url();

            // Assert
            Assert.AreEqual(@"https://github.com/antonioolvera1995/net_Core-regex", result);
        }
    }
}
