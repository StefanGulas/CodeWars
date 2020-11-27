using ConvertStringToCamelCase;
using NUnit.Framework;

namespace NUnitTestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            //Arrange
            var text1 = "the_stealth_warrior";
            var text2 = "The-Stealth-Warrior";
            var expected1 = "theStealthWarrior";
            var expected2 = "TheStealthWarrior";
            //Act
            var actual1 = Kata.ToCamelCase(text1);
            //var actual2 = Kata.ToCamelCase(text2);
            //Assert
            Assert.AreEqual(expected1, actual1);
            //Assert.AreEqual(expected2, actual2);
        }
        [Test]
        public void TestSimple()
        {
            //Arrange
            var text1 = "t-";
            var text2 = "D_w";
            var expected1 = "tu";
            var expected2 = "Dw";
            //Act
            var actual1 = Kata.ToCamelCase(text1);
            //var actual2 = Kata.ToCamelCase(text2);
            //Assert
            Assert.AreEqual(expected1, actual1);
            //Assert.AreEqual(expected2, actual2);
        }

    }
}