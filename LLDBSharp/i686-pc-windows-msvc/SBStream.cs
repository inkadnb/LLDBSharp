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
    public unsafe partial class Stream : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 8)]
        public partial struct Internal
        {
            [FieldOffset(4)]
            public byte m_is_file;

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="??0SBStream@lldb@@QAE@XZ")]
            internal static extern global::System.IntPtr ctor_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="??1SBStream@lldb@@QAE@XZ")]
            internal static extern void dtor_0(global::System.IntPtr instance, int delete);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?IsValid@SBStream@lldb@@QBE_NXZ")]
            [return: MarshalAsAttribute(UnmanagedType.I1)]
            internal static extern bool IsValid_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="?Printf@SBStream@lldb@@QAAXPBDZZ")]
            internal static extern void Printf_0(global::System.IntPtr instance, global::System.IntPtr format);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?RedirectToFile@SBStream@lldb@@QAEXPBD_N@Z")]
            internal static extern void RedirectToFile_0(global::System.IntPtr instance, global::System.IntPtr path, bool append);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?RedirectToFileHandle@SBStream@lldb@@QAEXPAU_iobuf@@_N@Z")]
            internal static extern void RedirectToFileHandle_0(global::System.IntPtr instance, global::System.IntPtr fh, bool transfer_fh_ownership);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?RedirectToFileDescriptor@SBStream@lldb@@QAEXH_N@Z")]
            internal static extern void RedirectToFileDescriptor_0(global::System.IntPtr instance, int fd, bool transfer_fh_ownership);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?Clear@SBStream@lldb@@QAEXXZ")]
            internal static extern void Clear_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?GetData@SBStream@lldb@@QAEPBDXZ")]
            internal static extern global::System.IntPtr GetData_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?GetSize@SBStream@lldb@@QAEIXZ")]
            internal static extern uint GetSize_0(global::System.IntPtr instance);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        public static readonly System.Collections.Concurrent.ConcurrentDictionary<IntPtr, Stream> NativeToManagedMap = new System.Collections.Concurrent.ConcurrentDictionary<IntPtr, Stream>();
        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        public static Stream __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new Stream(native.ToPointer(), skipVTables);
        }

        public static Stream __CreateInstance(Stream.Internal native, bool skipVTables = false)
        {
            return new Stream(native, skipVTables);
        }

        private static void* __CopyValue(Stream.Internal native)
        {
            var ret = Marshal.AllocHGlobal(8);
            *(Stream.Internal*) ret = native;
            return ret.ToPointer();
        }

        private Stream(Stream.Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected Stream(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public Stream()
        {
            __Instance = Marshal.AllocHGlobal(8);
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            Internal.ctor_0((__Instance + __PointerAdjustment));
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        protected virtual void Dispose(bool disposing)
        {
            LLDB.Stream __dummy;
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

        public void Printf(string format)
        {
            var arg0 = Marshal.StringToHGlobalAnsi(format);
            Internal.Printf_0((__Instance + __PointerAdjustment), arg0);
            Marshal.FreeHGlobal(arg0);
        }

        public void RedirectToFile(string path, bool append)
        {
            var arg0 = Marshal.StringToHGlobalAnsi(path);
            Internal.RedirectToFile_0((__Instance + __PointerAdjustment), arg0, append);
            Marshal.FreeHGlobal(arg0);
        }

        public void RedirectToFileHandle(global::System.IntPtr fh, bool transfer_fh_ownership)
        {
            var arg0 = fh;
            Internal.RedirectToFileHandle_0((__Instance + __PointerAdjustment), arg0, transfer_fh_ownership);
        }

        public void RedirectToFileDescriptor(int fd, bool transfer_fh_ownership)
        {
            Internal.RedirectToFileDescriptor_0((__Instance + __PointerAdjustment), fd, transfer_fh_ownership);
        }

        public void Clear()
        {
            Internal.Clear_0((__Instance + __PointerAdjustment));
        }

        public string Data
        {
            get
            {
                var __ret = Internal.GetData_0((__Instance + __PointerAdjustment));
                return Marshal.PtrToStringAnsi(__ret);
            }
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