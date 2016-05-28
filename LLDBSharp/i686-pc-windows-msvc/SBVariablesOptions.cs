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
    public unsafe partial class VariablesOptions : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 4)]
        public partial struct Internal
        {
            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="??0SBVariablesOptions@lldb@@QAE@XZ")]
            internal static extern global::System.IntPtr ctor_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="??0SBVariablesOptions@lldb@@QAE@ABV01@@Z")]
            internal static extern global::System.IntPtr cctor_1(global::System.IntPtr instance, global::System.IntPtr options);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="??1SBVariablesOptions@lldb@@QAE@XZ")]
            internal static extern void dtor_0(global::System.IntPtr instance, int delete);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?IsValid@SBVariablesOptions@lldb@@QBE_NXZ")]
            [return: MarshalAsAttribute(UnmanagedType.I1)]
            internal static extern bool IsValid_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?GetIncludeArguments@SBVariablesOptions@lldb@@QBE_NXZ")]
            [return: MarshalAsAttribute(UnmanagedType.I1)]
            internal static extern bool GetIncludeArguments_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?SetIncludeArguments@SBVariablesOptions@lldb@@QAEX_N@Z")]
            internal static extern void SetIncludeArguments_0(global::System.IntPtr instance, bool _0);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?GetIncludeLocals@SBVariablesOptions@lldb@@QBE_NXZ")]
            [return: MarshalAsAttribute(UnmanagedType.I1)]
            internal static extern bool GetIncludeLocals_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?SetIncludeLocals@SBVariablesOptions@lldb@@QAEX_N@Z")]
            internal static extern void SetIncludeLocals_0(global::System.IntPtr instance, bool _0);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?GetIncludeStatics@SBVariablesOptions@lldb@@QBE_NXZ")]
            [return: MarshalAsAttribute(UnmanagedType.I1)]
            internal static extern bool GetIncludeStatics_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?SetIncludeStatics@SBVariablesOptions@lldb@@QAEX_N@Z")]
            internal static extern void SetIncludeStatics_0(global::System.IntPtr instance, bool _0);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?GetInScopeOnly@SBVariablesOptions@lldb@@QBE_NXZ")]
            [return: MarshalAsAttribute(UnmanagedType.I1)]
            internal static extern bool GetInScopeOnly_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?SetInScopeOnly@SBVariablesOptions@lldb@@QAEX_N@Z")]
            internal static extern void SetInScopeOnly_0(global::System.IntPtr instance, bool _0);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?GetIncludeRuntimeSupportValues@SBVariablesOptions@lldb@@QBE_NXZ")]
            [return: MarshalAsAttribute(UnmanagedType.I1)]
            internal static extern bool GetIncludeRuntimeSupportValues_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?SetIncludeRuntimeSupportValues@SBVariablesOptions@lldb@@QAEX_N@Z")]
            internal static extern void SetIncludeRuntimeSupportValues_0(global::System.IntPtr instance, bool _0);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?GetUseDynamic@SBVariablesOptions@lldb@@QBE?AW4DynamicValueType@2@XZ")]
            internal static extern LLDB.DynamicValueType GetUseDynamic_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?SetUseDynamic@SBVariablesOptions@lldb@@QAEXW4DynamicValueType@2@@Z")]
            internal static extern void SetUseDynamic_0(global::System.IntPtr instance, LLDB.DynamicValueType _0);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        public static readonly System.Collections.Concurrent.ConcurrentDictionary<IntPtr, VariablesOptions> NativeToManagedMap = new System.Collections.Concurrent.ConcurrentDictionary<IntPtr, VariablesOptions>();
        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        public static VariablesOptions __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new VariablesOptions(native.ToPointer(), skipVTables);
        }

        public static VariablesOptions __CreateInstance(VariablesOptions.Internal native, bool skipVTables = false)
        {
            return new VariablesOptions(native, skipVTables);
        }

        private static void* __CopyValue(VariablesOptions.Internal native)
        {
            var ret = Marshal.AllocHGlobal(4);
            LLDB.VariablesOptions.Internal.cctor_1(ret, new global::System.IntPtr(&native));
            return ret.ToPointer();
        }

        private VariablesOptions(VariablesOptions.Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected VariablesOptions(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public VariablesOptions()
        {
            __Instance = Marshal.AllocHGlobal(4);
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            Internal.ctor_0((__Instance + __PointerAdjustment));
        }

        public VariablesOptions(LLDB.VariablesOptions options)
        {
            __Instance = Marshal.AllocHGlobal(4);
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            if (ReferenceEquals(options, null))
                throw new global::System.ArgumentNullException("options", "Cannot be null because it is a C++ reference (&).");
            var arg0 = options.__Instance;
            Internal.cctor_1((__Instance + __PointerAdjustment), arg0);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        protected virtual void Dispose(bool disposing)
        {
            LLDB.VariablesOptions __dummy;
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

        public bool IncludeArguments
        {
            get
            {
                var __ret = Internal.GetIncludeArguments_0((__Instance + __PointerAdjustment));
                return __ret;
            }

            set
            {
                Internal.SetIncludeArguments_0((__Instance + __PointerAdjustment), value);
            }
        }

        public bool IncludeLocals
        {
            get
            {
                var __ret = Internal.GetIncludeLocals_0((__Instance + __PointerAdjustment));
                return __ret;
            }

            set
            {
                Internal.SetIncludeLocals_0((__Instance + __PointerAdjustment), value);
            }
        }

        public bool IncludeStatics
        {
            get
            {
                var __ret = Internal.GetIncludeStatics_0((__Instance + __PointerAdjustment));
                return __ret;
            }

            set
            {
                Internal.SetIncludeStatics_0((__Instance + __PointerAdjustment), value);
            }
        }

        public bool InScopeOnly
        {
            get
            {
                var __ret = Internal.GetInScopeOnly_0((__Instance + __PointerAdjustment));
                return __ret;
            }

            set
            {
                Internal.SetInScopeOnly_0((__Instance + __PointerAdjustment), value);
            }
        }

        public bool IncludeRuntimeSupportValues
        {
            get
            {
                var __ret = Internal.GetIncludeRuntimeSupportValues_0((__Instance + __PointerAdjustment));
                return __ret;
            }

            set
            {
                Internal.SetIncludeRuntimeSupportValues_0((__Instance + __PointerAdjustment), value);
            }
        }

        public LLDB.DynamicValueType UseDynamic
        {
            get
            {
                var __ret = Internal.GetUseDynamic_0((__Instance + __PointerAdjustment));
                return __ret;
            }

            set
            {
                var arg0 = value;
                Internal.SetUseDynamic_0((__Instance + __PointerAdjustment), arg0);
            }
        }
    }
}