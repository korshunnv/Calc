using CalcLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcConsole
{
    class Program
    {
        
        //переделать!!! не хорошо
        static Dictionary<string, string> NumberOperation = new Dictionary<string, string>()
            {
                {"1","sum"},
                {"2","sub"},
                {"3","mult"},
                {"4","div"},
                {"5","root"}

            };

        //соединить 
        static string MenuString
        {
         get
            {
                StringBuilder menuString = new StringBuilder();
                menuString.Append("Choose action:\n");
                menuString.Append("0. Exit\n");
                menuString.Append("1. Addition x+y\n");
                menuString.Append("2. Substraction x-y\n");//sub
                menuString.Append("3. Multiplication x*y\n");//mult
                menuString.Append("4. Division x/y\n");//div
                menuString.Append("5. Root root(x)\n\n");//root
                menuString.Append("Input number: ");//root
                return menuString.ToString();
            }
        }
        static void Main(string[] args)
        {
            Calc calc = new Calc();
            Console.WriteLine(MenuString);
            var number = Console.ReadLine();

            string oper = NumberOperation[number];
            string [] values = { "10", "0" };

            var result = calc.Exec(oper, values);
            Console.WriteLine($"{oper}({values[0]}, {values[1]})={result}");
            Console.ReadKey();


            #region Старое решение
            /*Dictionary<String, Func<double, double, double>> dict;
            String[] actions = { "exit", "sum", "sub", "mult", "div", "root"};
            Calc calc = new Calc();
            dict = new Dictionary<string, Func<double, double, double>>()
            {
                {"sum",  (x,y)=>calc.Sum(x,y)},
                {"sub",  (x,y)=>calc.Sub(x,y)},
                {"mult",  (x,y)=>calc.Mult(x,y)},
                {"div",  (x,y)=>calc.Div(x,y)},
                {"root",  (x,y)=>calc.Root(x)},
                {"deg",  (x,y)=>calc.Deg(x,y)}
            };
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

                try
                {
                    result = dict[action](operand1, operand2);
                    Console.WriteLine(result);
                }
                catch (DivideByZeroException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (ArithmeticException e)
                {
                    Console.WriteLine(e.Message);
                }
                Console.ReadKey();

            }
            #endregion

            else
            {
                int number;
                do
                {
                    Console.Clear();
                    Menu();
                    #region Set values from the console 
                    Console.WriteLine("Input menu: ");
                    while (!int.TryParse(Console.ReadLine(), out number))
                    {
                        Console.WriteLine("Input error. Try again.\nInput menu:");
                    }
                    if (number == 0) break;
                    String str = (number == 5) ? "Input operand: " : "Input first operand: ";
                    operand1 = InputNumber(str);

                    if (number != 5)
                    {
                        operand2 = InputNumber("Input second operand: ");
                    }
                    action = actions[number];

                    try
                    {
                        result = dict[action](operand1, operand2);
                    }
                    catch (DivideByZeroException e)
                    {
                        Console.WriteLine(e.Message);
                        Console.ReadKey();
                        return;
                    }
                    catch (ArithmeticException e)
                    {
                        Console.WriteLine(e.Message);
                        Console.ReadKey();
                        return;
                    }
                    #endregion
                    /*switch (action)
                    {
                        case "sum": result = calc.Sum(operand1, operand2); break;
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
                    }*/
            /*Console.WriteLine(result);
            Console.ReadKey();
        }
        while (number != 0);
        Console.ReadKey();
    }*/
            #endregion
        }
    }
}
