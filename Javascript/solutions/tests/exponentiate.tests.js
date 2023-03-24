import { expect } from "chai";
import { Numbers } from "../src/numbers.js";

describe("exponentiateTests", () => {
  const solutions = new Numbers();

  it("exponentiateNonNumToPowerTest", () => {
    let actual = solutions.exponentiate(undefined, 3);
    const expected = 0;
    expect(actual).to.equal(expected);

    actual = solutions.exponentiate(null, 3);

    expect(actual).to.equal(expected);

    actual = solutions.exponentiate("", 3);

    expect(actual).to.equal(expected);
  });

  it("exponentiateNumToNonPowerTest", () => {
    let actual = solutions.exponentiate(2);
    const expected = 0;

    expect(actual).to.equal(expected);

    actual = solutions.exponentiate(2, undefined);

    expect(actual).to.equal(expected);

    actual = solutions.exponentiate(2, null);

    expect(actual).to.equal(expected);

    actual = solutions.exponentiate(2, "");

    expect(actual).to.equal(expected);
  });

  it("exponentiateNonNumToNonPowerTest", () => {
    let actual = solutions.exponentiate();
    const expected = 0;

    expect(actual).to.equal(expected);

    actual = solutions.exponentiate(null, undefined);

    expect(actual).to.equal(expected);

    actual = solutions.exponentiate(undefined, null);

    expect(actual).to.equal(expected);

    actual = solutions.exponentiate("", "");

    expect(actual).to.equal(expected);
  });
  
  it("exponentiateNumToPowerThreeTest", () => {
    const actual = solutions.exponentiate(2, 3);

    expect(actual).to.equal(8);
  });

  it("exponentiateNumToPowerZeroTest", () => {
    const actual = solutions.exponentiate(2, 0);

    expect(actual).to.equal(1);
  });

  it("exponentiateNegativeNumToPowerZeroTest", () => {
    const actual = solutions.exponentiate(-4, 0);

    expect(actual).to.equal(1);
  });

  it("exponentiateZeroToPowerZeroTest", () => {
    const actual = solutions.exponentiate(0, 0);

    expect(actual).to.equal(1);
  });

  it("exponentiateNegativeNumToOddPowerTest", () => {
    const actual = solutions.exponentiate(-10, 5);

    expect(actual).to.equal(-100000);
  });

  it("exponentiateNegativeNumToEvenPowerTest", () => {
    const actual = solutions.exponentiate(-10, 6);

    expect(actual).to.equal(1000000);
  });

  it("exponentiateNumToOutPowerTest", () => {
    const actual = solutions.exponentiate(4, 36);

    expect(actual).to.equal(0);
  });

  it("exponentiateNegativeNumToOutPowerTest", () => {
    const actual = solutions.exponentiate(-5, 44);

    expect(actual).to.equal(0);
  });

  it("exponentiateNumToRightRangeBorderTest", () => {
    const actual = solutions.exponentiate(2, 31);

    expect(actual).to.equal(0);
  });

  it("exponentiateNumToLeftRangeBorderTest", () => {
    const expected = -1 * (2 ** 31);
    const actual = solutions.exponentiate(-2, 31);

    expect(actual).to.equal(expected);
  });

  it("exponentiateNumToNegativePowerTest", () => {
    const actual = solutions.exponentiate(2, -5);

    expect(actual).to.equal(0);
  });

  it("exponentiateNegativeNumToNegativePowerTest", () => {
    const actual = solutions.exponentiate(-10, -1);

    expect(actual).to.equal(0);
  });

  it("exponentiateFloatNumToPowerTest", () => {
    const actual = solutions.exponentiate(5.02, 3);

    expect(actual).to.equal(125);
  });

  it("exponentiateNegativeFloatNumToPowerTest", () => {
    const actual = solutions.exponentiate(-4.55, 3);

    expect(actual).to.equal(-64);
  });
  
  it("exponentiateNumToFloatPowerTest", () => {
    const actual = solutions.exponentiate(2, 4.33);

    expect(actual).to.equal(16);
  });

  it("exponentiateFloatNumToFloatPowerTest", () => {
    const actual = solutions.exponentiate(2.67, 16.04);

    expect(actual).to.equal(65536);
  });

  it("exponentiateWrongNumToPowerTest", () => {
    const actual = solutions.exponentiate("fca", 5);

    expect(actual).to.equal(0);
  });

  it("exponentiateNumToWrongPowerTest", () => {
    const actual = solutions.exponentiate(4, "ba");

    expect(actual).to.equal(0);
  });

  it("exponentiateStringNumToPowerTest", () => {
    const actual = solutions.exponentiate("2", 8);

    expect(actual).to.equal(256);
  });

  it("exponentiateStringNumToStringPowerTest", () => {
    const actual = solutions.exponentiate("4", "2");

    expect(actual).to.equal(16);
  });
});
