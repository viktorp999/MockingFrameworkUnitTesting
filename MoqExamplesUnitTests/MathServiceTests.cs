using NUnit.Framework;
using System;
using MoqExamples;

namespace MoqExamplesUnitTests
{
    [TestFixture]
    public class MathServiceTests
    {
        private IMathService _service;

        [SetUp]
        public void SetUp()
        {
            _service = new MathService();
        }

        [Test]
        public void TestCase1()
        {
            int input = 10;

            var result = _service.MathMethod(input);

            Assert.AreEqual(20, result);
        }

        [Test]
        public void TestException1()
        {
            int input = 1;

            Assert.Throws<ArgumentException>(() => _service.MathMethod(input));
        }

        [Test]
        public void TestException2()
        {
            int input = 2;

            Assert.Throws<DivideByZeroException>(() => _service.MathMethod(input));
        }

        [Test]
        public void TestException3()
        {
            int input = 3;

            Assert.Throws<InvalidCastException>(() => _service.MathMethod(input));
        }
    }
}
