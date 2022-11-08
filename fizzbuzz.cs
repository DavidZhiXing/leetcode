Given a number n, for each integer i in the range from 1 to n inclusive, print one value per line as follows:

If i is a multiple of both 3 and 5, print FizzBuzz.
If i is a multiple of 3 (but not 5), print Fizz.
If i is a multiple of 5 (but not 3), print Buzz.
If i is not a multiple of 3 or 5, print the value of i.

public class Solution {
    public IList<string> FizzBuzz(int n) {
        var result = new List<string>();
        for (int i = 1; i <= n; i++) {
            if (i % 3 == 0 && i % 5 == 0) {
                result.Add("FizzBuzz");
            } else if (i % 3 == 0) {
                result.Add("Fizz");
            } else if (i % 5 == 0) {
                result.Add("Buzz");
            } else {
                result.Add(i.ToString());
            }
        }
        foreach (var item in result) {
            Console.WriteLine(item);
        }
    }

    public static void Main(string[] args) {
        var solution = new Solution();
        var result = solution.FizzBuzz(15);
        foreach (var item in result) {
            Console.WriteLine(item);
        }
    }
}

