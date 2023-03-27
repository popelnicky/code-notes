import { expect } from "chai";
import { Numbers } from "../src/numbers.js";

describe("convertDecToBinTests", () => {
  const solutions = new Numbers();

  it("convertNullToBinTest", () => {
    const actual = solutions.convertDecToBin(null);

    expect(actual).to.equal(0);
  });

  it("convertUndefinedToBinTest", () => {
    const actual = solutions.convertDecToBin(undefined);

    expect(actual).to.equal(0);
  });

  it("convertEmptyToBinTest", () => {
    const actual = solutions.convertDecToBin("");

    expect(actual).to.equal(0);
  });

  it("convertWrongStringDecToBinTest", () => {
    const actual = solutions.convertDecToBin("seven");

    expect(actual).to.equal(0);
  });

  it("convertStringDecToBinTest", () => {
    const actual = solutions.convertDecToBin("9");

    expect(actual).to.equal(1001);
  });

  it("convertZeroToBinTest", () => {
    const actual = solutions.convertDecToBin(0);

    expect(actual).to.equal(0);
  });

  it("convertOneToBinTest", () => {
    const actual = solutions.convertDecToBin(1);

    expect(actual).to.equal(1);
  });

  it("convertTwoToBinTest", () => {
    const actual = solutions.convertDecToBin(2);

    expect(actual).to.equal(10);
  });

  it("convertEvenNumToBinTest", () => {
    let actual = solutions.convertDecToBin(8);

    expect(actual).to.equal(1000);

    actual = solutions.convertDecToBin(14);

    expect(actual).to.equal(1110);
  });

  it("convertNegativeEvenNumToBinTest", () => {
    let actual = solutions.convertDecToBin(-22);

    expect(actual).to.equal(10010110);

    actual = solutions.convertDecToBin(-32);

    expect(actual).to.equal(10100000);
  });

  it("convertOddNumToBinTest", () => {
    let actual = solutions.convertDecToBin(5);

    expect(actual).to.equal(101);

    actual = solutions.convertDecToBin(37);

    expect(actual).to.equal(100101);
  });

  it("convertNegativeOddNumToBinTest", () => {
    let actual = solutions.convertDecToBin(-3);

    expect(actual).to.equal(10000011);

    actual = solutions.convertDecToBin(-27);

    expect(actual).to.equal(10011011);
  });

  it("convertBigEvenNumToBinTest", () => {
    let actual = solutions.convertDecToBin(98);

    expect(actual).to.equal(1100010);

    actual = solutions.convertDecToBin(120);

    expect(actual).to.equal(1111000);
  });

  it("convertNegativeSmallestEvenNumToBinTest", () => {
    let actual = solutions.convertDecToBin(-102);

    expect(actual).to.equal(11100110);

    actual = solutions.convertDecToBin(-126);

    expect(actual).to.equal(11111110);
  });

  it("convertBigOddNumToBinTest", () => {
    let actual = solutions.convertDecToBin(113);

    expect(actual).to.equal(1110001);

    actual = solutions.convertDecToBin(125);

    expect(actual).to.equal(1111101);
  });

  it("convertNegativeSmallestOddNumToBinTest", () => {
    let actual = solutions.convertDecToBin(-117);

    expect(actual).to.equal(11110101);

    actual = solutions.convertDecToBin(-123);

    expect(actual).to.equal(11111011);
  });

  it("convertBorderNumToBinTest", () => {
    const actual = solutions.convertDecToBin(127);

    expect(actual).to.equal(1111111);
  });

  it("convertNegativeBorderNumToBinTest", () => {
    const actual = solutions.convertDecToBin(-128);

    expect(actual).to.equal(10000000);
  });

  it("convertOutOfRangeNumToBinTest", () => {
    let actual = solutions.convertDecToBin(140);

    expect(actual).to.equal(0);

    actual = solutions.convertDecToBin(-132);

    expect(actual).to.equal(0);

    actual = solutions.convertDecToBin(255);

    expect(actual).to.equal(0);

    actual = solutions.convertDecToBin(-256);

    expect(actual).to.equal(0);
  });
});
