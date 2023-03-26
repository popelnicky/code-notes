export class Numbers {
  /*
   * Given 1) an integer number and 2) an integer exponent. Needs to exponentiate number to exponent
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
   * - An exponentiated number should be in -2^31 to 2^31 - 1 range. When it is out of range - return 0.
   * - An exponent >= 0. Otherwise return 0.
   */
  exponentiate(num, exponent) {
    exponent = parseInt(exponent);

    if (exponent == 0) {
      return 1;
    }

    if (!exponent || exponent < 0) {
      return 0;
    }

    num = parseInt(num);

    if (!num) {
      return 0;
    }

    const margin = 2 ** 31;
    const negative = num < 0 && exponent % 2 > 0 ? -1 : 1;

    num *= negative;

    let result = num * this.exponentiate(num, exponent - 1);

    if (result > margin) {
      return 0;
    }

    if (result == margin && negative > 0) {
      return 0;
    }

    return negative * result;
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
   * Input => 25, 5
   * Output => 5
   */
  findGCD(a, b) {
    return 1;
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
  reverse(num) {
    num = parseInt(num);

    if (!num) {
      return 0;
    }

    let result = 0;
    const margin = 2 ** 31;
    const negative = num < 0 ? -1 : 1;

    num *= negative;

    while (num > 0) {
      result = result * 10 + (num % 10);

      if (result >= margin) {
        return 0;
      }

      num = parseInt(num / 10);
    }

    return negative * result;
  }
}
