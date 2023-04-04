using ArraysSolutions = SolutionsNotes.Solutions.Arrays;

namespace Solutions.Tests.Arrays;

public class FizzBuzzTests
{
    private ArraysSolutions solutions;

    private const string FIZZ = "fizz";
    private const string BUZZ = "buzz";
    private const string FIZZBUZZ = "fizzbuzz";

    [SetUp]
    public void Setup() {
        solutions = new ArraysSolutions();
    }

    [Test]
    public void FizzBuzzNullTest() {
        var actual = solutions.FizzBuzz(null);

        BaseCheck(actual, 0);
    }

    [Test]
    public void FizzBuzzEmptyTest() {
        var actual = solutions.FizzBuzz(Array.Empty<int>());

        BaseCheck(actual, 0);
    }

    [Test]
    public void FizzBuzzOneElementTest() {
        var actual = solutions.FizzBuzz(new int[1] { 4 });

        BaseCheck(actual, 1);
        
        Assert.That(actual[0], Is.EqualTo("4"));
    }

    [Test]
    public void FizzBuzzAllZerosTest() {
        var nums = new int[4] { 0, 0, 0, 0 };
        var actual = solutions.FizzBuzz(nums);

        BaseCheck(actual, nums.Length);

        for (var i = 0; i < nums.Length; i++) {
            Assert.That(actual[i], Is.EqualTo(FIZZBUZZ));

            Assert.That(actual[i], Is.Not.EqualTo(nums[i].ToString()));
        }
    }

    [Test]
    public void FizzBuzzNoFizzBuzzTest() {
        var nums = new int[9] { 1, 2, 4, 7, 8, 11, 13, 14, 16 };
        var actual = solutions.FizzBuzz(nums);

        BaseCheck(actual, nums.Length);

        for (var i = 0; i < nums.Length; i++) {
            Assert.That(actual[i], Is.Not.EqualTo(FIZZ));
            Assert.That(actual[i], Is.Not.EqualTo(BUZZ));
            Assert.That(actual[i], Is.Not.EqualTo(FIZZBUZZ));
            
            Assert.That(actual[i], Is.EqualTo(nums[i].ToString()));
        }
    }

    [Test]
    public void FizzBuzzOnlyFizzTest() {
        var nums = new int[6] { 3, 3, 27, 39, 12, 66 };
        var actual = solutions.FizzBuzz(nums);

        BaseCheck(actual, nums.Length);

        for (var i = 0; i < nums.Length; i++) {
            Assert.That(actual[i], Is.EqualTo(FIZZ));
            Assert.That(actual[i], Is.Not.EqualTo(BUZZ));
            Assert.That(actual[i], Is.Not.EqualTo(FIZZBUZZ));

            Assert.That(actual[i], Is.Not.EqualTo(nums[i].ToString()));
        }
    }

    [Test]
    public void FizzBuzzOnlyBuzzTest() {
        var nums = new int[6] { 5, 100, 55, 70, 20, 65 };
        var actual = solutions.FizzBuzz(nums);

        BaseCheck(actual, nums.Length);

        for (var i = 0; i < nums.Length; i++) {
            Assert.That(actual[i], Is.EqualTo(BUZZ));
            Assert.That(actual[i], Is.Not.EqualTo(FIZZ));
            Assert.That(actual[i], Is.Not.EqualTo(FIZZBUZZ));

            Assert.That(actual[i], Is.Not.EqualTo(nums[i].ToString()));
        }
    }

    [Test]
    public void FizzBuzzOnlyFizzBuzzTest() {
        var nums = new int[6] { 45, 60, 15, 120, 75, 105 };
        var actual = solutions.FizzBuzz(nums);

        BaseCheck(actual, nums.Length);

        for (var i = 0; i < nums.Length; i++) {
            Assert.That(actual[i], Is.EqualTo(FIZZBUZZ));
            Assert.That(actual[i], Is.Not.EqualTo(FIZZ));
            Assert.That(actual[i], Is.Not.EqualTo(BUZZ));

            Assert.That(actual[i], Is.Not.EqualTo(nums[i].ToString()));
        }
    }

    [Test]
    public void FizzBuzzOnlyFizzAndBuzzTest() {
        var nums = new int[6] { 12, 35, 21, 20, 39, 40 };
        var actual = solutions.FizzBuzz(nums);

        BaseCheck(actual, nums.Length);

        for (var i = 0; i < nums.Length; i++) {
            if (i == 0 || i == 2 || i == 4) {
                Assert.That(actual[i], Is.EqualTo(FIZZ));
                Assert.That(actual[i], Is.Not.EqualTo(BUZZ));
                Assert.That(actual[i], Is.Not.EqualTo(FIZZBUZZ));

                Assert.That(actual[i], Is.Not.EqualTo(nums[i].ToString()));
            }

            if (i == 1 || i == 3 || i == 5) {
                Assert.That(actual[i], Is.EqualTo(BUZZ));
                Assert.That(actual[i], Is.Not.EqualTo(FIZZ));
                Assert.That(actual[i], Is.Not.EqualTo(FIZZBUZZ));

                Assert.That(actual[i], Is.Not.EqualTo(nums[i].ToString()));
            }
        }
    }

    [Test]
    public void FizzBuzzSmallNormalSequenceTest() {
        var nums = new int[4] { 1, 2, 3, 4 };
        var actual = solutions.FizzBuzz(nums);

        BaseCheck(actual, nums.Length);

        for (var i = 1; i <= actual.Length; i++) {
            var elem = actual[i - 1];

            if (i == 3) {
                Assert.That(elem, Is.EqualTo(FIZZ));
                Assert.That(elem, Is.Not.EqualTo(BUZZ));
                Assert.That(elem, Is.Not.EqualTo(FIZZBUZZ));

                continue;
            }

            Assert.That(elem, Is.EqualTo(i.ToString()));
        }
    }

    [Test]
    public void FizzBuzzNormalSequenceTest() {
        var nums = new int[16];

        for (var i = 0; i < nums.Length; i++) {
            nums[i] = i;
        }

        var actual = solutions.FizzBuzz(nums);

        BaseCheck(actual, nums.Length);

        for (var i = 0; i < actual.Length; i++) {
            var elem = actual[i];

            if (i == 3 || i == 6 || i == 9 || i == 12) {
                Assert.That(elem, Is.EqualTo(FIZZ));
                Assert.That(elem, Is.Not.EqualTo(BUZZ));
                Assert.That(elem, Is.Not.EqualTo(FIZZBUZZ));

                continue;
            }

            if (i == 5 || i == 10) {
                Assert.That(elem, Is.EqualTo(BUZZ));
                Assert.That(elem, Is.Not.EqualTo(FIZZ));
                Assert.That(elem, Is.Not.EqualTo(FIZZBUZZ));

                continue;
            }

            if (i == 0 || i == 15) {
                Assert.That(elem, Is.EqualTo(FIZZBUZZ));
                Assert.That(elem, Is.Not.EqualTo(FIZZ));
                Assert.That(elem, Is.Not.EqualTo(BUZZ));

                continue;
            }

            Assert.That(elem, Is.EqualTo(i.ToString()));
        }
    }

    [Test]
    public void FizzBuzzNormalTest() {
        var nums = new int[11] { 7, 9, 11, 45, 14, 25, 67, 44, 21, 79, 30 };
        var actual = solutions.FizzBuzz(nums);

        BaseCheck(actual, nums.Length);

        for (var i = 0; i < nums.Length; i++) {
            var elem = actual[i];

            if (i == 1 || i == 8) {
                Assert.That(elem, Is.EqualTo(FIZZ));
                Assert.That(elem, Is.Not.EqualTo(BUZZ));
                Assert.That(elem, Is.Not.EqualTo(FIZZBUZZ));

                continue;
            }

            if (i == 5) {
                Assert.That(elem, Is.EqualTo(BUZZ));
                Assert.That(elem, Is.Not.EqualTo(FIZZ));
                Assert.That(elem, Is.Not.EqualTo(FIZZBUZZ));

                continue;
            }

            if (i == 3 || i == 10) {
                Assert.That(elem, Is.EqualTo(FIZZBUZZ));
                Assert.That(elem, Is.Not.EqualTo(FIZZ));
                Assert.That(elem, Is.Not.EqualTo(BUZZ));

                continue;
            }

            Assert.That(elem, Is.EqualTo(nums[i].ToString()));
        }
    }

    private void BaseCheck(string[] actual, int expectedLength) {
        Assert.IsNotNull(actual);
        
        Assert.That(actual.Length, Is.EqualTo(expectedLength));
    }
}
