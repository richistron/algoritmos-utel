namespace SortingAlgorithms;

public struct SorterOptions
{
    public SorterOptions(string name, char option)
    {
        Name = name;
        Option = option;
    }

    public readonly string Name;
    public readonly char Option;
}