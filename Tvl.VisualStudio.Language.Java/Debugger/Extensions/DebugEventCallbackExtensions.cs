namespace Tvl.VisualStudio.Language.Java.Debugger
{
    using System;
    using System.Diagnostics.Contracts;
    using Microsoft.VisualStudio.Debugger.Interop;
    using Tvl.VisualStudio.Language.Java.Debugger.Events;

    public static class DebugEventCallbackExtensions
    {
        public static int Event(this IDebugEventCallback2 callback, IDebugEngine2 engine, IDebugProcess2 process, IDebugProgram2 program, IDebugThread2 thread, DebugEvent debugEvent)
        {
            ContractSlim.Requires<ArgumentNullException>(callback != null, "callback");
            ContractSlim.Requires<ArgumentNullException>(debugEvent != null, "debugEvent");
            ContractSlim.Requires<ArgumentNullException>(engine != null, "engine");

            return callback.Event(engine, process, program, thread, debugEvent, debugEvent.EventGuid, (uint)debugEvent.Attributes);
        }
    }
}
