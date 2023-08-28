namespace SortingAlgorithms;

public static class QuickSort
{
    public static IEnumerable<int> Sort(int[] items) =>
        SortItems(items, 0, items.Length - 1);

    private static int[] SortItems(int[] items, int start, int end)
    {
        if (end <= start) return items;

        var pivot = Partition(items, start, end);
        SortItems(items, start, pivot - 1);
        SortItems(items, pivot + 1, end);

        return items;
    }

    private static int Partition(IList<int> items, int start, int end)
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