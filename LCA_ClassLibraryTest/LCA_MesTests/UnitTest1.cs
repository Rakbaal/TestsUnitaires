using LCA_ClassLibraryTest;
using NUnit.Framework;

namespace LCA_MesTests
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
            // AAA

            // Arange
            Calculer calculer = new();
            var expected = 15;
            int a = 2; int b = 9; int c = 4;

            // Act
            var value = calculer.CalcSum(a, b, c);

            // Assert
            Assert.AreEqual(expected, value);
        }

        [Test]
        public void Test2()
        {
            // AAA

            // Arange
            Calculer calculer = new();
            var expected = 14;
            int a = 2; int b = 9; int c = 4;

            // Act
            var value = calculer.CalcSum(a, b, c);

            // Assert
            Assert.AreNotEqual(expected, value);
        }

        [Test]
        public void Test3()
        {
            // AAA

            // Arange
            Calculer calculer = new();
            var expected = 11;
            int a = 2; int b = 9;

            // Act
            var value = calculer.CalcSum(a, b);

            // Assert
            Assert.AreEqual(expected, value);
        }
    }
}