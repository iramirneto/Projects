namespace MyAveLib;

public class Average
{
    public static double Ave(double num1, double num2, double num3) {
        double ave;
        ave = (num1+num2+num3)/3.0;

        Console.WriteLine("The average is " + ave);
        
        return ave;
    }
    
}          