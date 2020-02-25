using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using PrimeFactor;

namespace PrimeFactorTests
{
    public class PrimeFactorGeneratorTests: With_an_automocked<PrimeFactorGenerator>
    {
        private List<int> BuildList(params int[] numbers)
        {
            var list = numbers.ToList();
            list.ForEach(Console.WriteLine);
            return list;
        }

        [Test]
        public void When_generate_test_one()
        {
            Assert.That(ClassUnderTest.Generate(1), Is.EquivalentTo(BuildList()));
        }

        [Test]
        public void When_generate_test_two()
        {
            Assert.That(ClassUnderTest.Generate(2), Is.EquivalentTo(BuildList(2)));
        }

        [Test]
        public void When_generate_test_three()
        {
            Assert.That(ClassUnderTest.Generate(3), Is.EquivalentTo(BuildList(3)));
        }

        [Test]
        public void When_generate_test_four()
        {
            Assert.That(ClassUnderTest.Generate(4), Is.EquivalentTo(BuildList(2, 2)));
        }

        [Test]
        public void When_generate_test_six()
        {
            Assert.That(ClassUnderTest.Generate(6), Is.EquivalentTo(BuildList(2, 3)));
        }

        [Test]
        public void When_generate_test_eight()
        {
            Assert.That(ClassUnderTest.Generate(8), Is.EquivalentTo(BuildList(2, 2, 2)));
        }

        [Test]
        public void When_generate_test_nine()
        {
            Assert.That(ClassUnderTest.Generate(9), Is.EquivalentTo(BuildList(3,3)));
        }

        [Test]
        public void When_generate_test_25()
        {
            Assert.That(ClassUnderTest.Generate(25), Is.EquivalentTo(BuildList(5, 5)));
        }

    }
}
