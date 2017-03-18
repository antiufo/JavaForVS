namespace Tvl.VisualStudio.Language.Java.SourceData
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.Contracts;

    public abstract partial class NameResolutionContext
    {
        private readonly IntelliSenseCache _cache;

        private NameResolutionContext(IntelliSenseCache cache)
        {
            Contract.Requires(cache != null);

            _cache = cache;
        }

        public static NameResolutionContext Aggregate(IntelliSenseCache cache, IEnumerable<NameResolutionContext> contexts)
        {
            ContractSlim.Requires<ArgumentNullException>(cache != null, "cache");
            ContractSlim.Requires<ArgumentNullException>(contexts != null, "contexts");
            Contract.Ensures(Contract.Result<NameResolutionContext>() != null);

            return new AggregateContext(cache, contexts);
        }

        public static NameResolutionContext Global(IntelliSenseCache cache)
        {
            ContractSlim.Requires<ArgumentNullException>(cache != null, "cache");
            Contract.Ensures(Contract.Result<NameResolutionContext>() != null);

            return new GlobalContext(cache);
        }

        public static NameResolutionContext Import(IntelliSenseCache cache, CodeImportStatement importStatement)
        {
            ContractSlim.Requires<ArgumentNullException>(cache != null, "cache");
            ContractSlim.Requires<ArgumentNullException>(importStatement != null, "importStatement");
            Contract.Ensures(Contract.Result<NameResolutionContext>() != null);

            return new ImportContext(cache, importStatement);
        }

        public static NameResolutionContext Import(IntelliSenseCache cache, string path, bool importOnDemand, bool staticImport)
        {
            ContractSlim.Requires<ArgumentNullException>(path != null, "path");
            ContractSlim.Requires<ArgumentException>(!string.IsNullOrEmpty(path));
            Contract.Ensures(Contract.Result<NameResolutionContext>() != null);

            return new ImportContext(cache, path, importOnDemand, staticImport);
        }

        public static NameResolutionContext StatementBlock(IntelliSenseCache cache, CodeStatementBlock statementBlock)
        {
            ContractSlim.Requires<ArgumentNullException>(statementBlock != null, "statementBlock");
            Contract.Ensures(Contract.Result<NameResolutionContext>() != null);

            throw new NotImplementedException();
        }

        public static NameResolutionContext Package(IntelliSenseCache cache, CodePackage package)
        {
            ContractSlim.Requires<ArgumentNullException>(package != null, "package");
            Contract.Ensures(Contract.Result<NameResolutionContext>() != null);

            throw new NotImplementedException();
        }

        public static NameResolutionContext Type(IntelliSenseCache cache, CodeType type)
        {
            ContractSlim.Requires<ArgumentNullException>(type != null, "type");
            Contract.Ensures(Contract.Result<NameResolutionContext>() != null);

            return new TypeContext(cache, type);
            throw new NotImplementedException();
        }

        public static NameResolutionContext TypeStatic(IntelliSenseCache cache, CodeType type)
        {
            ContractSlim.Requires<ArgumentNullException>(type != null, "type");
            Contract.Ensures(Contract.Result<NameResolutionContext>() != null);

            throw new NotImplementedException();
        }

        public static NameResolutionContext TypeInstance(IntelliSenseCache cache, CodeType type)
        {
            ContractSlim.Requires<ArgumentNullException>(type != null, "type");
            Contract.Ensures(Contract.Result<NameResolutionContext>() != null);

            throw new NotImplementedException();
        }

        protected static NameResolutionContext Empty(NameResolutionContext parentContext, string name, string @operator, bool caseSensitive)
        {
            ContractSlim.Requires<ArgumentNullException>(parentContext != null, "parentContext");
            Contract.Ensures(Contract.Result<NameResolutionContext>() != null);

            throw new NotImplementedException();
        }

        protected static NameResolutionContext Error(NameResolutionContext parentContext, string name, string @operator, bool caseSensitive)
        {
            ContractSlim.Requires<ArgumentNullException>(parentContext != null, "parentContext");
            Contract.Ensures(Contract.Result<NameResolutionContext>() != null);

            throw new NotImplementedException();
        }

        public abstract CodeElement[] GetMatchingElements();

        public abstract NameResolutionContext Filter(string name, string @operator, bool caseSensitive);
    }
}
