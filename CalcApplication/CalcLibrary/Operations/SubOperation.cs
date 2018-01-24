using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcLibrary.Operations
{
    class SubOperation : NumberOperation
    {
        public override string Name => "sub";

        public override IOperationResult Exec(IEnumerable<double> args)
        {
            var result = 0.0;
            result = args.Count() >= 2
                    ? args.ElementAt(0) - args.ElementAt(1) :
                    double.NaN;

            return new OperationResult(result, "");
        }
    }
}
