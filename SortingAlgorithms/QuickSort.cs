namespace SortingAlgorithms;

public class QuickSort: ISorter
{
    private readonly int[] _numbers;
    public QuickSort(int[] numbers) => _numbers = numbers;

    public int[] Sort() =>
        SortItems(_numbers, 0, _numbers.Length - 1);

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