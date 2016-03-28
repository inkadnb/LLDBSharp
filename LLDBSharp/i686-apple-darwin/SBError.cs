//----------------------------------------------------------------------------
// This is autogenerated code by CppSharp.
// Do not edit this file or all your changes will be lost after re-generation.
//----------------------------------------------------------------------------
using System;
using System.Runtime.InteropServices;
using System.Security;

namespace LLDB
{
    public unsafe partial class Error : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 4)]
        public partial struct Internal
        {
            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb7SBErrorC2Ev")]
            internal static extern void ctor_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb7SBErrorC2ERKS0_")]
            internal static extern void cctor_1(global::System.IntPtr instance, global::System.IntPtr rhs);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb7SBErrorD2Ev")]
            internal static extern void dtor_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb7SBError5ClearEv")]
            internal static extern void Clear_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZNK4lldb7SBError4FailEv")]
            [return: MarshalAsAttribute(UnmanagedType.I1)]
            internal static extern bool Fail_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZNK4lldb7SBError7SuccessEv")]
            [return: MarshalAsAttribute(UnmanagedType.I1)]
            internal static extern bool Success_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb7SBError8SetErrorEjNS_9ErrorTypeE")]
            internal static extern void SetError_0(global::System.IntPtr instance, uint err, LLDB.ErrorType type);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb7SBError15SetErrorToErrnoEv")]
            internal static extern void SetErrorToErrno_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb7SBError22SetErrorToGenericErrorEv")]
            internal static extern void SetErrorToGenericError_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb7SBError24SetErrorStringWithFormatEPKcz")]
            internal static extern int SetErrorStringWithFormat_0(global::System.IntPtr instance, global::System.IntPtr format);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZNK4lldb7SBError7IsValidEv")]
            [return: MarshalAsAttribute(UnmanagedType.I1)]
            internal static extern bool IsValid_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb7SBError14GetDescriptionERNS_8SBStreamE")]
            [return: MarshalAsAttribute(UnmanagedType.I1)]
            internal static extern bool GetDescription_0(global::System.IntPtr instance, global::System.IntPtr description);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZNK4lldb7SBError10GetCStringEv")]
            internal static extern global::System.IntPtr GetCString_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZNK4lldb7SBError8GetErrorEv")]
            internal static extern uint GetErrorCode_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZNK4lldb7SBError7GetTypeEv")]
            internal static extern LLDB.ErrorType GetType_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb7SBError14SetErrorStringEPKc")]
            internal static extern void SetErrorString_0(global::System.IntPtr instance, global::System.IntPtr err_str);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        public static readonly System.Collections.Concurrent.ConcurrentDictionary<IntPtr, Error> NativeToManagedMap = new System.Collections.Concurrent.ConcurrentDictionary<IntPtr, Error>();
        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        public static Error __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new Error(native.ToPointer(), skipVTables);
        }

        public static Error __CreateInstance(Error.Internal native, bool skipVTables = false)
        {
            return new Error(native, skipVTables);
        }

        private static void* __CopyValue(Error.Internal native)
        {
            var ret = Marshal.AllocHGlobal(4);
            LLDB.Error.Internal.cctor_1(ret, new global::System.IntPtr(&native));
            return ret.ToPointer();
        }

        private Error(Error.Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected Error(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public Error()
        {
            __Instance = Marshal.AllocHGlobal(4);
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            Internal.ctor_0((__Instance + __PointerAdjustment));
        }

        public Error(LLDB.Error rhs)
        {
            __Instance = Marshal.AllocHGlobal(4);
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
            LLDB.Error __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            Internal.dtor_0((__Instance + __PointerAdjustment));
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
        }

        public void Clear()
        {
            Internal.Clear_0((__Instance + __PointerAdjustment));
        }

        public bool Fail()
        {
            var __ret = Internal.Fail_0((__Instance + __PointerAdjustment));
            return __ret;
        }

        public bool Success()
        {
            var __ret = Internal.Success_0((__Instance + __PointerAdjustment));
            return __ret;
        }

        public void SetError(uint err, LLDB.ErrorType type)
        {
            var arg1 = type;
            Internal.SetError_0((__Instance + __PointerAdjustment), err, arg1);
        }

        public void SetErrorToErrno()
        {
            Internal.SetErrorToErrno_0((__Instance + __PointerAdjustment));
        }

        public void SetErrorToGenericError()
        {
            Internal.SetErrorToGenericError_0((__Instance + __PointerAdjustment));
        }

        public int SetErrorStringWithFormat(string format)
        {
            var arg0 = Marshal.StringToHGlobalAnsi(format);
            var __ret = Internal.SetErrorStringWithFormat_0((__Instance + __PointerAdjustment), arg0);
            Marshal.FreeHGlobal(arg0);
            return __ret;
        }

        public bool IsValid()
        {
            var __ret = Internal.IsValid_0((__Instance + __PointerAdjustment));
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

        public string CString
        {
            get
            {
                var __ret = Internal.GetCString_0((__Instance + __PointerAdjustment));
                return Marshal.PtrToStringAnsi(__ret);
            }
        }

        public uint ErrorCode
        {
            get
            {
                var __ret = Internal.GetErrorCode_0((__Instance + __PointerAdjustment));
                return __ret;
            }
        }

        public LLDB.ErrorType Type
        {
            get
            {
                var __ret = Internal.GetType_0((__Instance + __PointerAdjustment));
                return __ret;
            }
        }

        public string ErrorString
        {
            set
            {
                var arg0 = Marshal.StringToHGlobalAnsi(value);
                Internal.SetErrorString_0((__Instance + __PointerAdjustment), arg0);
                Marshal.FreeHGlobal(arg0);
            }
        }
    }
}
