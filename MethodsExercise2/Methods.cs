using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsExercise2
{
    internal class Methods
    {
        public static void NUM()
        {
            Console.WriteLine("Enter the first number: ");
            double putIn1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            double putIn2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Sum of the numbers: ");
            double sumTotal = Methods.Add(putIn1, putIn2);
            Console.WriteLine(sumTotal);
            Console.WriteLine("Product of the numbers: ");
            double multiplicationTotal = Methods.Multiply(putIn1, putIn2);
            Console.WriteLine(multiplicationTotal);
            Console.WriteLine("Subtraction of the numbers: ");
            double subtractionTotal = Methods.Subtract(putIn1, putIn2);
            Console.WriteLine(subtractionTotal);
            Console.WriteLine("Quotient of the numbers: ");
            double divisionTotal = Methods.Divide(putIn1, putIn2);
            Console.WriteLine(divisionTotal);




        }
        public static double Add(double num1, double num2)
        {
            return num1 + num2;
        }
        public static double Multiply(double num1, double num2)
        {
            return num1 * num2;
        }
        public static double Subtract(double num1, double num2)
        {
            return num1 - num2;
        }
        public static double Divide(double num1, double num2)
        {
            return num1 / num2;
        }
    }
}
