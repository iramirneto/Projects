int[] array = { 1, 1, 5, 9, 0, 9, 6, 11, 59, 0,96 };
//1159096
var filteredArray =         // LINQ query
    from elements in array
    where elements < 7
    select elements;

PrintArray(filteredArray, "All values less than 7:");

//Console.WriteLine("\nWith Lambda:");
//IEnumerable<int> filteredArray2 = array.Where(element => element < 7);
//filteredArray2.ToList().ForEach(element => Console.WriteLine(element));

var orderedFilteredArray =
     from elements in array
     where elements < 7
     orderby elements descending
     select elements;

PrintArray(orderedFilteredArray,
"All values less than 7 and sorted:");

static void PrintArray(IEnumerable<int> arr, string message)
{
    Console.WriteLine($"{message}");

    foreach (var element in arr)
        Console.WriteLine($" {element}");
}