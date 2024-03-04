DisplayMeasurement(-4);  // Output: Measured value is -4; out of an acceptable range.
DisplayMeasurement(50);  // Output: Measured value is 50.
DisplayMeasurement(132);  // Output: Measured value is 132; out of an acceptable range.

void DisplayMeasurement(int measurement)
{
    string result = measurement switch
    {
        < 0 => $"Measured value is {measurement}; out of an acceptable range.",
        > 100 => $"Measured value is {measurement}; out of an acceptable range.",
        _ => $"Measured value is {measurement}."
    };

    Console.WriteLine(result);
}   