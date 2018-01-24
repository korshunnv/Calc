﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcLibrary.Operations
{
    public class SumOperation : NumberOperation
    {
        public override string Name => "sum";

        public override IOperationResult Exec(IEnumerable<double> args)
        {
            return new OperationResult(args.Sum(), "");
        }
    }


}
