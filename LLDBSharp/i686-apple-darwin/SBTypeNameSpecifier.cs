//----------------------------------------------------------------------------
// This is autogenerated code by CppSharp.
// Do not edit this file or all your changes will be lost after re-generation.
//----------------------------------------------------------------------------
using System;
using System.Runtime.InteropServices;
using System.Security;

namespace LLDB
{
    public unsafe partial class TypeNameSpecifier : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 8)]
        public partial struct Internal
        {
            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb19SBTypeNameSpecifierC2Ev")]
            internal static extern void ctor_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb19SBTypeNameSpecifierC2EPKcb")]
            internal static extern void ctor_1(global::System.IntPtr instance, global::System.IntPtr name, bool is_regex);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb19SBTypeNameSpecifierC2ENS_6SBTypeE")]
            internal static extern void ctor_2(global::System.IntPtr instance, LLDB.Type.Internal type);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb19SBTypeNameSpecifierC2ERKS0_")]
            internal static extern void cctor_3(global::System.IntPtr instance, global::System.IntPtr rhs);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb19SBTypeNameSpecifierD2Ev")]
            internal static extern void dtor_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZNK4lldb19SBTypeNameSpecifier7IsValidEv")]
            [return: MarshalAsAttribute(UnmanagedType.I1)]
            internal static extern bool IsValid_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb19SBTypeNameSpecifier7GetTypeEv")]
            internal static extern void GetType_0(global::System.IntPtr @return, global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb19SBTypeNameSpecifier7IsRegexEv")]
            [return: MarshalAsAttribute(UnmanagedType.I1)]
            internal static extern bool IsRegex_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb19SBTypeNameSpecifier14GetDescriptionERNS_8SBStreamENS_16DescriptionLevelE")]
            [return: MarshalAsAttribute(UnmanagedType.I1)]
            internal static extern bool GetDescription_0(global::System.IntPtr instance, global::System.IntPtr description, LLDB.DescriptionLevel description_level);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb19SBTypeNameSpecifier9IsEqualToERS0_")]
            [return: MarshalAsAttribute(UnmanagedType.I1)]
            internal static extern bool IsEqualTo_0(global::System.IntPtr instance, global::System.IntPtr rhs);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb19SBTypeNameSpecifiereqERS0_")]
            [return: MarshalAsAttribute(UnmanagedType.I1)]
            internal static extern bool OperatorEqualEqual_0(global::System.IntPtr instance, global::System.IntPtr rhs);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb19SBTypeNameSpecifierneERS0_")]
            [return: MarshalAsAttribute(UnmanagedType.I1)]
            internal static extern bool OperatorExclaimEqual_0(global::System.IntPtr instance, global::System.IntPtr rhs);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb19SBTypeNameSpecifier7GetNameEv")]
            internal static extern global::System.IntPtr GetName_0(global::System.IntPtr instance);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        public static readonly System.Collections.Concurrent.ConcurrentDictionary<IntPtr, TypeNameSpecifier> NativeToManagedMap = new System.Collections.Concurrent.ConcurrentDictionary<IntPtr, TypeNameSpecifier>();
        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        public static TypeNameSpecifier __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new TypeNameSpecifier(native.ToPointer(), skipVTables);
        }

        public static TypeNameSpecifier __CreateInstance(TypeNameSpecifier.Internal native, bool skipVTables = false)
        {
            return new TypeNameSpecifier(native, skipVTables);
        }

        private static void* __CopyValue(TypeNameSpecifier.Internal native)
        {
            var ret = Marshal.AllocHGlobal(8);
            LLDB.TypeNameSpecifier.Internal.cctor_3(ret, new global::System.IntPtr(&native));
            return ret.ToPointer();
        }

        private TypeNameSpecifier(TypeNameSpecifier.Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected TypeNameSpecifier(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public TypeNameSpecifier()
        {
            __Instance = Marshal.AllocHGlobal(8);
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            Internal.ctor_0((__Instance + __PointerAdjustment));
        }

        public TypeNameSpecifier(string name, bool is_regex)
        {
            __Instance = Marshal.AllocHGlobal(8);
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            var arg0 = Marshal.StringToHGlobalAnsi(name);
            Internal.ctor_1((__Instance + __PointerAdjustment), arg0, is_regex);
            Marshal.FreeHGlobal(arg0);
        }

        public TypeNameSpecifier(LLDB.Type type)
        {
            __Instance = Marshal.AllocHGlobal(8);
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            var arg0 = ReferenceEquals(type, null) ? new LLDB.Type.Internal() : *(LLDB.Type.Internal*) (type.__Instance);
            Internal.ctor_2((__Instance + __PointerAdjustment), arg0);
        }

        public TypeNameSpecifier(LLDB.TypeNameSpecifier rhs)
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
            LLDB.TypeNameSpecifier __dummy;
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

        public LLDB.Type GetType()
        {
            var __ret = new LLDB.Type.Internal();
            Internal.GetType_0(new IntPtr(&__ret), (__Instance + __PointerAdjustment));
            return LLDB.Type.__CreateInstance(__ret);
        }

        public bool IsRegex()
        {
            var __ret = Internal.IsRegex_0((__Instance + __PointerAdjustment));
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

        public bool IsEqualTo(LLDB.TypeNameSpecifier rhs)
        {
            if (ReferenceEquals(rhs, null))
                throw new global::System.ArgumentNullException("rhs", "Cannot be null because it is a C++ reference (&).");
            var arg0 = rhs.__Instance;
            var __ret = Internal.IsEqualTo_0((__Instance + __PointerAdjustment), arg0);
            return __ret;
        }

        public static bool operator ==(LLDB.TypeNameSpecifier __op, LLDB.TypeNameSpecifier rhs)
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
            return this == obj as TypeNameSpecifier;
        }

        public override int GetHashCode()
        {
            if (__Instance == global::System.IntPtr.Zero)
                return global::System.IntPtr.Zero.GetHashCode();
            return (*(Internal*) __Instance).GetHashCode();
        }

        public static bool operator !=(LLDB.TypeNameSpecifier __op, LLDB.TypeNameSpecifier rhs)
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

        public string Name
        {
            get
            {
                var __ret = Internal.GetName_0((__Instance + __PointerAdjustment));
                return Marshal.PtrToStringAnsi(__ret);
            }
        }
    }
}