var numbers = new List<int> { 1,1,5,9,0,9,6 };

Console.WriteLine($"Does the list have any numbers? {numbers.Any()}");
Console.WriteLine($"Total count of numbers: {numbers.Count()}");
Console.WriteLine($"First number: {numbers.First()}");
Console.WriteLine($"Last number: {numbers.Last()}");

IEnumerable<int> distinctNumbers = numbers.Distinct();
foreach (int number in distinctNumbers)
    Console.WriteLine(number);