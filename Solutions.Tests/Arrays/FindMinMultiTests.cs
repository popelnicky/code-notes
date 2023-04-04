using ArraysSolutions = SolutionsNotes.Solutions.Arrays;

namespace Solutions.Tests.Arrays;
public class FindMinMultiTests
{
    private ArraysSolutions solutions;

    [SetUp]
    public void Setup() {
        solutions = new ArraysSolutions();
    }

    [Test]
    public void FindMinMultiForNullTest() {
        var actual = solutions.FindMinMulti(null);

        Assert.That(actual, Is.EqualTo(0));
    }

    [Test]
    public void FindMinMultiForEmptyTest() {
        var actual = solutions.FindMinMulti(Array.Empty<int>());

        Assert.That(actual, Is.EqualTo(0));
    }

    [Test]
    public void FindMinMultiForOneTest() {
        var actual = solutions.FindMinMulti(new int[] { 1 });

        Assert.That(actual, Is.EqualTo(0));
    }

    [Test]
    public void FindMinMultiForTwoTest() {
        var actual = solutions.FindMinMulti(new int[] { 2, 9 });

        Assert.That(actual, Is.EqualTo(18));

        actual = solutions.FindMinMulti(new int[] { 8, 3 });

        Assert.That(actual, Is.EqualTo(24));
    }

    [Test]
    public void FindMinMultiForZerosTest() {
        var actual = solutions.FindMinMulti(new int[] { 0, 0, 0, 0, 0 });

        Assert.That(actual, Is.EqualTo(0));
    }

    [Test]
    public void FindMinMultiForAllTheSameTest() {
        var actual = solutions.FindMinMulti(new int[] { 5, 5, 5, 5, 5 });

        Assert.That(actual, Is.EqualTo(25));
    }

    [Test]
    public void FindMinMultiForTheSameInTheStartTest() {
        var actual = solutions.FindMinMulti(new int[] { 2, 2, 4, 7, 3, 6, 5 });

        Assert.That(actual, Is.EqualTo(4));
    }

    [Test]
    public void FindMinMultiForTheSameOnTheEndTest() {
        var actual = solutions.FindMinMulti(new int[] { 5, 3, 7, 6, 4, 1, 1 });

        Assert.That(actual, Is.EqualTo(1));
    }

    [Test]
    public void FindMinMultiForTheSameInTheMiddleTest() {
        var actual = solutions.FindMinMulti(new int[] { 5, 7, 4, 2, 2, 3, 6 });

        Assert.That(actual, Is.EqualTo(4));
    }

    [Test]
    public void FindMinMultiForTheSameOnTheBordersTest() {
        var actual = solutions.FindMinMulti(new int[] { 3, 6, 4, 4, 5, 6, 3 });

        Assert.That(actual, Is.EqualTo(9));
    }

    [Test]
    public void FindMinMultiForSequenceTest() {
        var nums = new int[7];

        for (var i = 1; i <= nums.Length; i++) {
            nums[i - 1] = i;
        }

        var actual = solutions.FindMinMulti(nums);

        Assert.That(actual, Is.EqualTo(2));
    }

    [Test]
    public void FindMinMultiForReverseSequenceTest() {
        var nums = new int[7];

        for (var i = nums.Length; i > 0; i--) {
            nums[i - 1] = i;
        }

        var actual = solutions.FindMinMulti(nums);

        Assert.That(actual, Is.EqualTo(2));
    }

    [Test]
    public void FindMinMultiForNormalTest() {
        var actual = solutions.FindMinMulti(new int[] { 9, 5, 7, 2, 4, 3, 5 });

        Assert.That(actual, Is.EqualTo(6));
    }
}
