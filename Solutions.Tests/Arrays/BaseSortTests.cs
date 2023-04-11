using ArraysSolutions = SolutionsNotes.Solutions.Arrays;

namespace Solutions.Tests.Arrays;
public class BaseSortTests
{
    private ArraysSolutions solutions;

    protected delegate int[] DelegateSort(int[] nums);

    protected DelegateSort Sort;

    [SetUp]
    public void Setup() {
        solutions = new ArraysSolutions();

        Sort = solutions.QuickSort;
    }

    [Test]
    public void SortNullTest() {
        var actual = Sort(null);

        Assert.NotNull(actual);
        Assert.That(actual.Length, Is.EqualTo(0));
    }

    [Test]
    public void SortEmptyTest() {
        var actual = Sort(Array.Empty<int>());

        Assert.NotNull(actual);
        Assert.That(actual.Length, Is.EqualTo(0));
    }

    [Test]
    public void SortOneNumTest() {
        int[] expected = { 1 };
        var actual = Sort(expected);

        Assert.That(actual.Length, Is.EqualTo(expected.Length));
        Assert.That(actual[0], Is.EqualTo(expected[0]));
    }

    [Test]
    public void SortTheSameNumsTest() {
        int[] expected = { 0, 0, 0, 0, 0, 0, 0 };
        var actual = Sort(expected);

        Assert.That(actual.Length, Is.EqualTo(expected.Length));

        for (var i = 0; i < actual.Length; i++) {
            Assert.That(actual[i], Is.EqualTo(expected[i]));
        }
    }

    [Test]
    public void SortNegativeNumsTest() {
        var expected = new int[] { -4, -17, -58, -3, -67, -33, -21 };
        var actual = Sort(expected);

        Assert.That(actual.Length, Is.EqualTo(expected.Length));

        CommonCheck(actual);
    }

    [Test]
    public void SortPositiveNumsTest() {
        var expected = new int[] { 22, 6, 78, 19, 64, 0, 34, 59, 37, 13, 6, 0, 1, 2, 1 };
        var actual = Sort(expected);

        Assert.That(actual.Length, Is.EqualTo(expected.Length));

        CommonCheck(actual);
    }

    [Test]
    public void SortNegativeAndPositiveNumsTest() {
        var expected = new int[] { -48, -6, -89, 77, -55, 82, -66, 31, 27, 64, 45, 9, 81, -64, 26, 47, 5, 88, -78, 54 };
        var actual = Sort(expected);

        Assert.That(actual.Length, Is.EqualTo(expected.Length));

        CommonCheck(actual);
    }

    [Test]
    public void SortSequenceNumsTest() {
        var expected = new int[100];

        for (var i = 0; i < expected.Length; i++) {
            expected[i] = i;
        }

        var actual = Sort(expected);

        Assert.That(actual.Length, Is.EqualTo(expected.Length));

        CommonCheck(actual);
    }

    [Test]
    public void SortReverseSequenceNumsTest() {
        var expected = new int[100];

        for (var i = expected.Length - 1; i >=0; i--) {
            expected[i] = i;
        }

        var actual = Sort(expected);

        Assert.That(actual.Length, Is.EqualTo(expected.Length));

        CommonCheck(actual);
    }

    [Test]
    public void SortRandomSetOfNumsTest() {
        var expected = new int[100];
        var generator = new Random();

        for (var i = expected.Length - 1; i >= 0; i--) {
            expected[i] = generator.Next(-100, 100);
        }

        var actual = Sort(expected);

        Assert.That(actual.Length, Is.EqualTo(expected.Length));

        CommonCheck(actual);
    }

    private void CommonCheck(int[] actual) {
        for (var i = 1; i < actual.Length; i++) {
            Assert.LessOrEqual(actual[i - 1], actual[i]);
        }
    }
}
