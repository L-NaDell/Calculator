using System;

namespace Equation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number 1:");
            string a = Console.ReadLine();
            int parsA = int.Parse(a);

            Console.WriteLine("Enter number 2:");
            string b = Console.ReadLine();
            int parsB = int.Parse(b);

            Console.WriteLine("What type of equation would you like to perform? (- / * +) :");
            string selectedOperator = Console.ReadLine();

            string solution = "0";
            if (selectedOperator == "-")
            {
             solution = (parsA - parsB).ToString();
            }
            else if (selectedOperator == "/")
                {
                solution = (parsA / parsB).ToString();
                }
            else if (selectedOperator == "*")
                {
                solution = (parsA * parsB).ToString();
                }
            else if (selectedOperator == "+")
                {
                solution = (parsA + parsB).ToString();
                }
            else
            {
                Console.WriteLine("Error"); 
            }

            Console.WriteLine(parsA + selectedOperator + parsB + "=" + solution );
        }

    }
}
