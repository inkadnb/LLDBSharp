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
    public unsafe partial class Block : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 4)]
        public partial struct Internal
        {
            [FieldOffset(0)]
            public global::System.IntPtr m_opaque_ptr;

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="??0SBBlock@lldb@@QAE@XZ")]
            internal static extern global::System.IntPtr ctor_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="??0SBBlock@lldb@@QAE@ABV01@@Z")]
            internal static extern global::System.IntPtr cctor_1(global::System.IntPtr instance, global::System.IntPtr rhs);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="??1SBBlock@lldb@@QAE@XZ")]
            internal static extern void dtor_0(global::System.IntPtr instance, int delete);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?IsInlined@SBBlock@lldb@@QBE_NXZ")]
            [return: MarshalAsAttribute(UnmanagedType.I1)]
            internal static extern bool IsInlined_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?IsValid@SBBlock@lldb@@QBE_NXZ")]
            [return: MarshalAsAttribute(UnmanagedType.I1)]
            internal static extern bool IsValid_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?GetInlinedCallSiteFile@SBBlock@lldb@@QBE?AVSBFileSpec@2@XZ")]
            internal static extern void GetInlinedCallSiteFile_0(global::System.IntPtr instance, global::System.IntPtr @return);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?GetParent@SBBlock@lldb@@QAE?AV12@XZ")]
            internal static extern void GetParent_0(global::System.IntPtr instance, global::System.IntPtr @return);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?GetSibling@SBBlock@lldb@@QAE?AV12@XZ")]
            internal static extern void GetSibling_0(global::System.IntPtr instance, global::System.IntPtr @return);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?GetFirstChild@SBBlock@lldb@@QAE?AV12@XZ")]
            internal static extern void GetFirstChild_0(global::System.IntPtr instance, global::System.IntPtr @return);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?GetRangeStartAddress@SBBlock@lldb@@QAE?AVSBAddress@2@I@Z")]
            internal static extern void GetRangeStartAddress_0(global::System.IntPtr instance, global::System.IntPtr @return, uint idx);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?GetRangeEndAddress@SBBlock@lldb@@QAE?AVSBAddress@2@I@Z")]
            internal static extern void GetRangeEndAddress_0(global::System.IntPtr instance, global::System.IntPtr @return, uint idx);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?GetRangeIndexForBlockAddress@SBBlock@lldb@@QAEIVSBAddress@2@@Z")]
            internal static extern uint GetRangeIndexForBlockAddress_0(global::System.IntPtr instance, LLDB.Address.Internal block_addr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?GetVariables@SBBlock@lldb@@QAE?AVSBValueList@2@AAVSBFrame@2@_N11W4DynamicValueType@2@@Z")]
            internal static extern void GetVariables_0(global::System.IntPtr instance, global::System.IntPtr @return, global::System.IntPtr frame, bool arguments, bool locals, bool statics, LLDB.DynamicValueType use_dynamic);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?GetVariables@SBBlock@lldb@@QAE?AVSBValueList@2@AAVSBTarget@2@_N11@Z")]
            internal static extern void GetVariables_1(global::System.IntPtr instance, global::System.IntPtr @return, global::System.IntPtr target, bool arguments, bool locals, bool statics);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?GetContainingInlinedBlock@SBBlock@lldb@@QAE?AV12@XZ")]
            internal static extern void GetContainingInlinedBlock_0(global::System.IntPtr instance, global::System.IntPtr @return);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?GetDescription@SBBlock@lldb@@QAE_NAAVSBStream@2@@Z")]
            [return: MarshalAsAttribute(UnmanagedType.I1)]
            internal static extern bool GetDescription_0(global::System.IntPtr instance, global::System.IntPtr description);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?GetInlinedName@SBBlock@lldb@@QBEPBDXZ")]
            internal static extern global::System.IntPtr GetInlinedName_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?GetInlinedCallSiteLine@SBBlock@lldb@@QBEIXZ")]
            internal static extern uint GetInlinedCallSiteLine_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?GetInlinedCallSiteColumn@SBBlock@lldb@@QBEIXZ")]
            internal static extern uint GetInlinedCallSiteColumn_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?GetNumRanges@SBBlock@lldb@@QAEIXZ")]
            internal static extern uint GetNumRanges_0(global::System.IntPtr instance);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        public static readonly System.Collections.Concurrent.ConcurrentDictionary<IntPtr, Block> NativeToManagedMap = new System.Collections.Concurrent.ConcurrentDictionary<IntPtr, Block>();
        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        public static Block __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new Block(native.ToPointer(), skipVTables);
        }

        public static Block __CreateInstance(Block.Internal native, bool skipVTables = false)
        {
            return new Block(native, skipVTables);
        }

        private static void* __CopyValue(Block.Internal native)
        {
            var ret = Marshal.AllocHGlobal(4);
            LLDB.Block.Internal.cctor_1(ret, new global::System.IntPtr(&native));
            return ret.ToPointer();
        }

        private Block(Block.Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected Block(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public Block()
        {
            __Instance = Marshal.AllocHGlobal(4);
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            Internal.ctor_0((__Instance + __PointerAdjustment));
        }

        public Block(LLDB.Block rhs)
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
            LLDB.Block __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            Internal.dtor_0((__Instance + __PointerAdjustment), 0);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
        }

        public bool IsInlined()
        {
            var __ret = Internal.IsInlined_0((__Instance + __PointerAdjustment));
            return __ret;
        }

        public bool IsValid()
        {
            var __ret = Internal.IsValid_0((__Instance + __PointerAdjustment));
            return __ret;
        }

        public LLDB.FileSpec GetInlinedCallSiteFile()
        {
            var __ret = new LLDB.FileSpec.Internal();
            Internal.GetInlinedCallSiteFile_0((__Instance + __PointerAdjustment), new IntPtr(&__ret));
            return LLDB.FileSpec.__CreateInstance(__ret);
        }

        public LLDB.Block GetParent()
        {
            var __ret = new LLDB.Block.Internal();
            Internal.GetParent_0((__Instance + __PointerAdjustment), new IntPtr(&__ret));
            return LLDB.Block.__CreateInstance(__ret);
        }

        public LLDB.Block GetSibling()
        {
            var __ret = new LLDB.Block.Internal();
            Internal.GetSibling_0((__Instance + __PointerAdjustment), new IntPtr(&__ret));
            return LLDB.Block.__CreateInstance(__ret);
        }

        public LLDB.Block GetFirstChild()
        {
            var __ret = new LLDB.Block.Internal();
            Internal.GetFirstChild_0((__Instance + __PointerAdjustment), new IntPtr(&__ret));
            return LLDB.Block.__CreateInstance(__ret);
        }

        public LLDB.Address GetRangeStartAddress(uint idx)
        {
            var __ret = new LLDB.Address.Internal();
            Internal.GetRangeStartAddress_0((__Instance + __PointerAdjustment), new IntPtr(&__ret), idx);
            return LLDB.Address.__CreateInstance(__ret);
        }

        public LLDB.Address GetRangeEndAddress(uint idx)
        {
            var __ret = new LLDB.Address.Internal();
            Internal.GetRangeEndAddress_0((__Instance + __PointerAdjustment), new IntPtr(&__ret), idx);
            return LLDB.Address.__CreateInstance(__ret);
        }

        public uint GetRangeIndexForBlockAddress(LLDB.Address block_addr)
        {
            var arg0 = ReferenceEquals(block_addr, null) ? new LLDB.Address.Internal() : *(LLDB.Address.Internal*) (block_addr.__Instance);
            var __ret = Internal.GetRangeIndexForBlockAddress_0((__Instance + __PointerAdjustment), arg0);
            return __ret;
        }

        public LLDB.ValueList GetVariables(LLDB.Frame frame, bool arguments, bool locals, bool statics, LLDB.DynamicValueType use_dynamic)
        {
            if (ReferenceEquals(frame, null))
                throw new global::System.ArgumentNullException("frame", "Cannot be null because it is a C++ reference (&).");
            var arg0 = frame.__Instance;
            var arg4 = use_dynamic;
            var __ret = new LLDB.ValueList.Internal();
            Internal.GetVariables_0((__Instance + __PointerAdjustment), new IntPtr(&__ret), arg0, arguments, locals, statics, arg4);
            return LLDB.ValueList.__CreateInstance(__ret);
        }

        public LLDB.ValueList GetVariables(LLDB.Target target, bool arguments, bool locals, bool statics)
        {
            if (ReferenceEquals(target, null))
                throw new global::System.ArgumentNullException("target", "Cannot be null because it is a C++ reference (&).");
            var arg0 = target.__Instance;
            var __ret = new LLDB.ValueList.Internal();
            Internal.GetVariables_1((__Instance + __PointerAdjustment), new IntPtr(&__ret), arg0, arguments, locals, statics);
            return LLDB.ValueList.__CreateInstance(__ret);
        }

        /// <summary>
        /// <para>Get the inlined block that contains this block.</para>
        /// </summary>
        /// <returns>
        /// <para>If this block is inlined, it will return this block, else</para>
        /// <para>parent blocks will be searched to see if any contain this</para>
        /// <para>block and are themselves inlined. An invalid SBBlock will</para>
        /// <para>be returned if this block nor any parent blocks are inlined</para>
        /// <para>function blocks.</para>
        /// </returns>
        public LLDB.Block GetContainingInlinedBlock()
        {
            var __ret = new LLDB.Block.Internal();
            Internal.GetContainingInlinedBlock_0((__Instance + __PointerAdjustment), new IntPtr(&__ret));
            return LLDB.Block.__CreateInstance(__ret);
        }

        public bool GetDescription(LLDB.Stream description)
        {
            if (ReferenceEquals(description, null))
                throw new global::System.ArgumentNullException("description", "Cannot be null because it is a C++ reference (&).");
            var arg0 = description.__Instance;
            var __ret = Internal.GetDescription_0((__Instance + __PointerAdjustment), arg0);
            return __ret;
        }

        public string InlinedName
        {
            get
            {
                var __ret = Internal.GetInlinedName_0((__Instance + __PointerAdjustment));
                return Marshal.PtrToStringAnsi(__ret);
            }
        }

        public uint InlinedCallSiteLine
        {
            get
            {
                var __ret = Internal.GetInlinedCallSiteLine_0((__Instance + __PointerAdjustment));
                return __ret;
            }
        }

        public uint InlinedCallSiteColumn
        {
            get
            {
                var __ret = Internal.GetInlinedCallSiteColumn_0((__Instance + __PointerAdjustment));
                return __ret;
            }
        }

        public uint NumRanges
        {
            get
            {
                var __ret = Internal.GetNumRanges_0((__Instance + __PointerAdjustment));
                return __ret;
            }
        }
    }
}
