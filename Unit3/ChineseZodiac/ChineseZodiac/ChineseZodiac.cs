using System;

class ChineseZodiac
{
    static void Main()
    {
        Console.WriteLine("Enter a year: ");
        int year = int.Parse(Console.ReadLine());

        string sign = (year % 12) switch
        {
            0 => "monkey",
            1 => "rooster",
            2 => "dog",
            3 => "pig",
            4 => "rat",
            5 => "ox",
            6 => "tiger",
            7 => "rabbit",
            8 => "dragon",
            9 => "snake",
            10 => "horse",
            11 => "sheep",
            _ => throw new InvalidOperationException("Invalid year")
        };

        Console.WriteLine(sign);
    }
}