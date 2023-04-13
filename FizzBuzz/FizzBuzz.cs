public class FizzBuzz {
    public string Convert(int i) {
        //  3の倍数の場合
        if (i % 3 == 0) {
            return "Fizz";
        }

        //  5の倍数の場合
        if (i % 5 == 0) {
            return "Buzz";
        }
        return string.Concat(i);
    }
}