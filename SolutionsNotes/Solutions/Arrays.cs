namespace SolutionsNotes.Solutions;
public class Arrays
{
    /*
     * Given an array with integer numbers more than -1. Needs to return a min result of multiplication two numbers from array:
     * 
     * Examples:
     * 
     * Input => [9,5,7,2,4,5,3,5]
     * Output => 6
     */
    public int FindMinMulti(int[] nums) {
        if (nums == null || nums.Length < 2) {
            return 0;
        }

        var first = nums[0];
        var second = nums[1];

        for (var i = 2; i < nums.Length; i++) {
            if (first > nums[i]) {
                second = first;
                first = nums[i];

                continue;
            }

            if (second > nums[i]) {
                second = nums[i];
            }
        }

        return first * second;
    }

    /*
     * Given an array with integer numbers more than -1. Needs to return a string array where:
     *  - if the num % 3 == 0, then put "fizz"
     *  - if the num % 5 == 0, then put "buzz"
     *  - if the num % 3 == 0 and num % 5 == 0, then put "fizzbuzz"
     *  - for the rest cases, put string of num
     * 
     * Examples:
     * 
     * Input => [1,2,3,4]
     * Output => ["1","2","fizz","4"]
     * 
     * Input => [7,9,11,45,14,20]
     * Output => ["7","fizz","11","fizzbuzz","14","buzz"]
     */
    public string[] FizzBuzz(int[] nums) {
        if (nums == null) {
            return Array.Empty<string>();
        }

        const string fizz = "fizz";
        const string buzz = "buzz";

        var result = new string[nums.Length];

        for (var i = 0; i < nums.Length; i++) {
            var num = nums[i];
            string elem = null;

            if (num % 3 == 0) {
                elem = fizz;
            }

            if (num % 5 == 0) {
                elem += buzz;
            }

            result[i] = elem ?? $"{num}";
        }
        
        return result;
    }
}
