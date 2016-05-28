//----------------------------------------------------------------------------
// This is autogenerated code by CppSharp.
// Do not edit this file or all your changes will be lost after re-generation.
//----------------------------------------------------------------------------
using System;
using System.Runtime.InteropServices;
using System.Security;

namespace LLDB
{
    public unsafe partial class TypeEnumMember : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 8)]
        public partial struct Internal
        {
            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb16SBTypeEnumMemberC2Ev")]
            internal static extern void ctor_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb16SBTypeEnumMemberC2ERKS0_")]
            internal static extern void cctor_1(global::System.IntPtr instance, global::System.IntPtr rhs);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb16SBTypeEnumMemberD2Ev")]
            internal static extern void dtor_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZNK4lldb16SBTypeEnumMember7IsValidEv")]
            [return: MarshalAsAttribute(UnmanagedType.I1)]
            internal static extern bool IsValid_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb16SBTypeEnumMember7GetTypeEv")]
            internal static extern void GetType_0(global::System.IntPtr @return, global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb16SBTypeEnumMember14GetDescriptionERNS_8SBStreamENS_16DescriptionLevelE")]
            [return: MarshalAsAttribute(UnmanagedType.I1)]
            internal static extern bool GetDescription_0(global::System.IntPtr instance, global::System.IntPtr description, LLDB.DescriptionLevel description_level);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb16SBTypeEnumMember16GetValueAsSignedEv")]
            internal static extern long GetValueAsSigned_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb16SBTypeEnumMember18GetValueAsUnsignedEv")]
            internal static extern ulong GetValueAsUnsigned_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb16SBTypeEnumMember7GetNameEv")]
            internal static extern global::System.IntPtr GetName_0(global::System.IntPtr instance);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        public static readonly System.Collections.Concurrent.ConcurrentDictionary<IntPtr, TypeEnumMember> NativeToManagedMap = new System.Collections.Concurrent.ConcurrentDictionary<IntPtr, TypeEnumMember>();
        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        public static TypeEnumMember __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new TypeEnumMember(native.ToPointer(), skipVTables);
        }

        public static TypeEnumMember __CreateInstance(TypeEnumMember.Internal native, bool skipVTables = false)
        {
            return new TypeEnumMember(native, skipVTables);
        }

        private static void* __CopyValue(TypeEnumMember.Internal native)
        {
            var ret = Marshal.AllocHGlobal(8);
            LLDB.TypeEnumMember.Internal.cctor_1(ret, new global::System.IntPtr(&native));
            return ret.ToPointer();
        }

        private TypeEnumMember(TypeEnumMember.Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected TypeEnumMember(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public TypeEnumMember()
        {
            __Instance = Marshal.AllocHGlobal(8);
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            Internal.ctor_0((__Instance + __PointerAdjustment));
        }

        public TypeEnumMember(LLDB.TypeEnumMember rhs)
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
            LLDB.TypeEnumMember __dummy;
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

        public bool GetDescription(LLDB.Stream description, LLDB.DescriptionLevel description_level)
        {
            if (ReferenceEquals(description, null))
                throw new global::System.ArgumentNullException("description", "Cannot be null because it is a C++ reference (&).");
            var arg0 = description.__Instance;
            var arg1 = description_level;
            var __ret = Internal.GetDescription_0((__Instance + __PointerAdjustment), arg0, arg1);
            return __ret;
        }

        public long ValueAsSigned
        {
            get
            {
                var __ret = Internal.GetValueAsSigned_0((__Instance + __PointerAdjustment));
                return __ret;
            }
        }

        public ulong ValueAsUnsigned
        {
            get
            {
                var __ret = Internal.GetValueAsUnsigned_0((__Instance + __PointerAdjustment));
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
    }

    public unsafe partial class TypeEnumMemberList : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 4)]
        public partial struct Internal
        {
            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb20SBTypeEnumMemberListC2Ev")]
            internal static extern void ctor_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb20SBTypeEnumMemberListC2ERKS0_")]
            internal static extern void cctor_1(global::System.IntPtr instance, global::System.IntPtr rhs);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb20SBTypeEnumMemberListD2Ev")]
            internal static extern void dtor_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb20SBTypeEnumMemberList7IsValidEv")]
            [return: MarshalAsAttribute(UnmanagedType.I1)]
            internal static extern bool IsValid_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb20SBTypeEnumMemberList6AppendENS_16SBTypeEnumMemberE")]
            internal static extern void Append_0(global::System.IntPtr instance, LLDB.TypeEnumMember.Internal entry);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb20SBTypeEnumMemberList24GetTypeEnumMemberAtIndexEj")]
            internal static extern void GetTypeEnumMemberAtIndex_0(global::System.IntPtr @return, global::System.IntPtr instance, uint index);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb20SBTypeEnumMemberList7GetSizeEv")]
            internal static extern uint GetSize_0(global::System.IntPtr instance);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        public static readonly System.Collections.Concurrent.ConcurrentDictionary<IntPtr, TypeEnumMemberList> NativeToManagedMap = new System.Collections.Concurrent.ConcurrentDictionary<IntPtr, TypeEnumMemberList>();
        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        public static TypeEnumMemberList __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new TypeEnumMemberList(native.ToPointer(), skipVTables);
        }

        public static TypeEnumMemberList __CreateInstance(TypeEnumMemberList.Internal native, bool skipVTables = false)
        {
            return new TypeEnumMemberList(native, skipVTables);
        }

        private static void* __CopyValue(TypeEnumMemberList.Internal native)
        {
            var ret = Marshal.AllocHGlobal(4);
            LLDB.TypeEnumMemberList.Internal.cctor_1(ret, new global::System.IntPtr(&native));
            return ret.ToPointer();
        }

        private TypeEnumMemberList(TypeEnumMemberList.Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected TypeEnumMemberList(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public TypeEnumMemberList()
        {
            __Instance = Marshal.AllocHGlobal(4);
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            Internal.ctor_0((__Instance + __PointerAdjustment));
        }

        public TypeEnumMemberList(LLDB.TypeEnumMemberList rhs)
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
            LLDB.TypeEnumMemberList __dummy;
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

        public void Append(LLDB.TypeEnumMember entry)
        {
            var arg0 = ReferenceEquals(entry, null) ? new LLDB.TypeEnumMember.Internal() : *(LLDB.TypeEnumMember.Internal*) (entry.__Instance);
            Internal.Append_0((__Instance + __PointerAdjustment), arg0);
        }

        public LLDB.TypeEnumMember GetTypeEnumMemberAtIndex(uint index)
        {
            var __ret = new LLDB.TypeEnumMember.Internal();
            Internal.GetTypeEnumMemberAtIndex_0(new IntPtr(&__ret), (__Instance + __PointerAdjustment), index);
            return LLDB.TypeEnumMember.__CreateInstance(__ret);
        }

        public uint Size
        {
            get
            {
                var __ret = Internal.GetSize_0((__Instance + __PointerAdjustment));
                return __ret;
            }
        }
    }
}