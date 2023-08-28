// Sorting algorithms

using SortingAlgorithms;

var numbers = CollectNumbers.Collect();

var sortingAlgorithm = new SelectSorting(numbers);

ISorter sorter = sortingAlgorithm.Select();

Console.WriteLine("Sorter numbers {0}", string.Join(",", sorter.Sort()));