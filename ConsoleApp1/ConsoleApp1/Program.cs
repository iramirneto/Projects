// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("Iramir Neto");
Console.WriteLine("Version: {0}", Environment.Version.ToString());
// Completed 01/24/2024
// Task 2 was complete by Iramir Neto

string professor = "Dr. Kumar";
Console.WriteLine(professor);

int year = 2024;
Console.WriteLine("We are on the year " + year);

year = 2023;

Console.WriteLine("Last year was " + year);

string[] names = { "Buster", "Potter", "Trouble" };

//print the length
Console.WriteLine("The number of dogs names are: " + names.Length);

//Reverse it
Array.Reverse(names);
Console.WriteLine("\nIn reverse: ");

//Print tem all using foreach loop
foreach (var e in names)
    Console.WriteLine(e.ToString() + " ");

Console.WriteLine("\nUsing foreach method: ");
names.ToList().ForEach(e => Console.WriteLine(e.ToString() + " "));

Console.WriteLine("\n\nUsing Array class and its method:");
Array.ForEach(names, Console.WriteLine);