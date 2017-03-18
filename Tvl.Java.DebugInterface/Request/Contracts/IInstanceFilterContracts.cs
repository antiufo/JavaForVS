﻿namespace Tvl.Java.DebugInterface.Request.Contracts
{
    using System;
    using System.Diagnostics.Contracts;

    [ContractClassFor(typeof(IInstanceFilter))]
    internal abstract class IInstanceFilterContracts : IInstanceFilter
    {
        #region IInstanceFilter Members

        public void AddInstanceFilter(IObjectReference instance)
        {
            ContractSlim.Requires<ArgumentNullException>(instance != null, "instance");
            ContractSlim.Requires<VirtualMachineMismatchException>(this.GetVirtualMachine().Equals(instance.GetVirtualMachine()));

            throw new NotImplementedException();
        }

        #endregion

        #region IMirror Members

        public IVirtualMachine GetVirtualMachine()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
