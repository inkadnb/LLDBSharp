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
    public unsafe partial class LanguageRuntime : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 0)]
        public partial struct Internal
        {
            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="??0SBLanguageRuntime@lldb@@QAE@ABV01@@Z")]
            internal static extern global::System.IntPtr cctor_1(global::System.IntPtr instance, global::System.IntPtr _0);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="?GetLanguageTypeFromString@SBLanguageRuntime@lldb@@SA?AW4LanguageType@2@PBD@Z")]
            internal static extern LLDB.LanguageType GetLanguageTypeFromString_0(global::System.IntPtr @string);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="?GetNameForLanguageType@SBLanguageRuntime@lldb@@SAPBDW4LanguageType@2@@Z")]
            internal static extern global::System.IntPtr GetNameForLanguageType_0(LLDB.LanguageType language);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        public static readonly System.Collections.Concurrent.ConcurrentDictionary<IntPtr, LanguageRuntime> NativeToManagedMap = new System.Collections.Concurrent.ConcurrentDictionary<IntPtr, LanguageRuntime>();
        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        public static LanguageRuntime __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new LanguageRuntime(native.ToPointer(), skipVTables);
        }

        public static LanguageRuntime __CreateInstance(LanguageRuntime.Internal native, bool skipVTables = false)
        {
            return new LanguageRuntime(native, skipVTables);
        }

        private static void* __CopyValue(LanguageRuntime.Internal native)
        {
            var ret = Marshal.AllocHGlobal(0);
            *(LanguageRuntime.Internal*) ret = native;
            return ret.ToPointer();
        }

        private LanguageRuntime(LanguageRuntime.Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected LanguageRuntime(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public LanguageRuntime()
        {
            __Instance = Marshal.AllocHGlobal(0);
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public LanguageRuntime(LLDB.LanguageRuntime _0)
        {
            __Instance = Marshal.AllocHGlobal(0);
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((LanguageRuntime.Internal*) __Instance) = *((LanguageRuntime.Internal*) _0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        protected virtual void Dispose(bool disposing)
        {
            LLDB.LanguageRuntime __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
        }

        public static LLDB.LanguageType GetLanguageTypeFromString(string @string)
        {
            var arg0 = Marshal.StringToHGlobalAnsi(@string);
            var __ret = Internal.GetLanguageTypeFromString_0(arg0);
            Marshal.FreeHGlobal(arg0);
            return __ret;
        }

        public static string GetNameForLanguageType(LLDB.LanguageType language)
        {
            var arg0 = language;
            var __ret = Internal.GetNameForLanguageType_0(arg0);
            return Marshal.PtrToStringAnsi(__ret);
        }
    }
}

namespace Delegates
{
    [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointerAttribute(global::System.Runtime.InteropServices.CallingConvention.ThisCall)]
    public unsafe delegate void Action_IntPtr_int(global::System.IntPtr instance, int arg1);

    [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointerAttribute(global::System.Runtime.InteropServices.CallingConvention.ThisCall)]
    public unsafe delegate bool Func_bool_IntPtr_LLDB_Debugger_Internal_sbytePtrPtr_IntPtr(global::System.IntPtr instance, LLDB.Debugger.Internal arg1, sbyte** arg2, global::System.IntPtr arg3);
}
