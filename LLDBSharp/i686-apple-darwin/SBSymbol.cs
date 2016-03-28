//----------------------------------------------------------------------------
// This is autogenerated code by CppSharp.
// Do not edit this file or all your changes will be lost after re-generation.
//----------------------------------------------------------------------------
using System;
using System.Runtime.InteropServices;
using System.Security;

namespace LLDB
{
    public unsafe partial class Symbol : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 4)]
        public partial struct Internal
        {
            [FieldOffset(0)]
            public global::System.IntPtr m_opaque_ptr;

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb8SBSymbolC2Ev")]
            internal static extern void ctor_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb8SBSymbolC2ERKS0_")]
            internal static extern void cctor_1(global::System.IntPtr instance, global::System.IntPtr rhs);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb8SBSymbolD2Ev")]
            internal static extern void dtor_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZNK4lldb8SBSymbol7IsValidEv")]
            [return: MarshalAsAttribute(UnmanagedType.I1)]
            internal static extern bool IsValid_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb8SBSymbol15GetInstructionsENS_8SBTargetE")]
            internal static extern void GetInstructions_0(global::System.IntPtr @return, global::System.IntPtr instance, LLDB.Target.Internal target);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb8SBSymbol15GetInstructionsENS_8SBTargetEPKc")]
            internal static extern void GetInstructions_1(global::System.IntPtr @return, global::System.IntPtr instance, LLDB.Target.Internal target, global::System.IntPtr flavor_string);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb8SBSymbol15GetStartAddressEv")]
            internal static extern void GetStartAddress_0(global::System.IntPtr @return, global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb8SBSymbol13GetEndAddressEv")]
            internal static extern void GetEndAddress_0(global::System.IntPtr @return, global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZNK4lldb8SBSymboleqERKS0_")]
            [return: MarshalAsAttribute(UnmanagedType.I1)]
            internal static extern bool OperatorEqualEqual_0(global::System.IntPtr instance, global::System.IntPtr rhs);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZNK4lldb8SBSymbolneERKS0_")]
            [return: MarshalAsAttribute(UnmanagedType.I1)]
            internal static extern bool OperatorExclaimEqual_0(global::System.IntPtr instance, global::System.IntPtr rhs);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb8SBSymbol14GetDescriptionERNS_8SBStreamE")]
            [return: MarshalAsAttribute(UnmanagedType.I1)]
            internal static extern bool GetDescription_0(global::System.IntPtr instance, global::System.IntPtr description);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb8SBSymbol10IsExternalEv")]
            [return: MarshalAsAttribute(UnmanagedType.I1)]
            internal static extern bool IsExternal_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb8SBSymbol11IsSyntheticEv")]
            [return: MarshalAsAttribute(UnmanagedType.I1)]
            internal static extern bool IsSynthetic_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZNK4lldb8SBSymbol7GetNameEv")]
            internal static extern global::System.IntPtr GetName_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZNK4lldb8SBSymbol14GetDisplayNameEv")]
            internal static extern global::System.IntPtr GetDisplayName_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZNK4lldb8SBSymbol14GetMangledNameEv")]
            internal static extern global::System.IntPtr GetMangledName_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb8SBSymbol19GetPrologueByteSizeEv")]
            internal static extern uint GetPrologueByteSize_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb8SBSymbol7GetTypeEv")]
            internal static extern LLDB.SymbolType GetType_0(global::System.IntPtr instance);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        public static readonly System.Collections.Concurrent.ConcurrentDictionary<IntPtr, Symbol> NativeToManagedMap = new System.Collections.Concurrent.ConcurrentDictionary<IntPtr, Symbol>();
        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        public static Symbol __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new Symbol(native.ToPointer(), skipVTables);
        }

        public static Symbol __CreateInstance(Symbol.Internal native, bool skipVTables = false)
        {
            return new Symbol(native, skipVTables);
        }

        private static void* __CopyValue(Symbol.Internal native)
        {
            var ret = Marshal.AllocHGlobal(4);
            LLDB.Symbol.Internal.cctor_1(ret, new global::System.IntPtr(&native));
            return ret.ToPointer();
        }

        private Symbol(Symbol.Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected Symbol(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public Symbol()
        {
            __Instance = Marshal.AllocHGlobal(4);
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            Internal.ctor_0((__Instance + __PointerAdjustment));
        }

        public Symbol(LLDB.Symbol rhs)
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
            LLDB.Symbol __dummy;
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

        public LLDB.InstructionList GetInstructions(LLDB.Target target)
        {
            var arg0 = ReferenceEquals(target, null) ? new LLDB.Target.Internal() : *(LLDB.Target.Internal*) (target.__Instance);
            var __ret = new LLDB.InstructionList.Internal();
            Internal.GetInstructions_0(new IntPtr(&__ret), (__Instance + __PointerAdjustment), arg0);
            return LLDB.InstructionList.__CreateInstance(__ret);
        }

        public LLDB.InstructionList GetInstructions(LLDB.Target target, string flavor_string)
        {
            var arg0 = ReferenceEquals(target, null) ? new LLDB.Target.Internal() : *(LLDB.Target.Internal*) (target.__Instance);
            var arg1 = Marshal.StringToHGlobalAnsi(flavor_string);
            var __ret = new LLDB.InstructionList.Internal();
            Internal.GetInstructions_1(new IntPtr(&__ret), (__Instance + __PointerAdjustment), arg0, arg1);
            Marshal.FreeHGlobal(arg1);
            return LLDB.InstructionList.__CreateInstance(__ret);
        }

        public LLDB.Address GetStartAddress()
        {
            var __ret = new LLDB.Address.Internal();
            Internal.GetStartAddress_0(new IntPtr(&__ret), (__Instance + __PointerAdjustment));
            return LLDB.Address.__CreateInstance(__ret);
        }

        public LLDB.Address GetEndAddress()
        {
            var __ret = new LLDB.Address.Internal();
            Internal.GetEndAddress_0(new IntPtr(&__ret), (__Instance + __PointerAdjustment));
            return LLDB.Address.__CreateInstance(__ret);
        }

        public static bool operator ==(LLDB.Symbol __op, LLDB.Symbol rhs)
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
            return this == obj as Symbol;
        }

        public override int GetHashCode()
        {
            if (__Instance == global::System.IntPtr.Zero)
                return global::System.IntPtr.Zero.GetHashCode();
            return (*(Internal*) __Instance).GetHashCode();
        }

        public static bool operator !=(LLDB.Symbol __op, LLDB.Symbol rhs)
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

        public bool IsExternal()
        {
            var __ret = Internal.IsExternal_0((__Instance + __PointerAdjustment));
            return __ret;
        }

        public bool IsSynthetic()
        {
            var __ret = Internal.IsSynthetic_0((__Instance + __PointerAdjustment));
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

        public string DisplayName
        {
            get
            {
                var __ret = Internal.GetDisplayName_0((__Instance + __PointerAdjustment));
                return Marshal.PtrToStringAnsi(__ret);
            }
        }

        public string MangledName
        {
            get
            {
                var __ret = Internal.GetMangledName_0((__Instance + __PointerAdjustment));
                return Marshal.PtrToStringAnsi(__ret);
            }
        }

        public uint PrologueByteSize
        {
            get
            {
                var __ret = Internal.GetPrologueByteSize_0((__Instance + __PointerAdjustment));
                return __ret;
            }
        }

        public LLDB.SymbolType Type
        {
            get
            {
                var __ret = Internal.GetType_0((__Instance + __PointerAdjustment));
                return __ret;
            }
        }
    }
}
