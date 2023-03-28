import { expect } from "chai";
import { Numbers } from "../../src/numbers.js";

describe("reverseTests", () => {
  const solutions = new Numbers();

  it("reverseNonNumTest", () => {
    let actual = solutions.reverse();

    expect(actual).to.equal(0);

    actual = solutions.reverse(undefined);

    expect(actual).to.equal(0);

    actual = solutions.reverse(null);

    expect(actual).to.equal(0);

    actual = solutions.reverse("");

    expect(actual).to.equal(0);
  });

  it("reverseSimpleNumTest", () => {
    const actual = solutions.reverse(123);

    expect(actual).to.equal(321);
  });

  it("reverseSimpleNegativeNumTest", () => {
    const actual = solutions.reverse(-123);

    expect(actual).to.equal(-321);
  });

  it("reverseNegativePalindromeNumTest", () => {
    const expected = -333;
    const actual = solutions.reverse(expected);

    expect(actual).to.equal(expected);
  });

  it("reversePalindromeNumTest", () => {
    const expected = 999;
    const actual = solutions.reverse(expected);

    expect(actual).to.equal(expected);
  });

  it("reverseDecNumTest", () => {
    const actual = solutions.reverse(60);

    expect(actual).to.equal(6);
  });

  it("reverseOneDigitNumTest", () => {
    const expected = 8;
    const actual = solutions.reverse(expected);

    expect(actual).to.equal(expected);
  });

  it("reverseNegativeOneDigitNumTest", () => {
    const expected = -5;
    const actual = solutions.reverse(expected);

    expect(actual).to.equal(expected);
  });

  it("reverseZeroTest", () => {
    const expected = 0;
    const actual = solutions.reverse(expected);

    expect(actual).to.equal(expected);
  });

  it("reverseFloatNumTest", () => {
    const actual = solutions.reverse(167.056);

    expect(actual).to.equal(761);
  });

  it("reverseNegativeFloatNumTest", () => {
    const actual = solutions.reverse(-234.999);

    expect(actual).to.equal(-432);
  });

  it("reverseFloatDecNumTest", () => {
    const actual = solutions.reverse(550.186);

    expect(actual).to.equal(55);
  });

  it("reverseNegativeFloatDecNumTest", () => {
    const actual = solutions.reverse(-1300.786);

    expect(actual).to.equal(-31);
  });

  it("reverseMaxIntNumTest", () => {
    const expected = 2 ** 31 - 1;
    const actual = solutions.reverse(expected);

    expect(actual).to.equal(0);
  });

  it("reverseMinIntNumTest", () => {
    const expected = -1 * 2 ** 31;
    const actual = solutions.reverse(expected);

    expect(actual).to.equal(0);
  });

  it("reverseStringNumTest", () => {
    const actual = solutions.reverse("-65530");

    expect(actual).to.equal(-3556);
  });

  it("reverseWrongStringNumTest", () => {
    const actual = solutions.reverse("a95");

    expect(actual).to.equal(0);
  });
});
