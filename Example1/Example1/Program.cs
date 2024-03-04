using static System.Console;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


double a, root;
do
{
    Write("Enter a number: "); // System.out.print
    a = Convert.ToDouble(ReadLine()); //Scanner input and conversion

    if (a < 0)
        WriteLine("Enter a positive number!");// +next line
} while (a < 0);

root = Math.Sqrt(a);

//WriteLine("The square root of " + a + " is " + root);
WriteLine("The square root of {0} is {1}", a, root);
WriteLine("The square root of {0,-12} is {1,-12}", a, root);
WriteLine("The square root of {0,12} is {1,12}", a, root);
