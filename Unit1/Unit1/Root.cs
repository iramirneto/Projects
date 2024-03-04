namespace Unit1;

//Iramir Neto
//CPS3330*01
//Lab #2

public class Average
{
    /// <summary>
    /// this method calculates the root
    /// </summary>
    /// <param name="number"></param>
    /// <returns></returns>
    public static double Ave(double number1, double number2, double number3)
    {
        double average;
        average = (number1 + number2 + number3)/3;

        Console.WriteLine("The average of three numbers:" + number1 + ", " + number2 + " and " + number3 + " is " + average);
        return average;
    }
}