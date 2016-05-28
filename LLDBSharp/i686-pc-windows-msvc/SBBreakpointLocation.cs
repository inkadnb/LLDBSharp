//----------------------------------------------------------------------------
// <auto-generated>
// This is autogenerated code by CppSharp.
// Do not edit this file or all your changes will be lost after re-generation.
// </auto-generated>
//----------------------------------------------------------------------------
using System;
using System.Runtime.InteropServices;
using System.Security;

namespace LLDB
{
    public unsafe partial class BreakpointLocation : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 8)]
        public partial struct Internal
        {
            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="??0SBBreakpointLocation@lldb@@QAE@XZ")]
            internal static extern global::System.IntPtr ctor_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="??0SBBreakpointLocation@lldb@@QAE@ABV01@@Z")]
            internal static extern global::System.IntPtr cctor_1(global::System.IntPtr instance, global::System.IntPtr rhs);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="??1SBBreakpointLocation@lldb@@QAE@XZ")]
            internal static extern void dtor_0(global::System.IntPtr instance, int delete);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?IsValid@SBBreakpointLocation@lldb@@QBE_NXZ")]
            [return: MarshalAsAttribute(UnmanagedType.I1)]
            internal static extern bool IsValid_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?GetAddress@SBBreakpointLocation@lldb@@QAE?AVSBAddress@2@XZ")]
            internal static extern void GetAddress_0(global::System.IntPtr instance, global::System.IntPtr @return);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?IsEnabled@SBBreakpointLocation@lldb@@QAE_NXZ")]
            [return: MarshalAsAttribute(UnmanagedType.I1)]
            internal static extern bool IsEnabled_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?SetScriptCallbackBody@SBBreakpointLocation@lldb@@QAE?AVSBError@2@PBD@Z")]
            internal static extern void SetScriptCallbackBody_0(global::System.IntPtr instance, global::System.IntPtr @return, global::System.IntPtr script_body_text);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?IsResolved@SBBreakpointLocation@lldb@@QAE_NXZ")]
            [return: MarshalAsAttribute(UnmanagedType.I1)]
            internal static extern bool IsResolved_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?GetDescription@SBBreakpointLocation@lldb@@QAE_NAAVSBStream@2@W4DescriptionLevel@2@@Z")]
            [return: MarshalAsAttribute(UnmanagedType.I1)]
            internal static extern bool GetDescription_0(global::System.IntPtr instance, global::System.IntPtr description, LLDB.DescriptionLevel level);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?GetBreakpoint@SBBreakpointLocation@lldb@@QAE?AVSBBreakpoint@2@XZ")]
            internal static extern void GetBreakpoint_0(global::System.IntPtr instance, global::System.IntPtr @return);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?GetID@SBBreakpointLocation@lldb@@QAEHXZ")]
            internal static extern int GetID_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?GetLoadAddress@SBBreakpointLocation@lldb@@QAE_KXZ")]
            internal static extern ulong GetLoadAddress_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?SetEnabled@SBBreakpointLocation@lldb@@QAEX_N@Z")]
            internal static extern void SetEnabled_0(global::System.IntPtr instance, bool enabled);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?GetIgnoreCount@SBBreakpointLocation@lldb@@QAEIXZ")]
            internal static extern uint GetIgnoreCount_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?SetIgnoreCount@SBBreakpointLocation@lldb@@QAEXI@Z")]
            internal static extern void SetIgnoreCount_0(global::System.IntPtr instance, uint n);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?GetCondition@SBBreakpointLocation@lldb@@QAEPBDXZ")]
            internal static extern global::System.IntPtr GetCondition_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?SetCondition@SBBreakpointLocation@lldb@@QAEXPBD@Z")]
            internal static extern void SetCondition_0(global::System.IntPtr instance, global::System.IntPtr condition);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?SetScriptCallbackFunction@SBBreakpointLocation@lldb@@QAEXPBD@Z")]
            internal static extern void SetScriptCallbackFunction_0(global::System.IntPtr instance, global::System.IntPtr callback_function_name);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?GetThreadID@SBBreakpointLocation@lldb@@QAE_KXZ")]
            internal static extern ulong GetThreadID_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?SetThreadID@SBBreakpointLocation@lldb@@QAEX_K@Z")]
            internal static extern void SetThreadID_0(global::System.IntPtr instance, ulong sb_thread_id);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?GetThreadIndex@SBBreakpointLocation@lldb@@QBEIXZ")]
            internal static extern uint GetThreadIndex_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?SetThreadIndex@SBBreakpointLocation@lldb@@QAEXI@Z")]
            internal static extern void SetThreadIndex_0(global::System.IntPtr instance, uint index);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?GetThreadName@SBBreakpointLocation@lldb@@QBEPBDXZ")]
            internal static extern global::System.IntPtr GetThreadName_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?SetThreadName@SBBreakpointLocation@lldb@@QAEXPBD@Z")]
            internal static extern void SetThreadName_0(global::System.IntPtr instance, global::System.IntPtr thread_name);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?GetQueueName@SBBreakpointLocation@lldb@@QBEPBDXZ")]
            internal static extern global::System.IntPtr GetQueueName_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?SetQueueName@SBBreakpointLocation@lldb@@QAEXPBD@Z")]
            internal static extern void SetQueueName_0(global::System.IntPtr instance, global::System.IntPtr queue_name);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        public static readonly System.Collections.Concurrent.ConcurrentDictionary<IntPtr, BreakpointLocation> NativeToManagedMap = new System.Collections.Concurrent.ConcurrentDictionary<IntPtr, BreakpointLocation>();
        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        public static BreakpointLocation __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new BreakpointLocation(native.ToPointer(), skipVTables);
        }

        public static BreakpointLocation __CreateInstance(BreakpointLocation.Internal native, bool skipVTables = false)
        {
            return new BreakpointLocation(native, skipVTables);
        }

        private static void* __CopyValue(BreakpointLocation.Internal native)
        {
            var ret = Marshal.AllocHGlobal(8);
            LLDB.BreakpointLocation.Internal.cctor_1(ret, new global::System.IntPtr(&native));
            return ret.ToPointer();
        }

        private BreakpointLocation(BreakpointLocation.Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected BreakpointLocation(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public BreakpointLocation()
        {
            __Instance = Marshal.AllocHGlobal(8);
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            Internal.ctor_0((__Instance + __PointerAdjustment));
        }

        public BreakpointLocation(LLDB.BreakpointLocation rhs)
        {
            __Instance = Marshal.AllocHGlobal(8);
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            if (ReferenceEquals(rhs, null))
                throw new global::System.ArgumentNullException("rhs", "Cannot be null because it is a C++ reference (&).");
            var arg0 = rhs.__Instance;
            Internal.cctor_1((__Instance + __PointerAdjustment), arg0);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        protected virtual void Dispose(bool disposing)
        {
            LLDB.BreakpointLocation __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            Internal.dtor_0((__Instance + __PointerAdjustment), 0);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
        }

        public bool IsValid()
        {
            var __ret = Internal.IsValid_0((__Instance + __PointerAdjustment));
            return __ret;
        }

        public LLDB.Address GetAddress()
        {
            var __ret = new LLDB.Address.Internal();
            Internal.GetAddress_0((__Instance + __PointerAdjustment), new IntPtr(&__ret));
            return LLDB.Address.__CreateInstance(__ret);
        }

        public bool IsEnabled()
        {
            var __ret = Internal.IsEnabled_0((__Instance + __PointerAdjustment));
            return __ret;
        }

        public LLDB.Error SetScriptCallbackBody(string script_body_text)
        {
            var arg0 = Marshal.StringToHGlobalAnsi(script_body_text);
            var __ret = new LLDB.Error.Internal();
            Internal.SetScriptCallbackBody_0((__Instance + __PointerAdjustment), new IntPtr(&__ret), arg0);
            Marshal.FreeHGlobal(arg0);
            return LLDB.Error.__CreateInstance(__ret);
        }

        public bool IsResolved()
        {
            var __ret = Internal.IsResolved_0((__Instance + __PointerAdjustment));
            return __ret;
        }

        public bool GetDescription(LLDB.Stream description, LLDB.DescriptionLevel level)
        {
            if (ReferenceEquals(description, null))
                throw new global::System.ArgumentNullException("description", "Cannot be null because it is a C++ reference (&).");
            var arg0 = description.__Instance;
            var arg1 = level;
            var __ret = Internal.GetDescription_0((__Instance + __PointerAdjustment), arg0, arg1);
            return __ret;
        }

        public LLDB.Breakpoint GetBreakpoint()
        {
            var __ret = new LLDB.Breakpoint.Internal();
            Internal.GetBreakpoint_0((__Instance + __PointerAdjustment), new IntPtr(&__ret));
            return LLDB.Breakpoint.__CreateInstance(__ret);
        }

        public int ID
        {
            get
            {
                var __ret = Internal.GetID_0((__Instance + __PointerAdjustment));
                return __ret;
            }
        }

        public ulong LoadAddress
        {
            get
            {
                var __ret = Internal.GetLoadAddress_0((__Instance + __PointerAdjustment));
                return __ret;
            }
        }

        public bool Enabled
        {
            set
            {
                Internal.SetEnabled_0((__Instance + __PointerAdjustment), value);
            }
        }

        public uint IgnoreCount
        {
            get
            {
                var __ret = Internal.GetIgnoreCount_0((__Instance + __PointerAdjustment));
                return __ret;
            }

            set
            {
                Internal.SetIgnoreCount_0((__Instance + __PointerAdjustment), value);
            }
        }

        public string Condition
        {
            get
            {
                var __ret = Internal.GetCondition_0((__Instance + __PointerAdjustment));
                return Marshal.PtrToStringAnsi(__ret);
            }

            set
            {
                var arg0 = Marshal.StringToHGlobalAnsi(value);
                Internal.SetCondition_0((__Instance + __PointerAdjustment), arg0);
                Marshal.FreeHGlobal(arg0);
            }
        }

        public string ScriptCallbackFunction
        {
            set
            {
                var arg0 = Marshal.StringToHGlobalAnsi(value);
                Internal.SetScriptCallbackFunction_0((__Instance + __PointerAdjustment), arg0);
                Marshal.FreeHGlobal(arg0);
            }
        }

        public ulong ThreadID
        {
            get
            {
                var __ret = Internal.GetThreadID_0((__Instance + __PointerAdjustment));
                return __ret;
            }

            set
            {
                Internal.SetThreadID_0((__Instance + __PointerAdjustment), value);
            }
        }

        public uint ThreadIndex
        {
            get
            {
                var __ret = Internal.GetThreadIndex_0((__Instance + __PointerAdjustment));
                return __ret;
            }

            set
            {
                Internal.SetThreadIndex_0((__Instance + __PointerAdjustment), value);
            }
        }

        public string ThreadName
        {
            get
            {
                var __ret = Internal.GetThreadName_0((__Instance + __PointerAdjustment));
                return Marshal.PtrToStringAnsi(__ret);
            }

            set
            {
                var arg0 = Marshal.StringToHGlobalAnsi(value);
                Internal.SetThreadName_0((__Instance + __PointerAdjustment), arg0);
                Marshal.FreeHGlobal(arg0);
            }
        }

        public string QueueName
        {
            get
            {
                var __ret = Internal.GetQueueName_0((__Instance + __PointerAdjustment));
                return Marshal.PtrToStringAnsi(__ret);
            }

            set
            {
                var arg0 = Marshal.StringToHGlobalAnsi(value);
                Internal.SetQueueName_0((__Instance + __PointerAdjustment), arg0);
                Marshal.FreeHGlobal(arg0);
            }
        }
    }
}