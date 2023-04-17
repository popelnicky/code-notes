using ArraysSolutions = SolutionsNotes.Solutions.Arrays;

namespace Solutions.Tests.Arrays;
public class MergeSortTests : BaseSortTests
{
    private ArraysSolutions solutions;

    [SetUp]
    public new void Setup() {
        solutions = new ArraysSolutions();

        Sort = solutions.MergeSort;
    }
}
