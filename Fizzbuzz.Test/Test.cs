using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Fizzbuzz.Test
{
    [TestFixture]
    public class Test
    {
        private FizzBuzzMultiple fizzTest;

        [SetUp]
        public void Init()
        {
            fizzTest = new FizzBuzzMultiple();
        }

        [Test]
        public void Given0WhenTransformThenShouldBe0()
        {
            string input = "0";
            string expected = "0";

            var result = fizzTest.Transform(input);

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Given3WhenTransformThenShouldBeFizz()
        {
            string input = "3";
            string expected = FizzBuzzMultiple.Str3;

            var result = fizzTest.Transform(input);

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Given2WhenTransformThenShouldNotBeFizz()
        {
            string input = "2";
            string expected = "2";

            var result = fizzTest.Transform(input);

            Assert.AreEqual(expected, result);
            Assert.AreNotEqual(expected, FizzBuzzMultiple.Str3);
        }

        [Test]
        public void GivenMultiple3WhenTransformThenShoulBeFizz()
        {
            string input = "9";
            string expected = FizzBuzzMultiple.Str3;

            var result = fizzTest.Transform(input);

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Given5WhenTransformThenShouldBeBuzz() {
            string input = "5";
            string expected = FizzBuzzMultiple.Str5;

            var result = fizzTest.Transform(input);

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Given2WhenTransformThenShouldNotBeBuzz()
        {
            string input = "2";
            string expected = "2";

            var result = fizzTest.Transform(input);

            Assert.AreEqual(expected, result);
            Assert.AreNotEqual(expected, FizzBuzzMultiple.Str5);
        }

        [Test]
        public void GivenMultiple5WhenTransformThenShoulBeFizz()
        {
            string input = "25";
            string expected = FizzBuzzMultiple.Str5;

            var result = fizzTest.Transform(input);

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Given15WhenTransformThenShoulBeFizzBuzz()
        {
            string input = "15";
            string expected = FizzBuzzMultiple.Str3 + FizzBuzzMultiple.Str5;

            var result = fizzTest.Transform(input);

            Assert.AreEqual(expected, result);
        }
        /*
        [Test]
        public void Given3_5WhenTransformThenShouldBeFizz_Buzz(){
            string input = "3_5";
            string expected = FizzBuzzMultiple.Str3 + "_" + FizzBuzzMultiple.Str5;        


        }*/
    }
}
