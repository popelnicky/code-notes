using NumbersNotes = SolutionsNotes.Numbers;

namespace Solutions.Tests.Numbers;

public class ExponentiateTests
{
    private NumbersNotes solutions;

    [SetUp]
    public void Setup() {
        solutions = new NumbersNotes();
    }

    [Test]
    public void ExponentiateNumToPowerThreeTest() {
        var actual = solutions.Exponentiate(2, 3);

        Assert.That(actual, Is.EqualTo(8));
    }

    [Test]
    public void ExponentiateNumToPowerZeroTest() {
        var actual = solutions.Exponentiate(2, 0);

        Assert.That(actual, Is.EqualTo(1));
    }

    [Test]
    public void ExponentiateNegativeNumToPowerZeroTest() {
        var actual = solutions.Exponentiate(-4, 0);

        Assert.That(actual, Is.EqualTo(1));
    }

    [Test]
    public void ExponentiateZeroToPowerZeroTest() {
        var actual = solutions.Exponentiate(0, 0);

        Assert.That(actual, Is.EqualTo(1));
    }

    [Test]
    public void ExponentiateNegativeNumToOddPowerTest() {
        var actual = solutions.Exponentiate(-10, 5);

        Assert.That(actual, Is.EqualTo(-100000));
    }

    [Test]
    public void ExponentiateNegativeNumToEvenPowerTest() {
        var actual = solutions.Exponentiate(-10, 6);

        Assert.That(actual, Is.EqualTo(1000000));
    }

    [Test]
    public void ExponentiateNumToOutPowerTest() {
        var actual = solutions.Exponentiate(4, 67);

        Assert.That(actual, Is.EqualTo(0));
    }

    [Test]
    public void ExponentiateNegativeNumToOutPowerTest() {
        var actual = solutions.Exponentiate(-5, 69);

        Assert.That(actual, Is.EqualTo(0));
    }

    [Test]
    public void ExponentiateNumToRightRangeBorderTest() {
        var actual = solutions.Exponentiate(2, 63);

        Assert.That(actual, Is.EqualTo(0));
    }

    [Test]
    public void ExponentiateNumToLeftRangeBorderTest() {
        var actual = solutions.Exponentiate(-2, 63);

        Assert.That(actual, Is.EqualTo(long.MinValue));
    }

    [Test]
    public void ExponentiateNumToNegativePowerTest() {
        var actual = solutions.Exponentiate(2, -5);

        Assert.That(actual, Is.EqualTo(0));
    }

    [Test]
    public void ExponentiateNegativeNumToNegativePowerTest() {
        var actual = solutions.Exponentiate(-10, -1);

        Assert.That(actual, Is.EqualTo(0));
    }
}