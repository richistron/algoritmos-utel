namespace SortingAlgorithms;

public class BubbleSort : ISorter
{
    private readonly int[] _items;

    public BubbleSort(int[] items)
    {
        _items = items;
    }

    public int[] Sort()
    {
        for (int i = 0; i < _items.Length - 1; i++)
        {
            for (int j = i + 1; j < _items.Length; j++)
            {
                if (_items[i] > _items[j])
                {
                    (_items[i], _items[j]) = (_items[j], _items[i]);
                }
            }
        }

        return _items;
    }
}