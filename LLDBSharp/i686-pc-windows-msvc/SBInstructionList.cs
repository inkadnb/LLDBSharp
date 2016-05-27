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
    public unsafe partial class InstructionList : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 8)]
        public partial struct Internal
        {
            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="??0SBInstructionList@lldb@@QAE@XZ")]
            internal static extern global::System.IntPtr ctor_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="??0SBInstructionList@lldb@@QAE@ABV01@@Z")]
            internal static extern global::System.IntPtr cctor_1(global::System.IntPtr instance, global::System.IntPtr rhs);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="??1SBInstructionList@lldb@@QAE@XZ")]
            internal static extern void dtor_0(global::System.IntPtr instance, int delete);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?IsValid@SBInstructionList@lldb@@QBE_NXZ")]
            [return: MarshalAsAttribute(UnmanagedType.I1)]
            internal static extern bool IsValid_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?GetInstructionAtIndex@SBInstructionList@lldb@@QAE?AVSBInstruction@2@I@Z")]
            internal static extern void GetInstructionAtIndex_0(global::System.IntPtr instance, global::System.IntPtr @return, uint idx);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?Clear@SBInstructionList@lldb@@QAEXXZ")]
            internal static extern void Clear_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?AppendInstruction@SBInstructionList@lldb@@QAEXVSBInstruction@2@@Z")]
            internal static extern void AppendInstruction_0(global::System.IntPtr instance, LLDB.Instruction.Internal inst);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?Print@SBInstructionList@lldb@@QAEXPAU_iobuf@@@Z")]
            internal static extern void Print_0(global::System.IntPtr instance, global::System.IntPtr @out);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?GetDescription@SBInstructionList@lldb@@QAE_NAAVSBStream@2@@Z")]
            [return: MarshalAsAttribute(UnmanagedType.I1)]
            internal static extern bool GetDescription_0(global::System.IntPtr instance, global::System.IntPtr description);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?DumpEmulationForAllInstructions@SBInstructionList@lldb@@QAE_NPBD@Z")]
            [return: MarshalAsAttribute(UnmanagedType.I1)]
            internal static extern bool DumpEmulationForAllInstructions_0(global::System.IntPtr instance, global::System.IntPtr triple);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?GetSize@SBInstructionList@lldb@@QAEIXZ")]
            internal static extern uint GetSize_0(global::System.IntPtr instance);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        public static readonly System.Collections.Concurrent.ConcurrentDictionary<IntPtr, InstructionList> NativeToManagedMap = new System.Collections.Concurrent.ConcurrentDictionary<IntPtr, InstructionList>();
        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        public static InstructionList __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new InstructionList(native.ToPointer(), skipVTables);
        }

        public static InstructionList __CreateInstance(InstructionList.Internal native, bool skipVTables = false)
        {
            return new InstructionList(native, skipVTables);
        }

        private static void* __CopyValue(InstructionList.Internal native)
        {
            var ret = Marshal.AllocHGlobal(8);
            LLDB.InstructionList.Internal.cctor_1(ret, new global::System.IntPtr(&native));
            return ret.ToPointer();
        }

        private InstructionList(InstructionList.Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected InstructionList(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public InstructionList()
        {
            __Instance = Marshal.AllocHGlobal(8);
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            Internal.ctor_0((__Instance + __PointerAdjustment));
        }

        public InstructionList(LLDB.InstructionList rhs)
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
            LLDB.InstructionList __dummy;
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

        public LLDB.Instruction GetInstructionAtIndex(uint idx)
        {
            var __ret = new LLDB.Instruction.Internal();
            Internal.GetInstructionAtIndex_0((__Instance + __PointerAdjustment), new IntPtr(&__ret), idx);
            return LLDB.Instruction.__CreateInstance(__ret);
        }

        public void Clear()
        {
            Internal.Clear_0((__Instance + __PointerAdjustment));
        }

        public void AppendInstruction(LLDB.Instruction inst)
        {
            var arg0 = ReferenceEquals(inst, null) ? new LLDB.Instruction.Internal() : *(LLDB.Instruction.Internal*) (inst.__Instance);
            Internal.AppendInstruction_0((__Instance + __PointerAdjustment), arg0);
        }

        public void Print(global::System.IntPtr @out)
        {
            var arg0 = @out;
            Internal.Print_0((__Instance + __PointerAdjustment), arg0);
        }

        public bool GetDescription(LLDB.Stream description)
        {
            if (ReferenceEquals(description, null))
                throw new global::System.ArgumentNullException("description", "Cannot be null because it is a C++ reference (&).");
            var arg0 = description.__Instance;
            var __ret = Internal.GetDescription_0((__Instance + __PointerAdjustment), arg0);
            return __ret;
        }

        public bool DumpEmulationForAllInstructions(string triple)
        {
            var arg0 = Marshal.StringToHGlobalAnsi(triple);
            var __ret = Internal.DumpEmulationForAllInstructions_0((__Instance + __PointerAdjustment), arg0);
            Marshal.FreeHGlobal(arg0);
            return __ret;
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
