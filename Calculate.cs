using System;
namespace Calculator
{
    public class Calculate
    {
        public static double calculate(double num1, double num2, string oper)
        {

            double result = 0;

            switch (oper)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    while (num2 == 0) { Console.WriteLine("Please enter a non-zero number: ");
                        string numS = Console.ReadLine();
                        double num2clean;
                        while (!double.TryParse(numS, out num2clean))
                        {
                            Console.WriteLine("Please enter a numeric value: ");
                            numS = Console.ReadLine();

                        }
                    }
                    result = num1 / num2;
                    break;
            }

            return result;


        }
    }
}
