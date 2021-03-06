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
    public unsafe partial class HostOS : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 0)]
        public partial struct Internal
        {
            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="??0SBHostOS@lldb@@QAE@ABV01@@Z")]
            internal static extern global::System.IntPtr cctor_1(global::System.IntPtr instance, global::System.IntPtr _0);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="?GetProgramFileSpec@SBHostOS@lldb@@SA?AVSBFileSpec@2@XZ")]
            internal static extern void GetProgramFileSpec_0(global::System.IntPtr @return);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="?GetLLDBPythonPath@SBHostOS@lldb@@SA?AVSBFileSpec@2@XZ")]
            internal static extern void GetLLDBPythonPath_0(global::System.IntPtr @return);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="?GetLLDBPath@SBHostOS@lldb@@SA?AVSBFileSpec@2@W4PathType@2@@Z")]
            internal static extern void GetLLDBPath_0(global::System.IntPtr @return, LLDB.PathType path_type);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="?GetUserHomeDirectory@SBHostOS@lldb@@SA?AVSBFileSpec@2@XZ")]
            internal static extern void GetUserHomeDirectory_0(global::System.IntPtr @return);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="?ThreadCreated@SBHostOS@lldb@@SAXPBD@Z")]
            internal static extern void ThreadCreated_0(global::System.IntPtr name);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="?ThreadCreate@SBHostOS@lldb@@SAPAXPBDP6AIPAX@Z1PAVSBError@2@@Z")]
            internal static extern global::System.IntPtr ThreadCreate_0(global::System.IntPtr name, global::System.IntPtr thread_function, global::System.IntPtr thread_arg, global::System.IntPtr err);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="?ThreadCancel@SBHostOS@lldb@@SA_NPAXPAVSBError@2@@Z")]
            [return: MarshalAsAttribute(UnmanagedType.I1)]
            internal static extern bool ThreadCancel_0(global::System.IntPtr thread, global::System.IntPtr err);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="?ThreadDetach@SBHostOS@lldb@@SA_NPAXPAVSBError@2@@Z")]
            [return: MarshalAsAttribute(UnmanagedType.I1)]
            internal static extern bool ThreadDetach_0(global::System.IntPtr thread, global::System.IntPtr err);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="?ThreadJoin@SBHostOS@lldb@@SA_NPAXPAIPAVSBError@2@@Z")]
            [return: MarshalAsAttribute(UnmanagedType.I1)]
            internal static extern bool ThreadJoin_0(global::System.IntPtr thread, uint* result, global::System.IntPtr err);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        public static readonly System.Collections.Concurrent.ConcurrentDictionary<IntPtr, HostOS> NativeToManagedMap = new System.Collections.Concurrent.ConcurrentDictionary<IntPtr, HostOS>();
        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        public static HostOS __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new HostOS(native.ToPointer(), skipVTables);
        }

        public static HostOS __CreateInstance(HostOS.Internal native, bool skipVTables = false)
        {
            return new HostOS(native, skipVTables);
        }

        private static void* __CopyValue(HostOS.Internal native)
        {
            var ret = Marshal.AllocHGlobal(0);
            *(HostOS.Internal*) ret = native;
            return ret.ToPointer();
        }

        private HostOS(HostOS.Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected HostOS(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public HostOS()
        {
            __Instance = Marshal.AllocHGlobal(0);
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public HostOS(LLDB.HostOS _0)
        {
            __Instance = Marshal.AllocHGlobal(0);
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((HostOS.Internal*) __Instance) = *((HostOS.Internal*) _0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        protected virtual void Dispose(bool disposing)
        {
            LLDB.HostOS __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
        }

        public static LLDB.FileSpec GetProgramFileSpec()
        {
            var __ret = new LLDB.FileSpec.Internal();
            Internal.GetProgramFileSpec_0(new IntPtr(&__ret));
            return LLDB.FileSpec.__CreateInstance(__ret);
        }

        public static LLDB.FileSpec GetLLDBPythonPath()
        {
            var __ret = new LLDB.FileSpec.Internal();
            Internal.GetLLDBPythonPath_0(new IntPtr(&__ret));
            return LLDB.FileSpec.__CreateInstance(__ret);
        }

        public static LLDB.FileSpec GetLLDBPath(LLDB.PathType path_type)
        {
            var arg0 = path_type;
            var __ret = new LLDB.FileSpec.Internal();
            Internal.GetLLDBPath_0(new IntPtr(&__ret), arg0);
            return LLDB.FileSpec.__CreateInstance(__ret);
        }

        public static LLDB.FileSpec GetUserHomeDirectory()
        {
            var __ret = new LLDB.FileSpec.Internal();
            Internal.GetUserHomeDirectory_0(new IntPtr(&__ret));
            return LLDB.FileSpec.__CreateInstance(__ret);
        }

        public static void ThreadCreated(string name)
        {
            var arg0 = Marshal.StringToHGlobalAnsi(name);
            Internal.ThreadCreated_0(arg0);
            Marshal.FreeHGlobal(arg0);
        }

        public static global::System.IntPtr ThreadCreate(string name, LLDB.thread_func_t thread_function, global::System.IntPtr thread_arg, LLDB.Error err)
        {
            var arg0 = Marshal.StringToHGlobalAnsi(name);
            var arg1 = thread_function == null ? global::System.IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(thread_function);
            var arg2 = thread_arg;
            var arg3 = ReferenceEquals(err, null) ? global::System.IntPtr.Zero : err.__Instance;
            var __ret = Internal.ThreadCreate_0(arg0, arg1, arg2, arg3);
            Marshal.FreeHGlobal(arg0);
            return __ret;
        }

        public static bool ThreadCancel(global::System.IntPtr thread, LLDB.Error err)
        {
            var arg0 = thread;
            var arg1 = ReferenceEquals(err, null) ? global::System.IntPtr.Zero : err.__Instance;
            var __ret = Internal.ThreadCancel_0(arg0, arg1);
            return __ret;
        }

        public static bool ThreadDetach(global::System.IntPtr thread, LLDB.Error err)
        {
            var arg0 = thread;
            var arg1 = ReferenceEquals(err, null) ? global::System.IntPtr.Zero : err.__Instance;
            var __ret = Internal.ThreadDetach_0(arg0, arg1);
            return __ret;
        }

        public static bool ThreadJoin(global::System.IntPtr thread, ref uint result, LLDB.Error err)
        {
            var arg0 = thread;
            fixed (uint* __refParamPtr1 = &result)
            {
                var arg1 = __refParamPtr1;
                var arg2 = ReferenceEquals(err, null) ? global::System.IntPtr.Zero : err.__Instance;
                var __ret = Internal.ThreadJoin_0(arg0, arg1, arg2);
                return __ret;
            }
        }
    }
}
