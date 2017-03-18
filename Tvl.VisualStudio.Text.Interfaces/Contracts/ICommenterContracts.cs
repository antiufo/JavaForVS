namespace Tvl.VisualStudio.Text.Contracts
{
    using System;
    using System.Diagnostics.Contracts;
    using Microsoft.VisualStudio.Text;

    [ContractClassFor(typeof(ICommenter))]
    public abstract class ICommenterContracts : ICommenter
    {
        #region ICommenter Members

        public NormalizedSnapshotSpanCollection CommentSpans(NormalizedSnapshotSpanCollection spans)
        {
            ContractSlim.Requires<ArgumentNullException>(spans != null, "spans");
            Contract.Ensures(Contract.Result<NormalizedSnapshotSpanCollection>() != null);

            throw new NotImplementedException();
        }

        public NormalizedSnapshotSpanCollection UncommentSpans(NormalizedSnapshotSpanCollection spans)
        {
            ContractSlim.Requires<ArgumentNullException>(spans != null, "spans");
            Contract.Ensures(Contract.Result<NormalizedSnapshotSpanCollection>() != null);

            throw new NotImplementedException();
        }

        #endregion
    }
}
