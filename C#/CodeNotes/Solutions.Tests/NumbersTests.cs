namespace Solutions.Tests;

public class NumbersTests
{
    private Numbers solutions;
    [SetUp]
    public void Setup()
    {
        solutions = new Numbers();
    }

    [Test]
    public void ReverseTest()
    {
        var expected = 321;
        var actual = solutions.Reverse(123);

        Assert.That(actual, Is.EqualTo(expected));

        expected = -333;
        actual = solutions.Reverse(expected);

        Assert.That(actual, Is.EqualTo(expected));

        expected = 999;
        actual = solutions.Reverse(expected);
        
        Assert.That(actual, Is.EqualTo(expected));

        expected = 6;
        actual = solutions.Reverse(60);

        Assert.That(actual, Is.EqualTo(expected));
        
        expected = 0;
        actual = solutions.Reverse(expected);

        Assert.That(actual, Is.EqualTo(expected));

        actual = solutions.Reverse(int.MaxValue);

        Assert.That(actual, Is.EqualTo(expected));

        actual = solutions.Reverse(int.MinValue);
    }

    [Test]
    public void ExponentiateTest() {
        var expected = 8;
        var actual = solutions.Exponentiate(2, 3);

        Assert.That(actual, Is.EqualTo(expected));

        expected = 1;
        actual = solutions.Exponentiate(2, 0);

        Assert.That(actual, Is.EqualTo(expected));

        actual = solutions.Exponentiate(-4, 0);

        Assert.That(actual, Is.EqualTo(expected));

        actual = solutions.Exponentiate(0, 0);

        Assert.That(actual, Is.EqualTo(expected));

        expected = -100000;
        actual = solutions.Exponentiate(-10, 5);

        Assert.That(actual, Is.EqualTo(expected));

        expected = 1000000;
        actual = solutions.Exponentiate(-10, 6);

        Assert.That(actual, Is.EqualTo(expected));

        expected = 1;
        actual = solutions.Exponentiate(2, 67);

        Assert.That(actual, Is.EqualTo(expected));

        actual = solutions.Exponentiate(-2, 67);

        Assert.That(actual, Is.EqualTo(expected));
    }
}