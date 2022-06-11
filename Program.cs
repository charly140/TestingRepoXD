using System;

namespace Calculator
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Console Calculator in C#");
            Console.WriteLine(" ------------------------");
            bool endApp = false;

            while(!endApp){ 
                string num1 = "";
                string num2 = "";
                string opStr = "";
                double result = 0;



                Console.WriteLine("Type first number, and press enter");
                num1 = Console.ReadLine();

                double num1clean;
                while (!double.TryParse(num1, out num1clean)) {
                    Console.WriteLine("Please enter a numeric value: ");
                    num1 = Console.ReadLine();

                }

                Console.WriteLine("Type second number, and press enter");
                num2 = Console.ReadLine();

                double num2clean;
                while (!double.TryParse(num2, out num2clean)) {
                    Console.WriteLine("Please enter a numeric value: ");
                    num2 = Console.ReadLine();

                }

                Console.WriteLine("Selete the tipe of operation to be performed and press enter");
                Console.WriteLine(" + sum");
                Console.WriteLine(" - supstract");
                Console.WriteLine(" * multiply");
                Console.WriteLine(" / division");

                opStr = Console.ReadLine();

                try
                {
                    result = Calculate.calculate(num1clean, num2clean, opStr);
                    if (double.IsNaN(result))
                    {
                        Console.WriteLine("This operation will result in a mathematical error.\n");
                    }
                    else
                    {
                        Console.WriteLine($"The result from {num1clean} {opStr} {num2clean} = {result}");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("An exception ocurred trying do the math.\n - Details: " + e.Message);
                }


                Console.WriteLine("Press 'n' and Enter to close the app, or press any other key and Enter to continuer: ");
                if (Console.ReadLine() == "n") endApp = true;

              //  Console.WriteLine("\n"); // Friendly linespacing
            }
            return;

        }
        /*
        public static double setectOperation(string str, double num1, double num2) => str switch
        {
            "+" => num1 + num2,
            "-" => num1 - num2,

            _ => throw new ArgumentException($"Not supported number of visitors: {str}"),
        };
        */


        
    }
}
