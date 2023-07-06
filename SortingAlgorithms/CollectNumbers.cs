namespace SortingAlgorithms;

public static class CollectNumbers
{
    private static readonly List<int> Numbers = new List<int>();

    public static IEnumerable<int> Collect()
    {
        bool quit;
        do
        {
            Console.WriteLine("Please enter a number or press 'X' to exit");
            var input = Console.ReadLine();
            ValidInputOption inputOption = new(input);
            AddToCollection(inputOption);
            quit = inputOption.Quit && Numbers.Count > 0;
            // Console.Clear();
        } while (!quit);

        return Numbers;
    }

    private static void AddToCollection(ValidInputOption inputOption)
    {
        if (inputOption.Valid)
            Numbers.Add(inputOption.Value);
        else if (!inputOption.Quit)
            Console.WriteLine("Invalid Value, value most be a number or X");
    }
}