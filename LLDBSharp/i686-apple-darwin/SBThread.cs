//----------------------------------------------------------------------------
// This is autogenerated code by CppSharp.
// Do not edit this file or all your changes will be lost after re-generation.
//----------------------------------------------------------------------------
using System;
using System.Runtime.InteropServices;
using System.Security;

namespace LLDB
{
    public unsafe partial class Thread : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 8)]
        public partial struct Internal
        {
            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb8SBThreadC2Ev")]
            internal static extern void ctor_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb8SBThreadC2ERKS0_")]
            internal static extern void cctor_1(global::System.IntPtr instance, global::System.IntPtr thread);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb8SBThreadD2Ev")]
            internal static extern void dtor_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZNK4lldb8SBThread8GetQueueEv")]
            internal static extern void GetQueue_0(global::System.IntPtr @return, global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZNK4lldb8SBThread7IsValidEv")]
            [return: MarshalAsAttribute(UnmanagedType.I1)]
            internal static extern bool IsValid_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb8SBThread5ClearEv")]
            internal static extern void Clear_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb8SBThread24GetStopReasonDataAtIndexEj")]
            internal static extern ulong GetStopReasonDataAtIndex_0(global::System.IntPtr instance, uint idx);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb8SBThread31GetStopReasonExtendedInfoAsJSONERNS_8SBStreamE")]
            [return: MarshalAsAttribute(UnmanagedType.I1)]
            internal static extern bool GetStopReasonExtendedInfoAsJSON_0(global::System.IntPtr instance, global::System.IntPtr stream);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb8SBThread31GetStopReasonExtendedBacktracesENS_26InstrumentationRuntimeTypeE")]
            internal static extern void GetStopReasonExtendedBacktraces_0(global::System.IntPtr @return, global::System.IntPtr instance, LLDB.InstrumentationRuntimeType type);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb8SBThread18GetStopDescriptionEPcm")]
            internal static extern uint GetStopDescription_0(global::System.IntPtr instance, sbyte* dst, uint dst_len);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb8SBThread18GetStopReturnValueEv")]
            internal static extern void GetStopReturnValue_0(global::System.IntPtr @return, global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb8SBThread25GetInfoItemByPathAsStringEPKcRNS_8SBStreamE")]
            [return: MarshalAsAttribute(UnmanagedType.I1)]
            internal static extern bool GetInfoItemByPathAsString_0(global::System.IntPtr instance, global::System.IntPtr path, global::System.IntPtr strm);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb8SBThread8StepOverENS_7RunModeE")]
            internal static extern void StepOver_0(global::System.IntPtr instance, LLDB.RunMode stop_other_threads);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb8SBThread8StepIntoENS_7RunModeE")]
            internal static extern void StepInto_0(global::System.IntPtr instance, LLDB.RunMode stop_other_threads);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb8SBThread8StepIntoEPKcNS_7RunModeE")]
            internal static extern void StepInto_1(global::System.IntPtr instance, global::System.IntPtr target_name, LLDB.RunMode stop_other_threads);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb8SBThread8StepIntoEPKcjRNS_7SBErrorENS_7RunModeE")]
            internal static extern void StepInto_2(global::System.IntPtr instance, global::System.IntPtr target_name, uint end_line, global::System.IntPtr error, LLDB.RunMode stop_other_threads);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb8SBThread7StepOutEv")]
            internal static extern void StepOut_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb8SBThread14StepOutOfFrameERNS_7SBFrameE")]
            internal static extern void StepOutOfFrame_0(global::System.IntPtr instance, global::System.IntPtr frame);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb8SBThread15StepInstructionEb")]
            internal static extern void StepInstruction_0(global::System.IntPtr instance, bool step_over);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb8SBThread13StepOverUntilERNS_7SBFrameERNS_10SBFileSpecEj")]
            internal static extern void StepOverUntil_0(global::System.IntPtr @return, global::System.IntPtr instance, global::System.IntPtr frame, global::System.IntPtr file_spec, uint line);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb8SBThread27StepUsingScriptedThreadPlanEPKc")]
            internal static extern void StepUsingScriptedThreadPlan_0(global::System.IntPtr @return, global::System.IntPtr instance, global::System.IntPtr script_class_name);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb8SBThread10JumpToLineERNS_10SBFileSpecEj")]
            internal static extern void JumpToLine_0(global::System.IntPtr @return, global::System.IntPtr instance, global::System.IntPtr file_spec, uint line);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb8SBThread12RunToAddressEy")]
            internal static extern void RunToAddress_0(global::System.IntPtr instance, ulong addr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb8SBThread15ReturnFromFrameERNS_7SBFrameERNS_7SBValueE")]
            internal static extern void ReturnFromFrame_0(global::System.IntPtr @return, global::System.IntPtr instance, global::System.IntPtr frame, global::System.IntPtr return_value);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb8SBThread7SuspendEv")]
            [return: MarshalAsAttribute(UnmanagedType.I1)]
            internal static extern bool Suspend_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb8SBThread6ResumeEv")]
            [return: MarshalAsAttribute(UnmanagedType.I1)]
            internal static extern bool Resume_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb8SBThread11IsSuspendedEv")]
            [return: MarshalAsAttribute(UnmanagedType.I1)]
            internal static extern bool IsSuspended_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb8SBThread9IsStoppedEv")]
            [return: MarshalAsAttribute(UnmanagedType.I1)]
            internal static extern bool IsStopped_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb8SBThread15GetFrameAtIndexEj")]
            internal static extern void GetFrameAtIndex_0(global::System.IntPtr @return, global::System.IntPtr instance, uint idx);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb8SBThread16GetSelectedFrameEv")]
            internal static extern void GetSelectedFrame_0(global::System.IntPtr @return, global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb8SBThread16SetSelectedFrameEj")]
            internal static extern void SetSelectedFrame_0(global::System.IntPtr @return, global::System.IntPtr instance, uint frame_idx);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb8SBThread18EventIsThreadEventERKNS_7SBEventE")]
            [return: MarshalAsAttribute(UnmanagedType.I1)]
            internal static extern bool EventIsThreadEvent_0(global::System.IntPtr @event);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb8SBThread22GetStackFrameFromEventERKNS_7SBEventE")]
            internal static extern void GetStackFrameFromEvent_0(global::System.IntPtr @return, global::System.IntPtr @event);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb8SBThread18GetThreadFromEventERKNS_7SBEventE")]
            internal static extern void GetThreadFromEvent_0(global::System.IntPtr @return, global::System.IntPtr @event);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb8SBThread10GetProcessEv")]
            internal static extern void GetProcess_0(global::System.IntPtr @return, global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZNK4lldb8SBThreadeqERKS0_")]
            [return: MarshalAsAttribute(UnmanagedType.I1)]
            internal static extern bool OperatorEqualEqual_0(global::System.IntPtr instance, global::System.IntPtr rhs);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZNK4lldb8SBThreadneERKS0_")]
            [return: MarshalAsAttribute(UnmanagedType.I1)]
            internal static extern bool OperatorExclaimEqual_0(global::System.IntPtr instance, global::System.IntPtr rhs);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZNK4lldb8SBThread14GetDescriptionERNS_8SBStreamE")]
            [return: MarshalAsAttribute(UnmanagedType.I1)]
            internal static extern bool GetDescription_0(global::System.IntPtr instance, global::System.IntPtr description);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZNK4lldb8SBThread9GetStatusERNS_8SBStreamE")]
            [return: MarshalAsAttribute(UnmanagedType.I1)]
            internal static extern bool GetStatus_0(global::System.IntPtr instance, global::System.IntPtr status);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb8SBThread26GetExtendedBacktraceThreadEPKc")]
            internal static extern void GetExtendedBacktraceThread_0(global::System.IntPtr @return, global::System.IntPtr instance, global::System.IntPtr type);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb8SBThread19SafeToCallFunctionsEv")]
            [return: MarshalAsAttribute(UnmanagedType.I1)]
            internal static extern bool SafeToCallFunctions_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb8SBThread23GetBroadcasterClassNameEv")]
            internal static extern global::System.IntPtr GetBroadcasterClassName_0();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb8SBThread13GetStopReasonEv")]
            internal static extern LLDB.StopReason GetStopReason_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb8SBThread22GetStopReasonDataCountEv")]
            internal static extern uint GetStopReasonDataCount_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZNK4lldb8SBThread11GetThreadIDEv")]
            internal static extern ulong GetThreadID_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZNK4lldb8SBThread10GetIndexIDEv")]
            internal static extern uint GetIndexID_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZNK4lldb8SBThread7GetNameEv")]
            internal static extern global::System.IntPtr GetName_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZNK4lldb8SBThread12GetQueueNameEv")]
            internal static extern global::System.IntPtr GetQueueName_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZNK4lldb8SBThread10GetQueueIDEv")]
            internal static extern ulong GetQueueID_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb8SBThread12GetNumFramesEv")]
            internal static extern uint GetNumFrames_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb8SBThread38GetExtendedBacktraceOriginatingIndexIDEv")]
            internal static extern uint GetExtendedBacktraceOriginatingIndexID_0(global::System.IntPtr instance);
        }

        [Flags]
        public enum BroadcastBit : uint
        {
            BroadcastBitStackChanged = 1,
            BroadcastBitThreadSuspended = 2,
            BroadcastBitThreadResumed = 4,
            BroadcastBitSelectedFrameChanged = 8,
            BroadcastBitThreadSelected = 16
        }

        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        public static readonly System.Collections.Concurrent.ConcurrentDictionary<IntPtr, Thread> NativeToManagedMap = new System.Collections.Concurrent.ConcurrentDictionary<IntPtr, Thread>();
        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        public static Thread __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new Thread(native.ToPointer(), skipVTables);
        }

        public static Thread __CreateInstance(Thread.Internal native, bool skipVTables = false)
        {
            return new Thread(native, skipVTables);
        }

        private static void* __CopyValue(Thread.Internal native)
        {
            var ret = Marshal.AllocHGlobal(8);
            LLDB.Thread.Internal.cctor_1(ret, new global::System.IntPtr(&native));
            return ret.ToPointer();
        }

        private Thread(Thread.Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected Thread(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public Thread()
        {
            __Instance = Marshal.AllocHGlobal(8);
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            Internal.ctor_0((__Instance + __PointerAdjustment));
        }

        public Thread(LLDB.Thread thread)
        {
            __Instance = Marshal.AllocHGlobal(8);
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            if (ReferenceEquals(thread, null))
                throw new global::System.ArgumentNullException("thread", "Cannot be null because it is a C++ reference (&).");
            var arg0 = thread.__Instance;
            Internal.cctor_1((__Instance + __PointerAdjustment), arg0);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        protected virtual void Dispose(bool disposing)
        {
            LLDB.Thread __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            Internal.dtor_0((__Instance + __PointerAdjustment));
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
        }

        public LLDB.Queue GetQueue()
        {
            var __ret = new LLDB.Queue.Internal();
            Internal.GetQueue_0(new IntPtr(&__ret), (__Instance + __PointerAdjustment));
            return LLDB.Queue.__CreateInstance(__ret);
        }

        public bool IsValid()
        {
            var __ret = Internal.IsValid_0((__Instance + __PointerAdjustment));
            return __ret;
        }

        public void Clear()
        {
            Internal.Clear_0((__Instance + __PointerAdjustment));
        }

        /// <summary>
        /// <para>Get information associated with a stop reason.</para>
        /// </summary>
        /// <remarks>
        /// <para>Breakpoint stop reasons will have data that consists of pairs of </para>
        /// <para>breakpoint IDs followed by the breakpoint location IDs (they always come</para>
        /// <para>in pairs).</para>
        /// <para>Stop Reason              Count Data Type</para>
        /// <para>======================== ===== =========================================</para>
        /// <para>eStopReasonNone          0</para>
        /// <para>eStopReasonTrace         0</para>
        /// <para>eStopReasonBreakpoint    N     duple: {breakpoint id, location id}</para>
        /// <para>eStopReasonWatchpoint    1     watchpoint id</para>
        /// <para>eStopReasonSignal        1     unix signal number</para>
        /// <para>eStopReasonException     N     exception data</para>
        /// <para>eStopReasonExec          0</para>
        /// <para>eStopReasonPlanComplete  0</para>
        /// </remarks>
        public ulong GetStopReasonDataAtIndex(uint idx)
        {
            var __ret = Internal.GetStopReasonDataAtIndex_0((__Instance + __PointerAdjustment), idx);
            return __ret;
        }

        public bool GetStopReasonExtendedInfoAsJSON(LLDB.Stream stream)
        {
            if (ReferenceEquals(stream, null))
                throw new global::System.ArgumentNullException("stream", "Cannot be null because it is a C++ reference (&).");
            var arg0 = stream.__Instance;
            var __ret = Internal.GetStopReasonExtendedInfoAsJSON_0((__Instance + __PointerAdjustment), arg0);
            return __ret;
        }

        public LLDB.ThreadCollection GetStopReasonExtendedBacktraces(LLDB.InstrumentationRuntimeType type)
        {
            var arg0 = type;
            var __ret = new LLDB.ThreadCollection.Internal();
            Internal.GetStopReasonExtendedBacktraces_0(new IntPtr(&__ret), (__Instance + __PointerAdjustment), arg0);
            return LLDB.ThreadCollection.__CreateInstance(__ret);
        }

        public uint GetStopDescription(sbyte* dst, uint dst_len)
        {
            var arg0 = dst;
            var __ret = Internal.GetStopDescription_0((__Instance + __PointerAdjustment), arg0, dst_len);
            return __ret;
        }

        public LLDB.Value GetStopReturnValue()
        {
            var __ret = new LLDB.Value.Internal();
            Internal.GetStopReturnValue_0(new IntPtr(&__ret), (__Instance + __PointerAdjustment));
            return LLDB.Value.__CreateInstance(__ret);
        }

        public bool GetInfoItemByPathAsString(string path, LLDB.Stream strm)
        {
            var arg0 = Marshal.StringToHGlobalAnsi(path);
            if (ReferenceEquals(strm, null))
                throw new global::System.ArgumentNullException("strm", "Cannot be null because it is a C++ reference (&).");
            var arg1 = strm.__Instance;
            var __ret = Internal.GetInfoItemByPathAsString_0((__Instance + __PointerAdjustment), arg0, arg1);
            Marshal.FreeHGlobal(arg0);
            return __ret;
        }

        public void StepOver(LLDB.RunMode stop_other_threads)
        {
            var arg0 = stop_other_threads;
            Internal.StepOver_0((__Instance + __PointerAdjustment), arg0);
        }

        public void StepInto(LLDB.RunMode stop_other_threads)
        {
            var arg0 = stop_other_threads;
            Internal.StepInto_0((__Instance + __PointerAdjustment), arg0);
        }

        public void StepInto(string target_name, LLDB.RunMode stop_other_threads)
        {
            var arg0 = Marshal.StringToHGlobalAnsi(target_name);
            var arg1 = stop_other_threads;
            Internal.StepInto_1((__Instance + __PointerAdjustment), arg0, arg1);
            Marshal.FreeHGlobal(arg0);
        }

        public void StepInto(string target_name, uint end_line, LLDB.Error error, LLDB.RunMode stop_other_threads)
        {
            var arg0 = Marshal.StringToHGlobalAnsi(target_name);
            if (ReferenceEquals(error, null))
                throw new global::System.ArgumentNullException("error", "Cannot be null because it is a C++ reference (&).");
            var arg2 = error.__Instance;
            var arg3 = stop_other_threads;
            Internal.StepInto_2((__Instance + __PointerAdjustment), arg0, end_line, arg2, arg3);
            Marshal.FreeHGlobal(arg0);
        }

        public void StepOut()
        {
            Internal.StepOut_0((__Instance + __PointerAdjustment));
        }

        public void StepOutOfFrame(LLDB.Frame frame)
        {
            if (ReferenceEquals(frame, null))
                throw new global::System.ArgumentNullException("frame", "Cannot be null because it is a C++ reference (&).");
            var arg0 = frame.__Instance;
            Internal.StepOutOfFrame_0((__Instance + __PointerAdjustment), arg0);
        }

        public void StepInstruction(bool step_over)
        {
            Internal.StepInstruction_0((__Instance + __PointerAdjustment), step_over);
        }

        public LLDB.Error StepOverUntil(LLDB.Frame frame, LLDB.FileSpec file_spec, uint line)
        {
            if (ReferenceEquals(frame, null))
                throw new global::System.ArgumentNullException("frame", "Cannot be null because it is a C++ reference (&).");
            var arg0 = frame.__Instance;
            if (ReferenceEquals(file_spec, null))
                throw new global::System.ArgumentNullException("file_spec", "Cannot be null because it is a C++ reference (&).");
            var arg1 = file_spec.__Instance;
            var __ret = new LLDB.Error.Internal();
            Internal.StepOverUntil_0(new IntPtr(&__ret), (__Instance + __PointerAdjustment), arg0, arg1, line);
            return LLDB.Error.__CreateInstance(__ret);
        }

        public LLDB.Error StepUsingScriptedThreadPlan(string script_class_name)
        {
            var arg0 = Marshal.StringToHGlobalAnsi(script_class_name);
            var __ret = new LLDB.Error.Internal();
            Internal.StepUsingScriptedThreadPlan_0(new IntPtr(&__ret), (__Instance + __PointerAdjustment), arg0);
            Marshal.FreeHGlobal(arg0);
            return LLDB.Error.__CreateInstance(__ret);
        }

        public LLDB.Error JumpToLine(LLDB.FileSpec file_spec, uint line)
        {
            if (ReferenceEquals(file_spec, null))
                throw new global::System.ArgumentNullException("file_spec", "Cannot be null because it is a C++ reference (&).");
            var arg0 = file_spec.__Instance;
            var __ret = new LLDB.Error.Internal();
            Internal.JumpToLine_0(new IntPtr(&__ret), (__Instance + __PointerAdjustment), arg0, line);
            return LLDB.Error.__CreateInstance(__ret);
        }

        public void RunToAddress(ulong addr)
        {
            Internal.RunToAddress_0((__Instance + __PointerAdjustment), addr);
        }

        public LLDB.Error ReturnFromFrame(LLDB.Frame frame, LLDB.Value return_value)
        {
            if (ReferenceEquals(frame, null))
                throw new global::System.ArgumentNullException("frame", "Cannot be null because it is a C++ reference (&).");
            var arg0 = frame.__Instance;
            if (ReferenceEquals(return_value, null))
                throw new global::System.ArgumentNullException("return_value", "Cannot be null because it is a C++ reference (&).");
            var arg1 = return_value.__Instance;
            var __ret = new LLDB.Error.Internal();
            Internal.ReturnFromFrame_0(new IntPtr(&__ret), (__Instance + __PointerAdjustment), arg0, arg1);
            return LLDB.Error.__CreateInstance(__ret);
        }

        /// <summary>
        /// <para>LLDB currently supports process centric debugging which means when any</para>
        /// <para>thread in a process stops, all other threads are stopped. The Suspend()</para>
        /// <para>call here tells our process to suspend a thread and not let it run when</para>
        /// <para>the other threads in a process are allowed to run. So when </para>
        /// <para>SBProcess::Continue() is called, any threads that aren't suspended will</para>
        /// <para>be allowed to run. If any of the SBThread functions for stepping are </para>
        /// <para>called (StepOver, StepInto, StepOut, StepInstruction, RunToAddress), the</para>
        /// <para>thread will not be allowed to run and these functions will simply return.</para>
        /// </summary>
        /// <remarks>
        /// <para>Eventually we plan to add support for thread centric debugging where</para>
        /// <para>each thread is controlled individually and each thread would broadcast</para>
        /// <para>its state, but we haven't implemented this yet.</para>
        /// <para>Likewise the SBThread::Resume() call will again allow the thread to run</para>
        /// <para>when the process is continued.</para>
        /// <para>Suspend() and Resume() functions are not currently reference counted, if</para>
        /// <para>anyone has the need for them to be reference counted, please let us</para>
        /// <para>know.</para>
        /// </remarks>
        public bool Suspend()
        {
            var __ret = Internal.Suspend_0((__Instance + __PointerAdjustment));
            return __ret;
        }

        public bool Resume()
        {
            var __ret = Internal.Resume_0((__Instance + __PointerAdjustment));
            return __ret;
        }

        public bool IsSuspended()
        {
            var __ret = Internal.IsSuspended_0((__Instance + __PointerAdjustment));
            return __ret;
        }

        public bool IsStopped()
        {
            var __ret = Internal.IsStopped_0((__Instance + __PointerAdjustment));
            return __ret;
        }

        public LLDB.Frame GetFrameAtIndex(uint idx)
        {
            var __ret = new LLDB.Frame.Internal();
            Internal.GetFrameAtIndex_0(new IntPtr(&__ret), (__Instance + __PointerAdjustment), idx);
            return LLDB.Frame.__CreateInstance(__ret);
        }

        public LLDB.Frame GetSelectedFrame()
        {
            var __ret = new LLDB.Frame.Internal();
            Internal.GetSelectedFrame_0(new IntPtr(&__ret), (__Instance + __PointerAdjustment));
            return LLDB.Frame.__CreateInstance(__ret);
        }

        public LLDB.Frame SetSelectedFrame(uint frame_idx)
        {
            var __ret = new LLDB.Frame.Internal();
            Internal.SetSelectedFrame_0(new IntPtr(&__ret), (__Instance + __PointerAdjustment), frame_idx);
            return LLDB.Frame.__CreateInstance(__ret);
        }

        public LLDB.Process GetProcess()
        {
            var __ret = new LLDB.Process.Internal();
            Internal.GetProcess_0(new IntPtr(&__ret), (__Instance + __PointerAdjustment));
            return LLDB.Process.__CreateInstance(__ret);
        }

        public static bool operator ==(LLDB.Thread __op, LLDB.Thread rhs)
        {
            bool __opNull = ReferenceEquals(__op, null);
            bool rhsNull = ReferenceEquals(rhs, null);
            if (__opNull || rhsNull)
                return __opNull && rhsNull;
            var arg0 = __op.__Instance;
            var arg1 = rhs.__Instance;
            var __ret = Internal.OperatorEqualEqual_0(arg0, arg1);
            return __ret;
        }

        public override bool Equals(object obj)
        {
            return this == obj as Thread;
        }

        public override int GetHashCode()
        {
            if (__Instance == global::System.IntPtr.Zero)
                return global::System.IntPtr.Zero.GetHashCode();
            return (*(Internal*) __Instance).GetHashCode();
        }

        public static bool operator !=(LLDB.Thread __op, LLDB.Thread rhs)
        {
            bool __opNull = ReferenceEquals(__op, null);
            bool rhsNull = ReferenceEquals(rhs, null);
            if (__opNull || rhsNull)
                return !(__opNull && rhsNull);
            var arg0 = __op.__Instance;
            var arg1 = rhs.__Instance;
            var __ret = Internal.OperatorExclaimEqual_0(arg0, arg1);
            return __ret;
        }

        public bool GetDescription(LLDB.Stream description)
        {
            if (ReferenceEquals(description, null))
                throw new global::System.ArgumentNullException("description", "Cannot be null because it is a C++ reference (&).");
            var arg0 = description.__Instance;
            var __ret = Internal.GetDescription_0((__Instance + __PointerAdjustment), arg0);
            return __ret;
        }

        public bool GetStatus(LLDB.Stream status)
        {
            if (ReferenceEquals(status, null))
                throw new global::System.ArgumentNullException("status", "Cannot be null because it is a C++ reference (&).");
            var arg0 = status.__Instance;
            var __ret = Internal.GetStatus_0((__Instance + __PointerAdjustment), arg0);
            return __ret;
        }

        public LLDB.Thread GetExtendedBacktraceThread(string type)
        {
            var arg0 = Marshal.StringToHGlobalAnsi(type);
            var __ret = new LLDB.Thread.Internal();
            Internal.GetExtendedBacktraceThread_0(new IntPtr(&__ret), (__Instance + __PointerAdjustment), arg0);
            Marshal.FreeHGlobal(arg0);
            return LLDB.Thread.__CreateInstance(__ret);
        }

        public bool SafeToCallFunctions()
        {
            var __ret = Internal.SafeToCallFunctions_0((__Instance + __PointerAdjustment));
            return __ret;
        }

        public static bool EventIsThreadEvent(LLDB.Event @event)
        {
            if (ReferenceEquals(@event, null))
                throw new global::System.ArgumentNullException("@event", "Cannot be null because it is a C++ reference (&).");
            var arg0 = @event.__Instance;
            var __ret = Internal.EventIsThreadEvent_0(arg0);
            return __ret;
        }

        public static LLDB.Frame GetStackFrameFromEvent(LLDB.Event @event)
        {
            if (ReferenceEquals(@event, null))
                throw new global::System.ArgumentNullException("@event", "Cannot be null because it is a C++ reference (&).");
            var arg0 = @event.__Instance;
            var __ret = new LLDB.Frame.Internal();
            Internal.GetStackFrameFromEvent_0(new IntPtr(&__ret), arg0);
            return LLDB.Frame.__CreateInstance(__ret);
        }

        public static LLDB.Thread GetThreadFromEvent(LLDB.Event @event)
        {
            if (ReferenceEquals(@event, null))
                throw new global::System.ArgumentNullException("@event", "Cannot be null because it is a C++ reference (&).");
            var arg0 = @event.__Instance;
            var __ret = new LLDB.Thread.Internal();
            Internal.GetThreadFromEvent_0(new IntPtr(&__ret), arg0);
            return LLDB.Thread.__CreateInstance(__ret);
        }

        public static string BroadcasterClassName
        {
            get
            {
                var __ret = Internal.GetBroadcasterClassName_0();
                return Marshal.PtrToStringAnsi(__ret);
            }
        }

        public LLDB.StopReason StopReason
        {
            get
            {
                var __ret = Internal.GetStopReason_0((__Instance + __PointerAdjustment));
                return __ret;
            }
        }

        public uint StopReasonDataCount
        {
            get
            {
                var __ret = Internal.GetStopReasonDataCount_0((__Instance + __PointerAdjustment));
                return __ret;
            }
        }

        public ulong ThreadID
        {
            get
            {
                var __ret = Internal.GetThreadID_0((__Instance + __PointerAdjustment));
                return __ret;
            }
        }

        public uint IndexID
        {
            get
            {
                var __ret = Internal.GetIndexID_0((__Instance + __PointerAdjustment));
                return __ret;
            }
        }

        public string Name
        {
            get
            {
                var __ret = Internal.GetName_0((__Instance + __PointerAdjustment));
                return Marshal.PtrToStringAnsi(__ret);
            }
        }

        public string QueueName
        {
            get
            {
                var __ret = Internal.GetQueueName_0((__Instance + __PointerAdjustment));
                return Marshal.PtrToStringAnsi(__ret);
            }
        }

        public ulong QueueID
        {
            get
            {
                var __ret = Internal.GetQueueID_0((__Instance + __PointerAdjustment));
                return __ret;
            }
        }

        public uint NumFrames
        {
            get
            {
                var __ret = Internal.GetNumFrames_0((__Instance + __PointerAdjustment));
                return __ret;
            }
        }

        public uint ExtendedBacktraceOriginatingIndexID
        {
            get
            {
                var __ret = Internal.GetExtendedBacktraceOriginatingIndexID_0((__Instance + __PointerAdjustment));
                return __ret;
            }
        }
    }
}
