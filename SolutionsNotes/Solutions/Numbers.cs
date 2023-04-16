namespace SolutionsNotes.Solutions;

public class Numbers
{
    /*
     * Given an integer binary number. Needs to convert it to a decimal number
     * 
     * Examples:
     * 
     * Input => 101
     * Output => 5
     * 
     * Input => 10000111
     * Output => -7
     * 
     * Input => 1111111
     * Output => 127
     * 
     * Constraints:
     * - A binary number should has no more than 8 digits (bits)
     * - An integer decimal number should be in -2^7 to 2^7 - 1 range.
     */
    public int ConvertBinToDec(int num) {
        var bit = 0;
        var result = 0;
        var negative = 1;

        while (num > 0) {
            if (bit > 6) {
                negative = -1;
                result = result == 0 ? (int) Exponentiate(2, 7) : result;

                break;
            }

            var digit = num % 10;

            if (digit > 1) {
                return 0;
            }

            result += (int) Exponentiate(2, bit) * digit;
            num = (num - digit) / 10;
            bit++;
        }

        return num > 1 ? 0 : negative * result;
    }
    /*
     * Given an integer decimal number. Needs to convert it to binary number
     * 
     * Examples:
     * 
     * Input => 3
     * Output => 11
     * 
     * Input => 8
     * Output => 1000
     * 
     * Input => -7
     * Output => 10000111
     * 
     * Constraints:
     * - An integer decimal number should be in -2^7 to 2^7 - 1 range. When it is out of range - return 0.
     * - A binary number should has no more than 8 digits (bits)
     */
    public int ConvertDecToBin(int num) {
        var margin = (int) Exponentiate(10, 7);
        var bit = 1;
        var result = 0;
        var negative = num < 0 ? -1 : 1;

        num *= negative;

        while (num > 0) {
            var digit = num % 2;

            result += bit * digit;

            if (result > margin) {
                return 0;
            }

            num = (num - digit) / 2;

            bit *= 10;
        }

        if (result == margin) {
            return negative < 0 ? result : 0;
        }

        return negative < 0 ? margin + result : result;
    }

    /*
     * Given 1) a long number and 2) exponent. Needs to exponentiate number to exponent
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

        long negative = 1;

        if (num < 0) {
            num /= -1;

            negative = exponent % 2 > 0 ? -1 : 1;
        }
        

        var max = ulong.MaxValue / 2 + 1;
        var margin = (ulong) Math.Sqrt(max); // TODO: Needs to use your own square root method
        ulong result = (ulong) num;
        var exp = 2;

        while (exp <= exponent) {
            if (result >= margin) {
                return 0;
            }

            result *= result;

            exp *= 2;
        }

        result *= (ulong) Exponentiate(num, exponent - exp / 2);

        if (result > max) {
            return 0;
        }

        if (result == max && negative > 0) {
            return 0;
        }

        return negative * (long) result;
    }

    /*
     * Given the two integer numbers a and b. Needs to find the greatest common divisor for them.
     * 
     * Examples:
     * 
     * Input => 5, 25
     * Output => 5
     * 
     * Input => 21, -9
     * Output => 3
     * 
     * Input => 49, 14
     * Output => 7
     */
    public int FindGCD(int a, int b) {
        if (a == 0 && b == 0) {
            return 0;
        }

        a = a < 0 ? -1 * a : a;
        b = b < 0 ? -1 * b : b;

        var rd = 0;

        while (b > 0) {
            rd = a % b;
            a = b;
            b = rd;
        }

        return a;
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
    public int Reverse(int num) {
        if (num == 0) {
            return 0;
        }

        long result = 0;
        long margin = uint.MaxValue / 2 + 1;
        var digits = (long) num;
        var negative = digits < 0 ? -1 : 1;

        digits /= negative;

        while (digits > 0) {
            result = result * 10 + digits % 10;

            if (result >= margin) {
                return 0;
            }

            digits /= 10;
        }

        return (int) (negative * result);
    }
}