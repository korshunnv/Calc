using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcConsole
{
    class Program
    {
        static void Menu()
        {
            Console.WriteLine("Choose action:");
            Console.WriteLine("1. Addition x+y");//sum
            Console.WriteLine("2. Substraction x-y");//sub
            Console.WriteLine("3. Multiplication x*y");//mult
            Console.WriteLine("4. Division x/y");//div
            Console.WriteLine("5. Root root(x)");//root
            Console.WriteLine("6. Degree x^y");//deg
        }
        static double InputNumber(String str)
        {
            double x;
            Console.WriteLine(str);
            while (!double.TryParse(Console.ReadLine(), out x))
            {
                Console.WriteLine("Input error. Try again.\n"+ str);
            }
            return x;
        }

        static void Main(string[] args)
        {
            String[] actions = { "exit", "sum", "sub", "mult", "div", "root", "deg" };
            Calc calc = new Calc();
            double operand1 = 0.0;
            double operand2 = 0.0;
            double result = 0.0;
            String action = "";
            #region Set values from the command line 
            if (args.Length > 0)
            {
                action = args[0];
                if (!double.TryParse(args[1], out operand1))
                    Console.WriteLine("Error in first operand");
                if (args.Length > 2)
                    if (!double.TryParse(args[2], out operand2))
                        Console.WriteLine("Error in second operand");
            }
            #endregion
            #region Set values from the console 
            else
            {
                int number;
                Menu();
                Console.WriteLine("Input menu: ");
                while (!int.TryParse(Console.ReadLine(), out number))
                {
                    Console.WriteLine("Input error. Try again.\nInput menu:");
                }
                String str = (number == 5) ? "Input operand: " : "Input first operand: ";
                operand1 = InputNumber(str);

                if (number != 5)
                {
                    operand2 = InputNumber("Input second operand: ");
                }
                action = actions[number];
            }
            #endregion
            switch (action)
            {
                case "sum":result = calc.Sum(operand1, operand2); break;
                case "sub": result = calc.Sub(operand1, operand2); break;
                case "mult": result = calc.Mult(operand1, operand2); break;
                case "div":
                    try
                    {
                        result = calc.Div(operand1, operand2);
                    }
                    catch (DivideByZeroException e)
                    {
                        Console.WriteLine(e.Message);
                        Console.ReadKey();
                        return;
                    }
                    break;
                case "root":
                    try
                    {
                        result = calc.Root(operand1);
                    }
                    catch (ArithmeticException e)
                    {
                        Console.WriteLine(e.Message);
                        Console.ReadKey();
                        return;
                    }
                    break;
                case "deg": result = calc.Deg(operand1, operand2); break;
                default: Console.WriteLine("Error action"); break;
            }
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
