using NumbersSolutions = SolutionsNotes.Solutions.Numbers;

namespace Solutions.Tests.Numbers;
public class ConvertDecToBinTests
{
    private NumbersSolutions solutions;

    [SetUp]
    public void Setup() {
        solutions = new NumbersSolutions();
    }

    [Test]
    public void ConvertZeroToBinTest() {
        var actual = solutions.ConvertDecToBin(0);

        Assert.That(actual, Is.EqualTo(0));
    }

    [Test]
    public void ConvertOneToBinTest() {
        var actual = solutions.ConvertDecToBin(1);

        Assert.That(actual, Is.EqualTo(1));
    }

    [Test]
    public void ConvertTwoToBinTest() {
        var actual = solutions.ConvertDecToBin(2);

        Assert.That(actual, Is.EqualTo(10));
    }

    [Test]
    public void ConvertEvenNumToBinTest() {
        var actual = solutions.ConvertDecToBin(8);

        Assert.That(actual, Is.EqualTo(1000));

        actual = solutions.ConvertDecToBin(14);

        Assert.That(actual, Is.EqualTo(1110));
    }

    [Test]
    public void ConvertOddNumToBinTest() {
        var actual = solutions.ConvertDecToBin(9);

        Assert.That(actual, Is.EqualTo(1001));

        actual = solutions.ConvertDecToBin(11);

        Assert.That(actual, Is.EqualTo(1011));
    }

    [Test]
    public void ConvertNegativeEvenNumToBinTest() {
        var actual = solutions.ConvertDecToBin(-22);

        Assert.That(actual, Is.EqualTo(10010110));

        actual = solutions.ConvertDecToBin(-32);

        Assert.That(actual, Is.EqualTo(10100000));
    }

    [Test]
    public void ConvertNegativeOddNumToBinTest() {
        var actual = solutions.ConvertDecToBin(-3);

        Assert.That(actual, Is.EqualTo(10000011));

        actual = solutions.ConvertDecToBin(-27);

        Assert.That(actual, Is.EqualTo(10011011));
    }

    [Test]
    public void ConvertBigEvenNumToBinTest() {
        var actual = solutions.ConvertDecToBin(98);

        Assert.That(actual, Is.EqualTo(1100010));

        actual = solutions.ConvertDecToBin(120);

        Assert.That(actual, Is.EqualTo(1111000));
    }

    [Test]
    public void ConvertNegativeSmallestEvenNumToBinTest() {
        var actual = solutions.ConvertDecToBin(-102);

        Assert.That(actual, Is.EqualTo(11100110));

        actual = solutions.ConvertDecToBin(-126);

        Assert.That(actual, Is.EqualTo(11111110));
    }

    [Test]
    public void ConvertBigOddNumToBinTest() {
        var actual = solutions.ConvertDecToBin(113);

        Assert.That(actual, Is.EqualTo(1110001));

        actual = solutions.ConvertDecToBin(125);

        Assert.That(actual, Is.EqualTo(1111101));
    }

    [Test]
    public void ConvertNegativeSmallestOddNumToBinTest() {
        var actual = solutions.ConvertDecToBin(-117);

        Assert.That(actual, Is.EqualTo(11110101));

        actual = solutions.ConvertDecToBin(-123);

        Assert.That(actual, Is.EqualTo(11111011));
    }

    [Test]
    public void ConvertBorderNumToBinTest() {
        var actual = solutions.ConvertDecToBin(127);

        Assert.That(actual, Is.EqualTo(1111111));
    }

    [Test]
    public void ConvertNegativeBorderNumToBinTest() {
        var actual = solutions.ConvertDecToBin(-128);

        Assert.That(actual, Is.EqualTo(10000000));
    }

    [Test]
    public void ConvertOutOfRangeNumToBinTest() {
        var actual = solutions.ConvertDecToBin(140);

        Assert.That(actual, Is.EqualTo(0));

        actual = solutions.ConvertDecToBin(-132);

        Assert.That(actual, Is.EqualTo(0));

        actual = solutions.ConvertDecToBin(255);

        Assert.That(actual, Is.EqualTo(0));

        actual = solutions.ConvertDecToBin(-256);

        Assert.That(actual, Is.EqualTo(0));
    }
}
