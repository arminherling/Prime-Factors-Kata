using NUnit.Framework;
using System.Collections.Generic;

namespace Prime_Factors.Tests
{
    public class PrimeFactorsTests
    {
        [Test]
        public void PrimeFactorsOf0_Returns_EmptyList()
        {
            Assert.AreEqual(
                new List<int>(),
                PrimeFactors.Of(0));
        }

        [Test]
        public void PrimeFactorsOf1_Returns_EmptyList()
        {
            Assert.AreEqual(
                new List<int>(),
                PrimeFactors.Of(1));
        }

        [Test]
        public void PrimeFactorsOf2_Returns_2()
        {
            Assert.AreEqual(
                new List<int> { 2 },
                PrimeFactors.Of(2));
        }

        [Test]
        public void PrimeFactorsOf3_Returns_3()
        {
            Assert.AreEqual(
                new List<int> { 3 },
                PrimeFactors.Of(3));
        }

        [Test]
        public void PrimeFactorsOf4_Returns_2_2()
        {
            Assert.AreEqual(
                new List<int> { 2, 2 },
                PrimeFactors.Of(4));
        }

        [Test]
        public void PrimeFactorsOf5_Returns_5()
        {
            Assert.AreEqual(
                new List<int> { 5 },
                PrimeFactors.Of(5));
        }

        [Test]
        public void PrimeFactorsOf6_Returns_2_3()
        {
            Assert.AreEqual(
                new List<int> { 2, 3 },
                PrimeFactors.Of(6));
        }

        [Test]
        public void PrimeFactorsOf7_Returns_7()
        {
            Assert.AreEqual(
                new List<int> { 7 },
                PrimeFactors.Of(7));
        }

        [Test]
        public void PrimeFactorsOf8_Returns_2_2_2()
        {
            Assert.AreEqual(
                new List<int> { 2, 2, 2 },
                PrimeFactors.Of(8));
        }

        [Test]
        public void PrimeFactorsOf9_Returns_3_3()
        {
            Assert.AreEqual(
                new List<int> { 3, 3 },
                PrimeFactors.Of(9));
        }

        [Test]
        public void PrimeFactorsOf10_Returns_2_5()
        {
            Assert.AreEqual(
                new List<int> { 2, 5 },
                PrimeFactors.Of(10));
        }

        [Test]
        public void PrimeFactorsOfHugeProduct_ReturnsCorrectResult()
        {
            Assert.AreEqual(
                new List<int> { 2, 3, 5, 5, 7, 11, 13, 13 },
                PrimeFactors.Of(2 * 3 * 5 * 5 * 7 * 11 * 13 * 13));
        }
    }
}