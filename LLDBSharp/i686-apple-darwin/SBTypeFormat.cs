//----------------------------------------------------------------------------
// This is autogenerated code by CppSharp.
// Do not edit this file or all your changes will be lost after re-generation.
//----------------------------------------------------------------------------
using System;
using System.Runtime.InteropServices;
using System.Security;

namespace LLDB
{
    public unsafe partial class TypeFormat : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 8)]
        public partial struct Internal
        {
            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb12SBTypeFormatC2Ev")]
            internal static extern void ctor_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb12SBTypeFormatC2ENS_6FormatEj")]
            internal static extern void ctor_1(global::System.IntPtr instance, LLDB.Format format, uint options);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb12SBTypeFormatC2EPKcj")]
            internal static extern void ctor_2(global::System.IntPtr instance, global::System.IntPtr type, uint options);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb12SBTypeFormatC2ERKS0_")]
            internal static extern void cctor_3(global::System.IntPtr instance, global::System.IntPtr rhs);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb12SBTypeFormatD2Ev")]
            internal static extern void dtor_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZNK4lldb12SBTypeFormat7IsValidEv")]
            [return: MarshalAsAttribute(UnmanagedType.I1)]
            internal static extern bool IsValid_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb12SBTypeFormat14GetDescriptionERNS_8SBStreamENS_16DescriptionLevelE")]
            [return: MarshalAsAttribute(UnmanagedType.I1)]
            internal static extern bool GetDescription_0(global::System.IntPtr instance, global::System.IntPtr description, LLDB.DescriptionLevel description_level);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb12SBTypeFormat9IsEqualToERS0_")]
            [return: MarshalAsAttribute(UnmanagedType.I1)]
            internal static extern bool IsEqualTo_0(global::System.IntPtr instance, global::System.IntPtr rhs);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb12SBTypeFormateqERS0_")]
            [return: MarshalAsAttribute(UnmanagedType.I1)]
            internal static extern bool OperatorEqualEqual_0(global::System.IntPtr instance, global::System.IntPtr rhs);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb12SBTypeFormatneERS0_")]
            [return: MarshalAsAttribute(UnmanagedType.I1)]
            internal static extern bool OperatorExclaimEqual_0(global::System.IntPtr instance, global::System.IntPtr rhs);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb12SBTypeFormat9GetFormatEv")]
            internal static extern LLDB.Format GetFormat_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb12SBTypeFormat9SetFormatENS_6FormatE")]
            internal static extern void SetFormat_0(global::System.IntPtr instance, LLDB.Format _0);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb12SBTypeFormat11GetTypeNameEv")]
            internal static extern global::System.IntPtr GetTypeName_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb12SBTypeFormat11SetTypeNameEPKc")]
            internal static extern void SetTypeName_0(global::System.IntPtr instance, global::System.IntPtr _0);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb12SBTypeFormat10GetOptionsEv")]
            internal static extern uint GetOptions_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb12SBTypeFormat10SetOptionsEj")]
            internal static extern void SetOptions_0(global::System.IntPtr instance, uint _0);
        }

        protected enum Type
        {
            KeepSame = 0,
            Format = 1,
            Enum = 2
        }

        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        public static readonly System.Collections.Concurrent.ConcurrentDictionary<IntPtr, TypeFormat> NativeToManagedMap = new System.Collections.Concurrent.ConcurrentDictionary<IntPtr, TypeFormat>();
        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        public static TypeFormat __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new TypeFormat(native.ToPointer(), skipVTables);
        }

        public static TypeFormat __CreateInstance(TypeFormat.Internal native, bool skipVTables = false)
        {
            return new TypeFormat(native, skipVTables);
        }

        private static void* __CopyValue(TypeFormat.Internal native)
        {
            var ret = Marshal.AllocHGlobal(8);
            LLDB.TypeFormat.Internal.cctor_3(ret, new global::System.IntPtr(&native));
            return ret.ToPointer();
        }

        private TypeFormat(TypeFormat.Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected TypeFormat(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public TypeFormat()
        {
            __Instance = Marshal.AllocHGlobal(8);
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            Internal.ctor_0((__Instance + __PointerAdjustment));
        }

        public TypeFormat(LLDB.Format format, uint options)
        {
            __Instance = Marshal.AllocHGlobal(8);
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            var arg0 = format;
            Internal.ctor_1((__Instance + __PointerAdjustment), arg0, options);
        }

        public TypeFormat(string type, uint options)
        {
            __Instance = Marshal.AllocHGlobal(8);
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            var arg0 = Marshal.StringToHGlobalAnsi(type);
            Internal.ctor_2((__Instance + __PointerAdjustment), arg0, options);
            Marshal.FreeHGlobal(arg0);
        }

        public TypeFormat(LLDB.TypeFormat rhs)
        {
            __Instance = Marshal.AllocHGlobal(8);
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            if (ReferenceEquals(rhs, null))
                throw new global::System.ArgumentNullException("rhs", "Cannot be null because it is a C++ reference (&).");
            var arg0 = rhs.__Instance;
            Internal.cctor_3((__Instance + __PointerAdjustment), arg0);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        protected virtual void Dispose(bool disposing)
        {
            LLDB.TypeFormat __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            Internal.dtor_0((__Instance + __PointerAdjustment));
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
        }

        public bool IsValid()
        {
            var __ret = Internal.IsValid_0((__Instance + __PointerAdjustment));
            return __ret;
        }

        public bool GetDescription(LLDB.Stream description, LLDB.DescriptionLevel description_level)
        {
            if (ReferenceEquals(description, null))
                throw new global::System.ArgumentNullException("description", "Cannot be null because it is a C++ reference (&).");
            var arg0 = description.__Instance;
            var arg1 = description_level;
            var __ret = Internal.GetDescription_0((__Instance + __PointerAdjustment), arg0, arg1);
            return __ret;
        }

        public bool IsEqualTo(LLDB.TypeFormat rhs)
        {
            if (ReferenceEquals(rhs, null))
                throw new global::System.ArgumentNullException("rhs", "Cannot be null because it is a C++ reference (&).");
            var arg0 = rhs.__Instance;
            var __ret = Internal.IsEqualTo_0((__Instance + __PointerAdjustment), arg0);
            return __ret;
        }

        public static bool operator ==(LLDB.TypeFormat __op, LLDB.TypeFormat rhs)
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
            return this == obj as TypeFormat;
        }

        public override int GetHashCode()
        {
            if (__Instance == global::System.IntPtr.Zero)
                return global::System.IntPtr.Zero.GetHashCode();
            return (*(Internal*) __Instance).GetHashCode();
        }

        public static bool operator !=(LLDB.TypeFormat __op, LLDB.TypeFormat rhs)
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

        public LLDB.Format Format
        {
            get
            {
                var __ret = Internal.GetFormat_0((__Instance + __PointerAdjustment));
                return __ret;
            }

            set
            {
                var arg0 = value;
                Internal.SetFormat_0((__Instance + __PointerAdjustment), arg0);
            }
        }

        public string TypeName
        {
            get
            {
                var __ret = Internal.GetTypeName_0((__Instance + __PointerAdjustment));
                return Marshal.PtrToStringAnsi(__ret);
            }

            set
            {
                var arg0 = Marshal.StringToHGlobalAnsi(value);
                Internal.SetTypeName_0((__Instance + __PointerAdjustment), arg0);
                Marshal.FreeHGlobal(arg0);
            }
        }

        public uint Options
        {
            get
            {
                var __ret = Internal.GetOptions_0((__Instance + __PointerAdjustment));
                return __ret;
            }

            set
            {
                Internal.SetOptions_0((__Instance + __PointerAdjustment), value);
            }
        }
    }
}
