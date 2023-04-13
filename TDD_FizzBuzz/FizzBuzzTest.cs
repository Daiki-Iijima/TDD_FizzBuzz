using NUnit.Framework;

namespace TDD_FizzBuzz {
    public class Tests {
        private FizzBuzz fizzBuzz;

        [SetUp]
        public void Setup() {
            //  準備
            fizzBuzz = new FizzBuzz();
        }

        [Test]
        public void _1を渡すと文字列1を返す() {
            //  実行 & 検証
            Assert.AreEqual("1", fizzBuzz.Convert(1));
        }

        [Test]
        public void _2を渡すと文字列2を返す() {
            //  実行 & 検証
            Assert.AreEqual("2", fizzBuzz.Convert(2));
        }

        [Test]
        public void _3を渡すと文字列Fizzを返す() {
            //  実行 & 検証
            Assert.AreEqual("Fizz", fizzBuzz.Convert(3));
        }

        [Test]
        public void _5を渡すと文字列Buzzを返す() {
            //  実行 & 検証
            Assert.AreEqual("Buzz", fizzBuzz.Convert(5));
        }
    }
}