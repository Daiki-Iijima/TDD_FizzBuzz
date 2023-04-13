using NUnit.Framework;

namespace TDD_FizzBuzz {
    public class Tests {
        private FizzBuzz fizzBuzz;

        [SetUp]
        public void Setup() {
            //  ����
            fizzBuzz = new FizzBuzz();
        }

        [Test]
        public void _1��n���ƕ�����1��Ԃ�() {
            //  ���s & ����
            Assert.AreEqual("1", fizzBuzz.Convert(1));
        }

        [Test]
        public void _2��n���ƕ�����2��Ԃ�() {
            //  ���s & ����
            Assert.AreEqual("2", fizzBuzz.Convert(2));
        }

        [Test]
        public void _3��n���ƕ�����Fizz��Ԃ�() {
            //  ���s & ����
            Assert.AreEqual("Fizz", fizzBuzz.Convert(3));
        }

        [Test]
        public void _5��n���ƕ�����Buzz��Ԃ�() {
            //  ���s & ����
            Assert.AreEqual("Buzz", fizzBuzz.Convert(5));
        }
    }
}