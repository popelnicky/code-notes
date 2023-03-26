using NumbersNotes = SolutionsNotes.Numbers;

namespace Solutions.Tests.Numbers;
public class FindGCDTests
{
    private NumbersNotes solutions;

    [SetUp]
    public void Setup() {
        solutions = new NumbersNotes();
    }

    [Test]
    public void FindGCDForZerosTest() {
        var actual = solutions.FindGCD(0, 0);

        Assert.That(actual, Is.EqualTo(0));
    }

    [Test]
    public void FindGCDForZeroAndNumTest() {
        CheckFindGCDWith(0, 180, 180);
    }

    [Test]
    public void FindGCDForZeroAndNegativeNumTest() {
        CheckFindGCDWith(0, -40, 40);
    }

    [Test]
    public void FindGCDForNumAndZeroTest() {
        CheckFindGCDWith(29, 0, 29);
    }

    [Test]
    public void FindGCDForNegativeNumAndZeroTest() {
        CheckFindGCDWith(-43, 0, 43);
    }

    [Test]
    public void FindGCDForOddNumsTest() {
        CheckFindGCDWith(5, 25, 5);
    }

    [Test]
    public void FindGCDForEvenNumsTest() {
        CheckFindGCDWith(32, 256, 32);
    }

    [Test]
    public void FindGCDForEvenAndOddNumsTest() {
        CheckFindGCDWith(210, 49, 7);
    }

    [Test]
    public void FindGCDForSimpleNumsTest() {
        CheckFindGCDWith(13, 17, 1);
    }

    [Test]
    public void FindGCDForTheSameEvenNumsTest() {
        var num = 22;
        
        CheckFindGCDWith(num, num, num);
    }

    [Test]
    public void FindGCDForTheSameNegativeEvenNumsTest() {
        var num = -86;

        CheckFindGCDWith(num, num, -1 * num);
    }

    [Test]
    public void FindGCDForTheSameOddNumsTest() {
        var num = 57;

        CheckFindGCDWith(num, num, num);
    }

    [Test]
    public void FindGCDForTheSameNegativeOddNumsTest() {
        var num = -79;

        CheckFindGCDWith(num, num, -1 * num);
    }

    [Test]
    public void FindGCDForNegativeOddNumsTest() {
        CheckFindGCDWith(-39, -27, 1);
    }

    [Test]
    public void FindGCDForNegativeEvenNumsTest() {
        CheckFindGCDWith(-12, -4, 4);
    }

    [Test]
    public void FindGCDForNegativeOddAndEvenNumsTest() {
        CheckFindGCDWith(-21, 6, 1);
    }

    [Test]
    public void FindGCDForEvenAndNegativeOddNumsTest() {
        CheckFindGCDWith(12, -15, 1);
    }

    [Test]
    public void FindGCDForBigEvenNumsTest() {
        var a = (int) solutions.Exponentiate(2, 16);
        var b = (int) solutions.Exponentiate(2, 30);

        CheckFindGCDWith(a, b, a);
    }

    [Test]
    public void FindGCDForBigOddNumsTest() {
        CheckFindGCDWith(7048935, 27675, 45);
    }

    [Test]
    public void FindGCDForBigOddAndEvenNumsTest() {
        var a = (int) solutions.Exponentiate(2, 28) - 1;
        var b = (int) solutions.Exponentiate(2, 13);

        CheckFindGCDWith(a, b, 1);
    }

    private void CheckFindGCDWith(int a, int b, int expected) {
        var actual = solutions.FindGCD(a, b);

        CheckResult(a, actual);
        CheckResult(b, actual);

        Assert.That(actual, Is.EqualTo(expected));
    }

    private void CheckResult(int num, int gcd) {
        Assert.That(num % gcd, Is.EqualTo(0));
    }
}
