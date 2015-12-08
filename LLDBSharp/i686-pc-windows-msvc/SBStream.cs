//----------------------------------------------------------------------------
// This is autogenerated code by CppSharp.
// Do not edit this file or all your changes will be lost after re-generation.
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
            public bool m_is_file;

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
        public static readonly System.Collections.Concurrent.ConcurrentDictionary<IntPtr, Stream> NativeToManagedMap = new System.Collections.Concurrent.ConcurrentDictionary<IntPtr, Stream>();

        private readonly bool __ownsNativeInstance;

        public static Stream __CreateInstance(global::System.IntPtr native)
        {
            return new Stream((Stream.Internal*) native);
        }

        public static Stream __CreateInstance(Stream.Internal native)
        {
            return new Stream(native);
        }

        private static Stream.Internal* __CopyValue(Stream.Internal native)
        {
            var ret = (Stream.Internal*) Marshal.AllocHGlobal(8);
            *ret = native;
            return ret;
        }

        private Stream(Stream.Internal native)
            : this(__CopyValue(native))
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected Stream(Stream.Internal* native, bool isInternalImpl = false)
        {
            __Instance = new global::System.IntPtr(native);
        }

        public Stream()
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
            LLDB.Stream __dummy;
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

        public void Printf(string format)
        {
            var arg0 = Marshal.StringToHGlobalAnsi(format);
            Internal.Printf_0(__Instance, arg0);
            Marshal.FreeHGlobal(arg0);
        }

        public void RedirectToFile(string path, bool append)
        {
            var arg0 = Marshal.StringToHGlobalAnsi(path);
            Internal.RedirectToFile_0(__Instance, arg0, append);
            Marshal.FreeHGlobal(arg0);
        }

        public void RedirectToFileHandle(global::System.IntPtr fh, bool transfer_fh_ownership)
        {
            var arg0 = fh;
            Internal.RedirectToFileHandle_0(__Instance, arg0, transfer_fh_ownership);
        }

        public void RedirectToFileDescriptor(int fd, bool transfer_fh_ownership)
        {
            Internal.RedirectToFileDescriptor_0(__Instance, fd, transfer_fh_ownership);
        }

        public void Clear()
        {
            Internal.Clear_0(__Instance);
        }

        public string Data
        {
            get
            {
                var __ret = Internal.GetData_0(__Instance);
                return Marshal.PtrToStringAnsi(__ret);
            }
        }

        public uint Size
        {
            get
            {
                var __ret = Internal.GetSize_0(__Instance);
                return __ret;
            }
        }
    }
}
