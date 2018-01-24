using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcLibrary.Operations
{
    public class RootOperation : NumberOperation
    {
        public override string Name => "root";
        public override IOperationResult Exec(IEnumerable<double> args)
        {
            var result = 0.0;
            if (args.Count() >= 1)
            {
                if (args.ElementAt(0) <0)
                {
                    return new OperationResult(double.NaN, "Number < 0");
                }
                else
                {
                    result = Math.Sqrt(args.ElementAt(0));
                    return new OperationResult(result, "");
                }
            }
            return new OperationResult(double.NaN, "");
        }
    }
}
