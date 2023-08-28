// Sorting algorithms

using SortingAlgorithms;

var numbers = CollectNumbers.Collect();

var sorter = new SelectSorting().Select();

Console.WriteLine("Sorter numbers {0}", string.Join(",", sorter.Sort(numbers)));