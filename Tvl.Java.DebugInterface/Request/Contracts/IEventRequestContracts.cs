﻿namespace Tvl.Java.DebugInterface.Request.Contracts
{
    using System;
    using System.Diagnostics.Contracts;

    [ContractClassFor(typeof(IEventRequest))]
    internal abstract class IEventRequestContracts : IEventRequest
    {
        #region IEventRequest Members

        public bool IsEnabled
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public SuspendPolicy SuspendPolicy
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public object GetProperty(object key)
        {
            throw new NotImplementedException();
        }

        public void PutProperty(object key, object value)
        {
            throw new NotImplementedException();
        }

        public void AddCountFilter(int count)
        {
            ContractSlim.Requires<ArgumentOutOfRangeException>(count >= 0);

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
