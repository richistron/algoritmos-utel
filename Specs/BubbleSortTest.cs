namespace Specs;

using SortingAlgorithms;

[TestFixture]
public class BubbleSortTest
{
    [Test]
    [TestCase(new[] { 9, 0, 3, 5 }, new[] { 0, 3, 5, 9 })]
    [TestCase(new[] { 100, 1, 500 }, new[] { 1, 100, 500 })]
    [TestCase(new[] { 100, 500, 0 }, new[] { 0, 100, 500 })]
    [TestCase(new[] { 5, 4, 3, 2, 1 }, new[] { 1, 2, 3, 4, 5 })]
    [TestCase(new[] { 2, 1 }, new[] { 1, 2 })]
    [TestCase(new[] { 2 }, new[] { 2 })]
    public void Sort_Array(int[] input, int[] output) =>
        CollectionAssert.AreEqual(new BubbleSort().Sort(input), output);
}