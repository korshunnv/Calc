using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcLibrary
{
    public abstract class NumberOperation : IOperation
    {
        public virtual string Name => "";

        public IOperationResult Exec(string[] args)
        {
            if (args.Length > 0)
            {
                var numbers = args.Select(it => Convert.ToDouble(it));
                return Exec(numbers);
            }
            return Exec(new double[] { });
        }

        public abstract IOperationResult Exec(IEnumerable<double> args);
    }
}
