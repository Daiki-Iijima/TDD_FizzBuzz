using NUnit.Framework;

namespace FizzBuzz数列と変換規則を扱うFizzBuzzクラス {
    public class  FizzBuzz_Test{
        public class _3の倍数の時は数の代わりにFizzに変換する {
            private FizzBuzz fizzBuzz;

            [SetUp]
            public void Setup() {
                //  準備
                fizzBuzz = new FizzBuzz();
            }

            [Test]
            public void _3を渡すと文字列Fizzを返す() {
                //  実行 & 検証
                Assert.AreEqual("Fizz", fizzBuzz.Convert(3));
            }
        }

        public class _5の倍数の時は数の代わりにBuzzに変換する {
            private FizzBuzz fizzBuzz;

            [SetUp]
            public void Setup() {
                //  準備
                fizzBuzz = new FizzBuzz();
            }

            [Test]
            public void _5を渡すと文字列Buzzを返す() {
                //  実行 & 検証
                Assert.AreEqual("Buzz", fizzBuzz.Convert(5));
            }
        }

        public class その他の数のときはそのまま文字列に変換する {
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
        }
    }
}