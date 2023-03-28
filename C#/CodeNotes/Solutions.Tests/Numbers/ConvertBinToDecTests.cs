using NumbersNotes = SolutionsNotes.Numbers;

namespace Solutions.Tests.Numbers;
public class ConvertBinToDecTests
{
    private NumbersNotes solutions;

    [SetUp]
    public void Setup() {
        solutions = new NumbersNotes();
    }

    [Test]
    public void ConvertWrongToDecTest() {
        var actual = solutions.ConvertBinToDec(1101200);

        Assert.That(actual, Is.EqualTo(0));

        actual = solutions.ConvertBinToDec(103);

        Assert.That(actual, Is.EqualTo(0));

        actual = solutions.ConvertBinToDec(111601);

        Assert.That(actual, Is.EqualTo(0));
    }

    [Test]
    public void ConvertZeroToDecTest() {
        var actual = solutions.ConvertBinToDec(0);

        Assert.That(actual, Is.EqualTo(0));
    }

    [Test]
    public void ConvertOneToDecTest() {
        var actual = solutions.ConvertBinToDec(1);

        Assert.That(actual, Is.EqualTo(1));
    }

    [Test]
    public void ConvertTwoToDecTest() {
        var actual = solutions.ConvertBinToDec(10);

        Assert.That(actual, Is.EqualTo(2));
    }

    [Test]
    public void ConvertEvenToDecTest() {
        var actual = solutions.ConvertBinToDec(1000);

        Assert.That(actual, Is.EqualTo(8));
    }

    [Test]
    public void ConvertOddToDecTest() {
        var actual = solutions.ConvertBinToDec(101);

        Assert.That(actual, Is.EqualTo(5));
    }

    [Test]
    public void ConvertNegativeEvenToDecTest() {
        var actual = solutions.ConvertBinToDec(10010110);

        Assert.That(actual, Is.EqualTo(-22));
    }

    [Test]
    public void ConvertNegativeOddToDecTest() {
        var actual = solutions.ConvertBinToDec(10100111);

        Assert.That(actual, Is.EqualTo(-39));
    }

    [Test]
    public void ConvertNegativeBorderToDecTest() {
        var actual = solutions.ConvertBinToDec(11111111);

        Assert.That(actual, Is.EqualTo(-127));

        actual = solutions.ConvertBinToDec(10000000);

        Assert.That(actual, Is.EqualTo(-128));
    }

    [Test]
    public void ConvertBorderToDecTest() {
        var actual = solutions.ConvertBinToDec(1111111);

        Assert.That(actual, Is.EqualTo(127));
    }

    [Test]
    public void ConvertOutOfRangeToDecTest() {
        var actual = solutions.ConvertBinToDec(100011100);

        Assert.That(actual, Is.EqualTo(0));

        actual = solutions.ConvertBinToDec(1000000001);

        Assert.That(actual, Is.EqualTo(0));

        actual = solutions.ConvertBinToDec(1010101010);

        Assert.That(actual, Is.EqualTo(0));

        actual = solutions.ConvertBinToDec(1111111111);

        Assert.That(actual, Is.EqualTo(0));

        actual = solutions.ConvertBinToDec(101011100);

        Assert.That(actual, Is.EqualTo(0));
    }
}
