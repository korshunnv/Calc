using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcLibrary
{
     public class OperationResult : IOperationResult
    {
        public OperationResult(double result, string error)
        {
            Result = result;
            Error = error;
        }

        public string Error { get; set; }

        public double Result { get; set; }
    }
}
