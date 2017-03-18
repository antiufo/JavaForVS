namespace Tvl.Java.DebugInterface.Request.Contracts
{
    using System;
    using System.Diagnostics.Contracts;

    [ContractClassFor(typeof(IClassNameFilter))]
    internal abstract class IClassNameFilterContracts : IClassNameFilter
    {
        #region IClassNameFilter Members

        public void AddClassExclusionFilter(string classPattern)
        {
            ContractSlim.Requires<ArgumentNullException>(classPattern != null, "classPattern");
            ContractSlim.Requires<ArgumentException>(!string.IsNullOrEmpty(classPattern));

            throw new NotImplementedException();
        }

        public void AddClassFilter(string classPattern)
        {
            ContractSlim.Requires<ArgumentNullException>(classPattern != null, "classPattern");
            ContractSlim.Requires<ArgumentException>(!string.IsNullOrEmpty(classPattern));

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
