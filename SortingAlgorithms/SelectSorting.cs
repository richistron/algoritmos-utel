namespace SortingAlgorithms;

public class SelectSorting
{
    private readonly int[] _numbers;

    private readonly SorterOptions[] _options = new[]
        { new SorterOptions("Bubble Sort", 'b'), new SorterOptions("Quick Sort", 'q') };

    public SelectSorting(int[] numbers) => _numbers = numbers;

    public ISorter Select()
    {
        var option = FindOpion(SelectSortingAlgorithm());
        Console.WriteLine("You selected {0}", option.Name);
        if (option.Option == 'b')
            return new BubbleSort(_numbers);
        return new QuickSort(_numbers);
    }

    private char SelectSortingAlgorithm()
    {
        Console.WriteLine("Please select a sorting algorithm");
        var valid = false;
        char option = 'x';
        do
        {
            foreach (var opt in _options)
                Console.WriteLine("\tPress {0} for {1}", opt.Option, opt.Name);
            char.TryParse(Console.ReadLine(), out option);
            valid = IsValidOpion(option);
            Console.WriteLine("Invalid Option, please try again");
        } while (!valid);

        return option;
    }

    private bool IsValidOpion(char option) => Array.Exists(_options, item => item.Option == option);

    private SorterOptions FindOpion(char option) => Array.Find(_options, item => item.Option == option);
}