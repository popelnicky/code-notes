using NumbersSolutions = SolutionsNotes.Solutions.Numbers;

namespace Solutions.Tests.Numbers;

public class ReverseTests
{
    private NumbersSolutions solutions;

    [SetUp]
    public void Setup() {
        solutions = new NumbersSolutions();
    }

    [Test]
    public void ReverseSimpleNumTest() {
        var actual = solutions.Reverse(123);

        Assert.That(actual, Is.EqualTo(321));
    }

    [Test]
    public void ReverseSimpleNegativeNumTest() {
        var actual = solutions.Reverse(-123);

        Assert.That(actual, Is.EqualTo(-321));
    }

    [Test]
    public void ReverseNegativePalindromeNumTest() {
        var expected = -333;
        var actual = solutions.Reverse(expected);

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void ReversePalindromeNumTest() {
        var expected = 999;
        var actual = solutions.Reverse(expected);

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void ReverseDecNumTest() {
        var actual = solutions.Reverse(60);

        Assert.That(actual, Is.EqualTo(6));
    }

    [Test]
    public void ReverseOneDigitNumTest() {
        var expected = 8;
        var actual = solutions.Reverse(expected);

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void ReverseNegativeOneDigitNumTest() {
        var expected = -5;
        var actual = solutions.Reverse(expected);

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void ReverseZeroTest() {
        var expected = 0;
        var actual = solutions.Reverse(expected);

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void ReverseMaxIntNumTest() {
        var actual = solutions.Reverse(int.MaxValue);

        Assert.That(actual, Is.EqualTo(0));
    }

    [Test]
    public void ReverseMinIntNumTest() {
        var actual = solutions.Reverse(int.MinValue);

        Assert.That(actual, Is.EqualTo(0));
    }
}
