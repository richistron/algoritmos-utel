using SortingAlgorithms;

namespace Specs;

[TestFixture]
public class BubbleSortTest
{
    [Test]
    [TestCase(new[] { 9, 5, 3, 0 }, new[] { 0, 3, 5, 9 })]
    [TestCase(new[] { 100, 500, 1 }, new[] { 1, 100, 500 })]
    public void Sort_Array(int[] input, int[] output) => Assert.That(BubbleSort.Sort(input), Is.EquivalentTo(output));
}