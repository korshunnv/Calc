using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcLibrary
{

    public interface IOperation
    {
        /// <summary>
        /// Операция 
        /// </summary>
        String Name { get; }
        /// <summary>
        /// Выполнить операцию с входными значениями
        /// </summary>
        /// <param name="args">Входные параметры</param>
        /// <returns>Результат</returns>



        IOperationResult Exec(string[] args);//, out  string error);


    }
}
