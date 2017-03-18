namespace Tvl.Java.DebugInterface.Client.Events
{
    using System;
    using System.Diagnostics.Contracts;
    using Tvl.Java.DebugInterface.Client.Request;
    using Tvl.Java.DebugInterface.Request;

    public class ClassUnloadEventArgs : VirtualMachineEventArgs
    {
        private readonly string _signature;

        internal ClassUnloadEventArgs(VirtualMachine virtualMachine, SuspendPolicy suspendPolicy, EventRequest request, string signature)
            : base(virtualMachine, suspendPolicy, request)
        {
            ContractSlim.Requires<ArgumentNullException>(signature != null, "signature");
            ContractSlim.Requires<ArgumentException>(!string.IsNullOrEmpty(signature));

            _signature = signature;
        }

        public string Signature
        {
            get
            {
                return _signature;
            }
        }
    }
}
