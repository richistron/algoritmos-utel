namespace SortingAlgorithms;

public class QuickSort : ISorter
{
    public QuickSort()
    {
    }

    public int[] Sort(int[] numbers) =>
        SortItems(numbers, 0, numbers.Length - 1);

    private int[] SortItems(int[] items, int start, int end)
    {
        if (end <= start) return items;

        var pivot = Partition(items, start, end);
        SortItems(items, start, pivot - 1);
        SortItems(items, pivot + 1, end);

        return items;
    }

    private int Partition(IList<int> items, int start, int end)
    {
        var pivot = items[end];
        var j = start - 1;
        for (var i = start; i < end; i++)
        {
            if (items[i] > pivot) continue;
            j++;
            (items[i], items[j]) = (items[j], items[i]);
        }

        j++;
        (items[end], items[j]) = (items[j], items[end]);

        return j;
    }
}