export class Numbers {
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
  convertDecToBin(num) {
    num = parseInt(num);

    if (isNaN(num)) {
      return 0;
    }

    let bit = 1;
    const margin = 10 ** 7;
    let result = 0;
    const negative = num < 0 ? -1 : 1;

    num *= negative;

    while (num > 0) {
      let digit = num % 2;

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
   * Input => 13, 7
   * Output => 1
   */
  findGCD(a, b) {
    a = parseInt(a);
    b = parseInt(b);

    if (isNaN(a) || isNaN(b)) {
      return 0;
    }

    if (a === 0 && b === 0) {
      return 0;
    }

    a = a < 0 ? -1 * a : a;
    b = b < 0 ? -1 * b : b;

    while (b > 0) {
      [a, b] = [b, a % b];
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
