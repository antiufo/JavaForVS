namespace Tvl.VisualStudio.Language.Java.Project
{
    using System;
    using System.Diagnostics.Contracts;
    using Microsoft.Build.Utilities;

    public static class CommandLineBuilderExtensions
    {
        public static void AppendSwitchIfNotNullOrEmpty(this CommandLineBuilder commandLine, string switchName, string parameter)
        {
            ContractSlim.Requires<ArgumentNullException>(commandLine != null, "commandLine");
            ContractSlim.Requires<ArgumentNullException>(switchName != null, "switchName");
            ContractSlim.Requires<ArgumentException>(!string.IsNullOrEmpty(switchName));

            if (!string.IsNullOrEmpty(parameter))
                commandLine.AppendSwitchIfNotNull(switchName, parameter);
        }
    }
}
