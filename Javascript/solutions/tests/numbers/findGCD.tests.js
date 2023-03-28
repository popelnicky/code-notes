import { expect } from "chai";
import { Numbers } from "../../src/numbers.js";

describe("findGCDTests", () => {
  const solutions = new Numbers();
  const checkFindGCDWith = (a, b, expected) => {
    const actual = solutions.findGCD(a, b);

    checkResult(a, actual);
    checkResult(b, actual);

    expect(actual).to.equal(expected);
  };
  const checkResult = (num, gcd) => {
    expect(num % gcd).to.equal(0);
  };

  it("findGCDForNullAndNumTest", () => {
    const actual = solutions.findGCD(null, 1);

    expect(actual).to.equal(0);
  });

  it("findGCDForNumAndNullTest", () => {
    const actual = solutions.findGCD(-2, null);

    expect(actual).to.equal(0);
  });

  it("findGCDForNullAndNullTest", () => {
    const actual = solutions.findGCD(null, null);

    expect(actual).to.equal(0);
  });

  it("findGCDForUndefinedAndNumTest", () => {
    const actual = solutions.findGCD(undefined, 6);

    expect(actual).to.equal(0);
  });

  it("findGCDForNumAndUndefinedTest", () => {
    const actual = solutions.findGCD(10, undefined);

    expect(actual).to.equal(0);
  });

  it("findGCDForUndefinedAndUndefinedTest", () => {
    const actual = solutions.findGCD(undefined, undefined);

    expect(actual).to.equal(0);
  });

  it("findGCDForEmptyAndNumTest", () => {
    const actual = solutions.findGCD("", -7);

    expect(actual).to.equal(0);
  });

  it("findGCDForNumAndEmptyTest", () => {
    const actual = solutions.findGCD(19, "");

    expect(actual).to.equal(0);
  });

  it("findGCDForEmptyAndEmptyTest", () => {
    const actual = solutions.findGCD("", "");

    expect(actual).to.equal(0);
  });

  it("findGCDForNaNAndNumTest", () => {
    const actual = solutions.findGCD(NaN, 3);

    expect(actual).to.equal(0);
  });

  it("findGCDForNumAndNaNTest", () => {
    const actual = solutions.findGCD(-11, NaN);

    expect(actual).to.equal(0);
  });

  it("findGCDForNaNAndNaNTest", () => {
    const actual = solutions.findGCD(NaN, NaN);

    expect(actual).to.equal(0);
  });

  it("findGCDForFirstWrongStringNumTest", () => {
    const actual = solutions.findGCD("six", 25);

    expect(actual).to.equal(0);
  });

  it("findGCDForSecondWrongStringNumTest", () => {
    const actual = solutions.findGCD(3, "ten");

    expect(actual).to.equal(0);
  });

  it("findGCDForTwoWrongStringNumsTest", () => {
    const actual = solutions.findGCD("five", "nine");

    expect(actual).to.equal(0);
  });

  it("findGCDForFirstStringNumTest", () => {
    const a = "10";
    const b = 100;
    const actual = solutions.findGCD(a, b);

    checkResult(parseInt(a), actual);
    checkResult(b, actual);

    expect(actual).to.equal(10);
  });

  it("findGCDForSecondStringNumTest", () => {
    const a = 8;
    const b = "2";
    const actual = solutions.findGCD(a, b);

    checkResult(a, actual);
    checkResult(parseInt(b), actual);

    expect(actual).to.equal(2);
  });

  it("findGCDForTwoStringNumsTest", () => {
    const a = "26";
    const b = "37";
    const actual = solutions.findGCD(a, b);

    checkResult(parseInt(a), actual);
    checkResult(parseInt(b), actual);

    expect(actual).to.equal(1);
  });

  it("findGCDForTwoNegativeStringNumsTest", () => {
    const a = "-7";
    const b = "-1";
    const actual = solutions.findGCD(a, b);

    checkResult(parseInt(a), actual);
    checkResult(parseInt(b), actual);

    expect(actual).to.equal(1);
  });

  it("findGCDForZerosTest", () => {
    const actual = solutions.findGCD(0, 0);

    expect(actual).to.equal(0);
  });

  it("findGCDForZeroAndNumTest", () => {
    checkFindGCDWith(0, 180, 180);
  });

  it("findGCDForZeroAndNegativeNumTest", () => {
    checkFindGCDWith(0, -40, 40);
  });

  it("findGCDForNumAndZeroTest", () => {
    checkFindGCDWith(29, 0, 29);
  });

  it("findGCDForNegativeNumAndZeroTest", () => {
    checkFindGCDWith(-43, 0, 43);
  });

  it("findGCDForOddNumsTest", () => {
    checkFindGCDWith(5, 25, 5);
  });

  it("findGCDForEvenNumsTest", () => {
    checkFindGCDWith(32, 256, 32);
  });

  it("findGCDForEvenAndOddNumsTest", () => {
    checkFindGCDWith(210, 7, 7);
  });

  it("findGCDForSimpleNumsTest", () => {
    checkFindGCDWith(13, 17, 1);
  });

  it("findGCDForTheSameEvenNumsTest", () => {
    const num = 14;
    checkFindGCDWith(num, num, num);
  });

  it("findGCDForTheSameOddNumsTest", () => {
    const num = 67;
    checkFindGCDWith(num, num, num);
  });

  it("findGCDForTheSameNegativeEvenNumsTest", () => {
    const num = -22;
    checkFindGCDWith(num, num, -1 * num);
  });

  it("findGCDForTheSameNegativeOddNumsTest", () => {
    const num = -99;
    checkFindGCDWith(num, num, -1 * num);
  });

  it("findGCDForNegativeOddNumsTest", () => {
    checkFindGCDWith(-39, -27, 3);
  });

  it("findGCDForNegativeEvenNumsTest", () => {
    checkFindGCDWith(-12, -4, 4);
  });

  it("findGCDForNegativeOddAndEvenNumsTest", () => {
    checkFindGCDWith(-21, -6, 3);
  });

  it("findGCDForEvenAndNegativeOddNumsTest", () => {
    checkFindGCDWith(12, -15, 3);
  });

  it("findGCDForBigEvenNumsTest", () => {
    const a = 2 ** 16;
    const b = 2 ** 31;

    checkFindGCDWith(a, b, a);
  });

  it("findGCDForBigOddNumsTest", () => {
    checkFindGCDWith(7048935, 27675, 45);
  });

  it("findGCDForBigOddAndEvenNumsTest", () => {
    const a = 2 ** 33 - 1;
    const b = 2 ** 13;

    checkFindGCDWith(a, b, 1);
  });
});
