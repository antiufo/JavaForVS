using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace System.Diagnostics.Contracts
{
    internal class ContractSlim
    {
        [Conditional("NEVER")]
        public static void Requires<T>(bool v1, string v2)
        {
        }

        [Conditional("NEVER")]
        public static void Requires<T>(bool v)
        {
        }
    }
}
