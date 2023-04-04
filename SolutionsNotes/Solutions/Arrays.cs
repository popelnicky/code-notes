namespace SolutionsNotes.Solutions;
public class Arrays
{
    public int FindMinMulti(int[] nums) {
        return 0;
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
            return new string[0];
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
