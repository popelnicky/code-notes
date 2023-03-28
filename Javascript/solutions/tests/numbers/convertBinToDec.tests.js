import { expect } from "chai";
import { Numbers } from "../../src/numbers.js";

describe("convertDecToBinTests", () => {
  const solutions = new Numbers();

  it("convertNullToDecTest", () => {
    const actual = solutions.convertBinToDec(null);

    expect(actual).to.equal(0);
  });

  it("convertUndefinedToDecTest", () => {
    const actual = solutions.convertBinToDec(undefined);

    expect(actual).to.equal(0);
  });

  it("convertEmptyToDecTest", () => {
    const actual = solutions.convertBinToDec("");

    expect(actual).to.equal(0);
  });

  it("convertWrongStringToDecTest", () => {
    const actual = solutions.convertBinToDec("onezeroone");

    expect(actual).to.equal(0);
  });

  it("convertWrongToDecTest", () => {
    let actual = solutions.convertBinToDec(1101200);

    expect(actual).to.equal(0);

    actual = solutions.convertBinToDec(103);

    expect(actual).to.equal(0);

    actual = solutions.convertBinToDec(111601);

    expect(actual).to.equal(0);
  });

  it("convertStringToDecTest", () => {
    let actual = solutions.convertBinToDec("100");

    expect(actual).to.equal(4);

    actual = solutions.convertBinToDec("10001001");

    expect(actual).to.equal(-9);
  });

  it("convertZeroToDecTest", () => {
    const actual = solutions.convertBinToDec(0);

    expect(actual).to.equal(0);
  });

  it("convertOneToDecTest", () => {
    const actual = solutions.convertBinToDec(1);

    expect(actual).to.equal(1);
  });

  it("convertTwoToDecTest", () => {
    const actual = solutions.convertBinToDec(10);

    expect(actual).to.equal(2);
  });

  it("convertEvenToDecTest", () => {
    const actual = solutions.convertBinToDec(1000);

    expect(actual).to.equal(8);
  });

  it("convertOddToDecTest", () => {
    const actual = solutions.convertBinToDec(101);

    expect(actual).to.equal(5);
  });

  it("convertNegativeEvenToDecTest", () => {
    const actual = solutions.convertBinToDec(10010110);

    expect(actual).to.equal(-22);
  });

  it("convertNegativeOddToDecTest", () => {
    const actual = solutions.convertBinToDec(10100111);

    expect(actual).to.equal(-39);
  });

  it("convertNegativeBorderToDecTest", () => {
    let actual = solutions.convertBinToDec(11111111);

    expect(actual).to.equal(-127);

    actual = solutions.convertBinToDec(10000000);

    expect(actual).to.equal(-128);
  });

  it("convertBorderToDecTest", () => {
    const actual = solutions.convertBinToDec(1111111);

    expect(actual).to.equal(127);
  });

  it("convertOutOfRangeToDecTest", () => {
    let actual = solutions.convertBinToDec(100011100);

    expect(actual).to.equal(0);

    actual = solutions.convertBinToDec(1000000001);

    expect(actual).to.equal(0);

    actual = solutions.convertBinToDec(10101010101);

    expect(actual).to.equal(0);

    actual = solutions.convertBinToDec(1111111111);

    expect(actual).to.equal(0);

    actual = solutions.convertBinToDec(101011100);

    expect(actual).to.equal(0);
  });
});
