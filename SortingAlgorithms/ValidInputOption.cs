namespace SortingAlgorithms;

public readonly struct ValidInputOption
{
    public ValidInputOption(string? value)
    {
        Valid = int.TryParse(value, out var n);
        Value = n;
        Quit = !string.IsNullOrEmpty(value) && value.ToUpper() == "X";
    }

    public bool Valid { get; }
    public int Value { get; }
    public bool Quit { get; }
}