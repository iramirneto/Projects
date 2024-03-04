using Unit1;

//Iramir Neto
//CPS3330*01
//Lab #2

namespace TestRoot
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            double average;
            do
            {
                Console.Write("Enter a first number: ");
                a = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter a second number: ");
                b = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter a third number: ");
                c = Convert.ToDouble(Console.ReadLine());
                if (a < 0 || b < 0 || c < 0)
                    Console.WriteLine("Please enter a positive number!");
            } while (a < 0 || b < 0 || c < 0);

            average = Unit1.Average.Ave(a,b,c);
        }
    } 
} 