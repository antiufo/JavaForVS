namespace Tvl.Java.DebugInterface.Contracts
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Diagnostics.Contracts;

    [ContractClassFor(typeof(IObjectReference))]
    internal abstract class IObjectReferenceContracts : IObjectReference
    {
        #region IObjectReference Members

        public void DisableCollection()
        {
            throw new NotImplementedException();
        }

        public void EnableCollection()
        {
            throw new NotImplementedException();
        }

        public int GetEntryCount()
        {
            Contract.Ensures(Contract.Result<int>() >= 0);

            throw new NotImplementedException();
        }

        public IValue GetValue(IField field)
        {
            ContractSlim.Requires<ArgumentNullException>(field != null, "field");
            ContractSlim.Requires<VirtualMachineMismatchException>(this.GetVirtualMachine().Equals(field.GetVirtualMachine()));
            Contract.Ensures(Contract.Result<IValue>() == null || this.GetVirtualMachine().Equals(Contract.Result<IValue>().GetVirtualMachine()));

            throw new NotImplementedException();
        }

        public IDictionary<IField, IValue> GetValues(IEnumerable<IField> fields)
        {
            ContractSlim.Requires<ArgumentNullException>(fields != null, "fields");
            ContractSlim.Requires<ArgumentException>(Contract.ForAll(fields, field => field != null));
            ContractSlim.Requires<VirtualMachineMismatchException>(Contract.ForAll(fields, field => this.GetVirtualMachine().Equals(field.GetVirtualMachine())));
            Contract.Ensures(Contract.Result<IDictionary<IField, IValue>>() != null);
#if CONTRACTS_FORALL
            Contract.Ensures(Contract.ForAll(Contract.Result<IDictionary<IField, IValue>>(), pair => pair.Key != null));
            Contract.Ensures(Contract.ForAll(Contract.Result<IDictionary<IField, IValue>>(), pair => this.GetVirtualMachine().Equals(pair.Key.GetVirtualMachine()) && (pair.Value == null || this.GetVirtualMachine().Equals(pair.Value.GetVirtualMachine()))));
#endif

            throw new NotImplementedException();
        }

        public IStrongValueHandle<IValue> InvokeMethod(IThreadReference thread, IMethod method, InvokeOptions options, params IValue[] arguments)
        {
            ContractSlim.Requires<ArgumentNullException>(method != null, "method");
            ContractSlim.Requires<VirtualMachineMismatchException>(thread == null || this.GetVirtualMachine().Equals(thread.GetVirtualMachine()));
            ContractSlim.Requires<VirtualMachineMismatchException>(method.GetVirtualMachine().Equals(this.GetVirtualMachine()));
#if CONTRACTS_FORALL
            ContractSlim.Requires<VirtualMachineMismatchException>(arguments == null || Contract.ForAll(arguments, argument => argument == null || this.GetVirtualMachine().Equals(argument.GetVirtualMachine())));
#endif
            Contract.Ensures(Contract.Result<IStrongValueHandle<IValue>>() == null || this.GetVirtualMachine().Equals(Contract.Result<IStrongValueHandle<IValue>>().GetVirtualMachine()));

            throw new NotImplementedException();
        }

        public bool GetIsCollected()
        {
            throw new NotImplementedException();
        }

        public IThreadReference GetOwningThread()
        {
            Contract.Ensures(Contract.Result<IThreadReference>() == null || this.GetVirtualMachine().Equals(Contract.Result<IThreadReference>().GetVirtualMachine()));

            throw new NotImplementedException();
        }

        public IReferenceType GetReferenceType()
        {
            Contract.Ensures(Contract.Result<IReferenceType>() != null);
            Contract.Ensures(this.GetVirtualMachine().Equals(Contract.Result<IReferenceType>().GetVirtualMachine()));

            throw new NotImplementedException();
        }

        public ReadOnlyCollection<IObjectReference> GetReferringObjects(long maxReferrers)
        {
            Contract.Ensures(Contract.Result<ReadOnlyCollection<IObjectReference>>() != null);
#if CONTRACTS_FORALL
            Contract.Ensures(Contract.ForAll(Contract.Result<ReadOnlyCollection<IObjectReference>>(), value => value != null && this.GetVirtualMachine().Equals(value.GetVirtualMachine())));
#endif

            throw new NotImplementedException();
        }

        public void SetValue(IField field, IValue value)
        {
            ContractSlim.Requires<ArgumentNullException>(field != null, "field");
            ContractSlim.Requires<VirtualMachineMismatchException>(this.GetVirtualMachine().Equals(field.GetVirtualMachine()));
            ContractSlim.Requires<VirtualMachineMismatchException>(value == null || this.GetVirtualMachine().Equals(value.GetVirtualMachine()));

            throw new NotImplementedException();
        }

        public long GetUniqueId()
        {
            throw new NotImplementedException();
        }

        public ReadOnlyCollection<IThreadReference> GetWaitingThreads()
        {
            Contract.Ensures(Contract.Result<ReadOnlyCollection<IThreadReference>>() != null);
#if CONTRACTS_FORALL
            Contract.Ensures(Contract.ForAll(Contract.Result<ReadOnlyCollection<IThreadReference>>(), thread => thread != null && this.GetVirtualMachine().Equals(thread.GetVirtualMachine())));
#endif

            throw new NotImplementedException();
        }

        #endregion

        #region IEquatable<IObjectReference> Members

        public bool Equals(IObjectReference other)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region IValue Members

        public IType GetValueType()
        {
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
