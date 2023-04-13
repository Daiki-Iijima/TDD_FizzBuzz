using NUnit.Framework;

namespace TDD_FizzBuzz {
    public class Tests {
        private FizzBuzz fizzBuzz;

        [SetUp]
        public void Setup() {
            //  €”õ
            fizzBuzz = new FizzBuzz();
        }

        [Test]
        public void _1‚ğ“n‚·‚Æ•¶š—ñ1‚ğ•Ô‚·() {
            //  Às & ŒŸØ
            Assert.AreEqual("1", fizzBuzz.Convert(1));
        }

        [Test]
        public void _2‚ğ“n‚·‚Æ•¶š—ñ2‚ğ•Ô‚·() {
            //  Às & ŒŸØ
            Assert.AreEqual("2", fizzBuzz.Convert(2));
        }

        [Test]
        public void _3‚ğ“n‚·‚Æ•¶š—ñFizz‚ğ•Ô‚·() {
            //  Às & ŒŸØ
            Assert.AreEqual("Fizz", fizzBuzz.Convert(3));
        }

        [Test]
        public void _5‚ğ“n‚·‚Æ•¶š—ñBuzz‚ğ•Ô‚·() {
            //  Às & ŒŸØ
            Assert.AreEqual("Buzz", fizzBuzz.Convert(5));
        }
    }
}