using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcLibrary.Operations
{
    public class DivOperation : NumberOperation
    {
        public override string Name => "div";
        public override IOperationResult Exec(IEnumerable<double> args)
        {
            var result = 0.0;
            if (args.Count() >= 2)
            {
                if (args.ElementAt(1) == 0)
                {
                    return new OperationResult(double.NaN, "Division by zero");
                }
                else
                {
                    result = args.ElementAt(0) / args.ElementAt(1);
                    return new OperationResult(result, "");
                }
            }
            return new OperationResult(double.NaN, "");
        }
    }
}
