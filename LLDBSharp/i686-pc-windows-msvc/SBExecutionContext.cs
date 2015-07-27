//----------------------------------------------------------------------------
// This is autogenerated code by CppSharp.
// Do not edit this file or all your changes will be lost after re-generation.
//----------------------------------------------------------------------------
using System;
using System.Runtime.InteropServices;
using System.Security;

namespace LLDB
{
    public unsafe partial class ExecutionContext : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 8)]
        public partial struct Internal
        {
            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="??0SBExecutionContext@lldb@@QAE@XZ")]
            internal static extern global::System.IntPtr ctor_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="??0SBExecutionContext@lldb@@QAE@ABV01@@Z")]
            internal static extern global::System.IntPtr cctor_1(global::System.IntPtr instance, global::System.IntPtr rhs);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="??0SBExecutionContext@lldb@@QAE@ABVSBTarget@1@@Z")]
            internal static extern global::System.IntPtr ctor_3(global::System.IntPtr instance, global::System.IntPtr target);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="??0SBExecutionContext@lldb@@QAE@ABVSBProcess@1@@Z")]
            internal static extern global::System.IntPtr ctor_4(global::System.IntPtr instance, global::System.IntPtr process);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="??0SBExecutionContext@lldb@@QAE@VSBThread@1@@Z")]
            internal static extern global::System.IntPtr ctor_5(global::System.IntPtr instance, LLDB.Thread.Internal thread);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="??0SBExecutionContext@lldb@@QAE@ABVSBFrame@1@@Z")]
            internal static extern global::System.IntPtr ctor_6(global::System.IntPtr instance, global::System.IntPtr frame);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="??1SBExecutionContext@lldb@@QAE@XZ")]
            internal static extern void dtor_0(global::System.IntPtr instance, int delete);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?GetTarget@SBExecutionContext@lldb@@QBE?AVSBTarget@2@XZ")]
            internal static extern void GetTarget_0(global::System.IntPtr instance, global::System.IntPtr @return);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?GetProcess@SBExecutionContext@lldb@@QBE?AVSBProcess@2@XZ")]
            internal static extern void GetProcess_0(global::System.IntPtr instance, global::System.IntPtr @return);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?GetThread@SBExecutionContext@lldb@@QBE?AVSBThread@2@XZ")]
            internal static extern void GetThread_0(global::System.IntPtr instance, global::System.IntPtr @return);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?GetFrame@SBExecutionContext@lldb@@QBE?AVSBFrame@2@XZ")]
            internal static extern void GetFrame_0(global::System.IntPtr instance, global::System.IntPtr @return);
        }

        public global::System.IntPtr __Instance { get; protected set; }
        public static readonly System.Collections.Concurrent.ConcurrentDictionary<IntPtr, ExecutionContext> NativeToManagedMap = new System.Collections.Concurrent.ConcurrentDictionary<IntPtr, ExecutionContext>();

        private readonly bool __ownsNativeInstance;

        public static ExecutionContext __CreateInstance(global::System.IntPtr native)
        {
            return new ExecutionContext((ExecutionContext.Internal*) native);
        }

        public static ExecutionContext __CreateInstance(ExecutionContext.Internal native)
        {
            return new ExecutionContext(native);
        }

        private static ExecutionContext.Internal* __CopyValue(ExecutionContext.Internal native)
        {
            var ret = (ExecutionContext.Internal*) Marshal.AllocHGlobal(8);
            *ret = native;
            return ret;
        }

        private ExecutionContext(ExecutionContext.Internal native)
            : this(__CopyValue(native))
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected ExecutionContext(ExecutionContext.Internal* native, bool isInternalImpl = false)
        {
            __Instance = new global::System.IntPtr(native);
        }

        public ExecutionContext()
        {
            __Instance = Marshal.AllocHGlobal(8);
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            Internal.ctor_0(__Instance);
        }

        public ExecutionContext(LLDB.Target target)
        {
            __Instance = Marshal.AllocHGlobal(8);
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            var arg0 = ReferenceEquals(target, null) ? global::System.IntPtr.Zero : target.__Instance;
            Internal.ctor_3(__Instance, arg0);
        }

        public ExecutionContext(LLDB.Process process)
        {
            __Instance = Marshal.AllocHGlobal(8);
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            var arg0 = ReferenceEquals(process, null) ? global::System.IntPtr.Zero : process.__Instance;
            Internal.ctor_4(__Instance, arg0);
        }

        public ExecutionContext(LLDB.Thread thread)
        {
            __Instance = Marshal.AllocHGlobal(8);
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            var arg0 = ReferenceEquals(thread, null) ? new LLDB.Thread.Internal() : *(LLDB.Thread.Internal*) (thread.__Instance);
            Internal.ctor_5(__Instance, arg0);
        }

        public ExecutionContext(LLDB.Frame frame)
        {
            __Instance = Marshal.AllocHGlobal(8);
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            var arg0 = ReferenceEquals(frame, null) ? global::System.IntPtr.Zero : frame.__Instance;
            Internal.ctor_6(__Instance, arg0);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        protected virtual void Dispose(bool disposing)
        {
            DestroyNativeInstance(false);
        }

        public virtual void DestroyNativeInstance()
        {
            DestroyNativeInstance(true);
        }

        private void DestroyNativeInstance(bool force)
        {
            LLDB.ExecutionContext __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance || force)
                Internal.dtor_0(__Instance, 0);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
        }

        public LLDB.Target GetTarget()
        {
            var __ret = new LLDB.Target.Internal();
            Internal.GetTarget_0(__Instance, new IntPtr(&__ret));
            return LLDB.Target.__CreateInstance(__ret);
        }

        public LLDB.Process GetProcess()
        {
            var __ret = new LLDB.Process.Internal();
            Internal.GetProcess_0(__Instance, new IntPtr(&__ret));
            return LLDB.Process.__CreateInstance(__ret);
        }

        public LLDB.Thread GetThread()
        {
            var __ret = new LLDB.Thread.Internal();
            Internal.GetThread_0(__Instance, new IntPtr(&__ret));
            return LLDB.Thread.__CreateInstance(__ret);
        }

        public LLDB.Frame GetFrame()
        {
            var __ret = new LLDB.Frame.Internal();
            Internal.GetFrame_0(__Instance, new IntPtr(&__ret));
            return LLDB.Frame.__CreateInstance(__ret);
        }
    }
}
