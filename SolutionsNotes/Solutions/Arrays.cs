namespace SolutionsNotes.Solutions;
public class Arrays
{
    /*
     * Given an array with integer numbers. Needs to return a sorted array (bubble sorting).
     * 
     * Examples:
     * 
     * Input => [9,5,7,2,4,5,3,5]
     * Output => [2,3,4,5,5,5,7,9]
     */
    public int[] BubbleSort(int[] nums) {
        if (nums == null || nums.Length < 1) {
            return new int[0];
        }
        
        if (nums.Length == 1) {
            return nums;
        }

        for (var i = 1; i < nums.Length; i++) {
            for (var j = 0; j < nums.Length - i; j++) {
                if (nums[j] > nums[j + 1]) {
                    (nums[j], nums[j + 1]) = (nums[j + 1], nums[j]);
                }
            }
        }

        return nums;
    }

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

    public int[] HeapSort(int[] nums) {
        return new int[0];
    }

    /*
     * Given an array with integer numbers. Needs to return a sorted array (bubble sorting).
     * 
     * Examples:
     * 
     * Input => [9,5,7,2,4,5,3,5]
     * Output => [2,3,4,5,5,5,7,9]
     */
    public int[] MergeSort(int[] nums) {
        if (nums == null || nums.Length < 1) {
            return new int[0];
        }

        if (nums.Length == 1) {
            return nums;
        }

        MergeSort(nums, 0, nums.Length - 1);

        return nums;
    }

    private void MergeSort(int[] nums, int li, int ri) {
        if (li >= ri) {
            return;
        }

        var ci = (li + ri) / 2;

        MergeSort(nums, li, ci);
        MergeSort(nums, ci + 1, ri);

        Merge(nums, li, ci, ri);
    }

    private void Merge(int[] nums, int li, int ci, int ri) {
        var left = new int[ci - li + 1];
        var right = new int[ri - ci];

        for (var i = 0; i < left.Length; i++) {
            left[i] = nums[li + i];
        }

        for (var i = 0; i < right.Length; i++) {
            right[i] = nums[ci + i + 1];
        }

        var l = 0;
        var r = 0;
        var m = li;

        while (l < left.Length && r < right.Length) {
            if (left[l] > right[r]) {
                nums[m++] = right[r++];

                continue;
            }

            nums[m++] = left[l++];
        }

        for (; l < left.Length; l++, m++) {
            nums[m] = left[l];
        }

        for (; r < right.Length; r++, m++) {
            nums[m] = right[r];
        }
    }

    /*
     * Given an array with integer numbers. Needs to return a sorted array (bubble sorting).
     * 
     * Examples:
     * 
     * Input => [9,5,7,2,4,5,3,5]
     * Output => [2,3,4,5,5,5,7,9]
     */
    public int[] QuickSort(int[] nums) {
        if (nums == null || nums.Length < 1) {
            return new int[0];
        }

        if (nums.Length == 1) {
            return nums;
        }

        return QuickSort(nums, 0, nums.Length - 1);
    }

    private int[] QuickSort(int[] nums, int li, int hi) {
        if (li >= hi) {
            return nums;
        }

        var pivot = nums[hi];
        var i = li - 1;

        for (var j = li; j < hi + 1; j++) {
            if (nums[j] <= pivot) {
                i++;

                (nums[i], nums[j]) = (nums[j], nums[i]);
            }
        }

        QuickSort(nums, li, i - 1);
        QuickSort(nums, i + 1, hi);
        
        return nums;
    }
}
