using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalcLibrary.Operations;
using System.Reflection;

namespace CalcLibrary
{
    public class Calc
    {
        private IList<IOperation> Operations;
        public Calc()
        {
            Operations = new List<IOperation>();
            //var curAssembly = Assembly.GetExecutingAssembly();
            var curAssembly = Assembly.LoadFile(
                @"D:\Калькулятор\Calc\CalcApplication\CalcConsole\bin\Debug\extention\Exit.Calculator.Finance.dll"
            );

            var types = curAssembly.GetTypes();

            foreach (var type in types)
            {
                if (type.IsAbstract|| type.IsInterface)
                    continue;

                var interfaces = type.GetInterfaces();
                if (interfaces.Contains(typeof(IOperation)))
                {
                    var obj = Activator.CreateInstance(type) as IOperation;
                    if (obj != null)
                    {
                        Operations.Add(obj);
                    }
                }
            }

            //рефлексия
            //var sumType = typeof(SumOperation);
            //sumType.GetMethods();
            //sumType.GetInterfaces();

        }


       /* public string[] GetOperationNames()
        {
            return Operations.Select(it=>it.Name);//помотреть
        }*/

        public double Exec(string operationName, string[] args)
        {
            IOperation oper;

            #region комментарий
            //select top 1*
            //from Operations
            //where Name=operationName

            //oper = Operations
            //        .Where(it => it.Name == operationName)
            //        .FirstOrDefault();

            // лучше сразу FirstOrDefault без Where

            //Это литературный подход!!!
            //найти операцию в списке операций
            //foreach (var item in Operations)
            //{
            //    if (item.Name == operationName)
            //    {
            //        oper = item;
            //        break;
            //    }
            //}
            #endregion

            oper = Operations.FirstOrDefault(it => it.Name == operationName);
            //если не удалось найти - возвращаем NaN
            if (oper == null)
            {
                return double.NaN;
            }
            //иначе 
            //вычисляем результат операции
            var result = oper.Exec(args);

            //если в результате ошибка заполнена
            if (!string.IsNullOrWhiteSpace(result.Error))
            {
                //выводим ее на экран
            }
            else
            {
                //иначе выводим результат
                return result.Result;
            }
            return double.NaN;
        }


        #region int
        [Obsolete("НЕ ИСПОЛЬЗОВАТЬ", true)]//атрибут для того, что метод устарел
        //true - 
        public int Sum(int operand1, int operand2)
        {
            return (int)Sum((double)operand1, (double)operand2);
        }
        public int Sub(int operand1, int operand2)
        {
            return (int)Sub((double)operand1, (double)operand2);
        }
        #endregion

        #region double


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

        public double Root(double operand1, double operand2=0)
        {
            if (operand1 < 0)
                throw new ArithmeticException("Operand < 0");
            return Math.Sqrt(operand1);
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

        #endregion
    }
}
