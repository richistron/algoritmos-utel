namespace SortingAlgorithms;

public class BubbleSort : ISorter
{
    public int[] Sort(int[] items)
    {
        for (int i = 0; i < items.Length - 1; i++)
        {
            for (int j = i + 1; j < items.Length; j++)
            {
                if (items[i] > items[j])
                {
                    (items[i], items[j]) = (items[j], items[i]);
                }
            }
        }

        return items;
    }
}