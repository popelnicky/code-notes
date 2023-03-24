namespace SolutionsNotes;

public class Numbers
{
    /*
     * Given 1) an long number and 2) exponent. Needs to exponentiate number to exponent
     * 
     * Examples:
     * 
     * Input => 2, 3
     * Output => 8
     * 
     * Input => -10, 5
     * Output => -100000
     * 
     * Constraints:
     * - An exponentiated number should be in -2^63 to 2^63 - 1 range. When it is out of range - return 0.
     * - An exponent >= 0. Otherwise return 0.
     */
    public long Exponentiate(long num, int exponent) {
        if (exponent < 0) {
            return 0;
        }

        if (exponent == 0) {
            return 1;
        }

        long negative = num < 0 && exponent % 2 > 0 ? -1 : 1;

        num /= negative;

        ulong margin = ulong.MaxValue / 2 + 1;
        ulong result = (ulong) (num * Exponentiate(num, exponent - 1));

        if (result > margin) {
            return 0;
        }

        if (result == margin && negative > 0) {
            return 0;
        }

        return negative * (long) result;
    }

    /*
     * Given an integer number which needs to reverse
     * 
     * Examples:
     * 
     * Input => 123
     * Output => 321
     * 
     * Input => -120
     * Output => -21
     * 
     * Constraints:
     * A reversed number should be in -2^31 to 2^31 - 1 range. When it is out of range - return 0.
     */
    public int ReverseNum(int num) {
        if (num == 0) {
            return 0;
        }

        long result = 0;
        long margin = uint.MaxValue / 2 + 1;
        var digits = (long) num;
        var negative = digits < 0 ? -1 : 1;

        digits /= negative;

        while (digits > 0) {
            result = (result * 10) + (digits % 10);

            if (result >= margin) {
                return 0;
            }

            digits /= 10;
        }

        return (int) (negative * result);
    }
}