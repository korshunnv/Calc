using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcLibrary.Operations
{
    public class MultOperation : NumberOperation
    {
        public override string Name => "mult";
        public override IOperationResult Exec(IEnumerable<double> args)
        {
            return new OperationResult(args.Aggregate((a, b) => a * b), null);

            /*var result = 1.0;
            foreach (var it in args)
            {
                result *= it;
            }
            return new OperationResult(result, "");*/
        }
    }
}
