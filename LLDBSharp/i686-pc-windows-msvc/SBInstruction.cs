//----------------------------------------------------------------------------
// This is autogenerated code by CppSharp.
// Do not edit this file or all your changes will be lost after re-generation.
//----------------------------------------------------------------------------
using System;
using System.Runtime.InteropServices;
using System.Security;

namespace LLDB
{
    public unsafe partial class Instruction : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 8)]
        public partial struct Internal
        {
            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="??0SBInstruction@lldb@@QAE@XZ")]
            internal static extern global::System.IntPtr ctor_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="??0SBInstruction@lldb@@QAE@ABV01@@Z")]
            internal static extern global::System.IntPtr cctor_1(global::System.IntPtr instance, global::System.IntPtr rhs);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="??1SBInstruction@lldb@@QAE@XZ")]
            internal static extern void dtor_0(global::System.IntPtr instance, int delete);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?IsValid@SBInstruction@lldb@@QAE_NXZ")]
            [return: MarshalAsAttribute(UnmanagedType.I1)]
            internal static extern bool IsValid_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?GetAddress@SBInstruction@lldb@@QAE?AVSBAddress@2@XZ")]
            internal static extern void GetAddress_0(global::System.IntPtr instance, global::System.IntPtr @return);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?GetMnemonic@SBInstruction@lldb@@QAEPBDVSBTarget@2@@Z")]
            internal static extern global::System.IntPtr GetMnemonic_0(global::System.IntPtr instance, LLDB.Target.Internal target);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?GetOperands@SBInstruction@lldb@@QAEPBDVSBTarget@2@@Z")]
            internal static extern global::System.IntPtr GetOperands_0(global::System.IntPtr instance, LLDB.Target.Internal target);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?GetComment@SBInstruction@lldb@@QAEPBDVSBTarget@2@@Z")]
            internal static extern global::System.IntPtr GetComment_0(global::System.IntPtr instance, LLDB.Target.Internal target);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?GetData@SBInstruction@lldb@@QAE?AVSBData@2@VSBTarget@2@@Z")]
            internal static extern LLDB.Data.Internal GetData_0(global::System.IntPtr instance, LLDB.Target.Internal target);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?DoesBranch@SBInstruction@lldb@@QAE_NXZ")]
            [return: MarshalAsAttribute(UnmanagedType.I1)]
            internal static extern bool DoesBranch_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?Print@SBInstruction@lldb@@QAEXPAU_iobuf@@@Z")]
            internal static extern void Print_0(global::System.IntPtr instance, global::System.IntPtr @out);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?GetDescription@SBInstruction@lldb@@QAE_NAAVSBStream@2@@Z")]
            [return: MarshalAsAttribute(UnmanagedType.I1)]
            internal static extern bool GetDescription_0(global::System.IntPtr instance, global::System.IntPtr description);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?EmulateWithFrame@SBInstruction@lldb@@QAE_NAAVSBFrame@2@I@Z")]
            [return: MarshalAsAttribute(UnmanagedType.I1)]
            internal static extern bool EmulateWithFrame_0(global::System.IntPtr instance, global::System.IntPtr frame, uint evaluate_options);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?DumpEmulation@SBInstruction@lldb@@QAE_NPBD@Z")]
            [return: MarshalAsAttribute(UnmanagedType.I1)]
            internal static extern bool DumpEmulation_0(global::System.IntPtr instance, global::System.IntPtr triple);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?TestEmulation@SBInstruction@lldb@@QAE_NAAVSBStream@2@PBD@Z")]
            [return: MarshalAsAttribute(UnmanagedType.I1)]
            internal static extern bool TestEmulation_0(global::System.IntPtr instance, global::System.IntPtr output_stream, global::System.IntPtr test_file);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?GetAddressClass@SBInstruction@lldb@@QAE?AW4AddressClass@2@XZ")]
            internal static extern LLDB.AddressClass GetAddressClass_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?GetByteSize@SBInstruction@lldb@@QAEIXZ")]
            internal static extern uint GetByteSize_0(global::System.IntPtr instance);
        }

        public global::System.IntPtr __Instance { get; protected set; }
        public static readonly System.Collections.Concurrent.ConcurrentDictionary<IntPtr, Instruction> NativeToManagedMap = new System.Collections.Concurrent.ConcurrentDictionary<IntPtr, Instruction>();

        private readonly bool __ownsNativeInstance;

        public static Instruction __CreateInstance(global::System.IntPtr native)
        {
            return new Instruction((Instruction.Internal*) native);
        }

        public static Instruction __CreateInstance(Instruction.Internal native)
        {
            return new Instruction(native);
        }

        private static Instruction.Internal* __CopyValue(Instruction.Internal native)
        {
            var ret = (Instruction.Internal*) Marshal.AllocHGlobal(8);
            *ret = native;
            return ret;
        }

        private Instruction(Instruction.Internal native)
            : this(__CopyValue(native))
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected Instruction(Instruction.Internal* native, bool isInternalImpl = false)
        {
            __Instance = new global::System.IntPtr(native);
        }

        public Instruction()
        {
            __Instance = Marshal.AllocHGlobal(8);
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            Internal.ctor_0(__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        protected virtual void Dispose(bool disposing)
        {
            DestroyNativeInstance(false);
        }

        public virtual void DestroyNativeInstance()
        {
            DestroyNativeInstance(true);
        }

        private void DestroyNativeInstance(bool force)
        {
            LLDB.Instruction __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance || force)
                Internal.dtor_0(__Instance, 0);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
        }

        public bool IsValid()
        {
            var __ret = Internal.IsValid_0(__Instance);
            return __ret;
        }

        public LLDB.Address GetAddress()
        {
            var __ret = new LLDB.Address.Internal();
            Internal.GetAddress_0(__Instance, new IntPtr(&__ret));
            return LLDB.Address.__CreateInstance(__ret);
        }

        public string GetMnemonic(LLDB.Target target)
        {
            var arg0 = ReferenceEquals(target, null) ? new LLDB.Target.Internal() : *(LLDB.Target.Internal*) (target.__Instance);
            var __ret = Internal.GetMnemonic_0(__Instance, arg0);
            return Marshal.PtrToStringAnsi(__ret);
        }

        public string GetOperands(LLDB.Target target)
        {
            var arg0 = ReferenceEquals(target, null) ? new LLDB.Target.Internal() : *(LLDB.Target.Internal*) (target.__Instance);
            var __ret = Internal.GetOperands_0(__Instance, arg0);
            return Marshal.PtrToStringAnsi(__ret);
        }

        public string GetComment(LLDB.Target target)
        {
            var arg0 = ReferenceEquals(target, null) ? new LLDB.Target.Internal() : *(LLDB.Target.Internal*) (target.__Instance);
            var __ret = Internal.GetComment_0(__Instance, arg0);
            return Marshal.PtrToStringAnsi(__ret);
        }

        public LLDB.Data GetData(LLDB.Target target)
        {
            var arg0 = ReferenceEquals(target, null) ? new LLDB.Target.Internal() : *(LLDB.Target.Internal*) (target.__Instance);
            var __ret = Internal.GetData_0(__Instance, arg0);
            return LLDB.Data.__CreateInstance(__ret);
        }

        public bool DoesBranch()
        {
            var __ret = Internal.DoesBranch_0(__Instance);
            return __ret;
        }

        public void Print(global::System.IntPtr @out)
        {
            var arg0 = @out
            ;
            Internal.Print_0(__Instance, arg0);
        }

        public bool GetDescription(LLDB.Stream description)
        {
            var arg0 = ReferenceEquals(description, null) ? global::System.IntPtr.Zero : description.__Instance;
            var __ret = Internal.GetDescription_0(__Instance, arg0);
            return __ret;
        }

        public bool EmulateWithFrame(LLDB.Frame frame, uint evaluate_options)
        {
            var arg0 = ReferenceEquals(frame, null) ? global::System.IntPtr.Zero : frame.__Instance;
            var arg1 = evaluate_options;
            var __ret = Internal.EmulateWithFrame_0(__Instance, arg0, arg1);
            return __ret;
        }

        public bool DumpEmulation(string triple)
        {
            var arg0 = Marshal.StringToHGlobalAnsi(triple);
            var __ret = Internal.DumpEmulation_0(__Instance, arg0);
            Marshal.FreeHGlobal(arg0);
            return __ret;
        }

        public bool TestEmulation(LLDB.Stream output_stream, string test_file)
        {
            var arg0 = ReferenceEquals(output_stream, null) ? global::System.IntPtr.Zero : output_stream.__Instance;
            var arg1 = Marshal.StringToHGlobalAnsi(test_file);
            var __ret = Internal.TestEmulation_0(__Instance, arg0, arg1);
            Marshal.FreeHGlobal(arg1);
            return __ret;
        }

        public LLDB.AddressClass AddressClass
        {
            get
            {
                var __ret = Internal.GetAddressClass_0(__Instance);
                return __ret;
            }
        }

        public uint ByteSize
        {
            get
            {
                var __ret = Internal.GetByteSize_0(__Instance);
                return __ret;
            }
        }
    }
}
