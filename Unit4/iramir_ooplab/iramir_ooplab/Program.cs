using System.Reflection.Metadata;
using static System.Console;
namespace iramir_opplab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Employee e = new();
            Write(e.id);
            e.WelcomeMessage();

            (string, int) me = e.GetData();
            WriteLine($"My Data: {me.Item1},{me.Item2}");

            (string, string, int) me2 = e.GetFullData();
            WriteLine($"My Full Data: {me2.Item1},{me2.Item2},{me2.Item3}");

            e.PrintFullData(1, e);
        }
    }

    class Employee
    {
        protected internal int id = 111; //assigned
        protected internal string firstName = "Iramir";
        protected internal string occupation = "Professor";

        internal void WelcomeMessage()
        {
            WriteLine($"Hello to you from employee {id}");
        }

        internal (string, int) GetData()
        {
            return ("Iramir", id);
        }

        internal (string, string, int) GetFullData()
        {
            return ("Iramir", "Professor", id);
        }

        internal protected void PrintFullData(int order, Employee e)
        {
            Write(order);
            e.GetFullData();
            //destruc the tuple
            (string fName, string r, int keanid) = e.GetFullData;
            WriteLine($"Desconstructed: {fName},{r},{keanid}");  

        }
    }
}