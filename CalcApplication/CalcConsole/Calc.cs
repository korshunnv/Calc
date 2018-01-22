using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcConsole
{
    public class Calc
    {
        public int Sum(int operand1, int operand2)
        {
            return operand1 + operand2;
        }
        public int Sub(int operand1, int operand2)
        {
            return operand1 - operand2;
        }

        public double Sum(double operand1, double operand2)
        {
            return operand1 + operand2;
        }
        public double Sub(double operand1, double operand2)
        {
            return operand1 - operand2;
        }
        public double Mult(double operand1, double operand2)
        {
            return operand1 * operand2;
        }
        public double Div(double operand1, double operand2)
        {
            if (operand2 == 0.0) throw new DivideByZeroException("Division by zero");
            return operand1 / operand2;
        }

        public double Root(double operand)
        {
            if (operand < 0)
                throw new ArithmeticException("Operand < 0");
            return Math.Sqrt(operand);
        }
        public double Deg(double operand1, double operand2)
        {
            if (operand1 == 0.0)
                return 0.0;
            if (operand1 > 0)
                return Math.Pow(operand1, operand2);
            if (Math.Abs(Math.Truncate(operand2) - operand2) < double.Epsilon)
                return Math.Pow(operand1, operand2);
            else return double.NaN;
        }


    }
}
