//----------------------------------------------------------------------------
// This is autogenerated code by CppSharp.
// Do not edit this file or all your changes will be lost after re-generation.
//----------------------------------------------------------------------------
using System;
using System.Runtime.InteropServices;
using System.Security;

namespace LLDB
{
    public unsafe partial class Communication : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 8)]
        public partial struct Internal
        {
            [FieldOffset(0)]
            public global::System.IntPtr m_opaque;

            [FieldOffset(4)]
            public byte m_opaque_owned;

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb15SBCommunicationC2Ev")]
            internal static extern void ctor_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb15SBCommunicationC2EPKc")]
            internal static extern void ctor_1(global::System.IntPtr instance, global::System.IntPtr broadcaster_name);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb15SBCommunicationD2Ev")]
            internal static extern void dtor_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZNK4lldb15SBCommunication7IsValidEv")]
            [return: MarshalAsAttribute(UnmanagedType.I1)]
            internal static extern bool IsValid_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb15SBCommunication14GetBroadcasterEv")]
            internal static extern void GetBroadcaster_0(global::System.IntPtr @return, global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb15SBCommunication18AdoptFileDesriptorEib")]
            internal static extern LLDB.ConnectionStatus AdoptFileDesriptor_0(global::System.IntPtr instance, int fd, bool owns_fd);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb15SBCommunication7ConnectEPKc")]
            internal static extern LLDB.ConnectionStatus Connect_0(global::System.IntPtr instance, global::System.IntPtr url);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb15SBCommunication10DisconnectEv")]
            internal static extern LLDB.ConnectionStatus Disconnect_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZNK4lldb15SBCommunication11IsConnectedEv")]
            [return: MarshalAsAttribute(UnmanagedType.I1)]
            internal static extern bool IsConnected_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb15SBCommunication4ReadEPvmjRNS_16ConnectionStatusE")]
            internal static extern uint Read_0(global::System.IntPtr instance, global::System.IntPtr dst, uint dst_len, uint timeout_usec, LLDB.ConnectionStatus* status);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb15SBCommunication5WriteEPKvmRNS_16ConnectionStatusE")]
            internal static extern uint Write_0(global::System.IntPtr instance, global::System.IntPtr src, uint src_len, LLDB.ConnectionStatus* status);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb15SBCommunication15ReadThreadStartEv")]
            [return: MarshalAsAttribute(UnmanagedType.I1)]
            internal static extern bool ReadThreadStart_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb15SBCommunication14ReadThreadStopEv")]
            [return: MarshalAsAttribute(UnmanagedType.I1)]
            internal static extern bool ReadThreadStop_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb15SBCommunication19ReadThreadIsRunningEv")]
            [return: MarshalAsAttribute(UnmanagedType.I1)]
            internal static extern bool ReadThreadIsRunning_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb15SBCommunication34SetReadThreadBytesReceivedCallbackEPFvPvPKvmES1_")]
            [return: MarshalAsAttribute(UnmanagedType.I1)]
            internal static extern bool SetReadThreadBytesReceivedCallback_0(global::System.IntPtr instance, global::System.IntPtr callback, global::System.IntPtr callback_baton);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb15SBCommunication19GetBroadcasterClassEv")]
            internal static extern global::System.IntPtr GetBroadcasterClass_0();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb15SBCommunication13GetCloseOnEOFEv")]
            [return: MarshalAsAttribute(UnmanagedType.I1)]
            internal static extern bool GetCloseOnEOF_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb15SBCommunication13SetCloseOnEOFEb")]
            internal static extern void SetCloseOnEOF_0(global::System.IntPtr instance, bool b);
        }

        public enum _0 : uint
        {
            /// <summary>Sent when the communications connection is lost.</summary>
            BroadcastBitDisconnected = 1,
            /// <summary>Sent by the read thread when bytes become available.</summary>
            BroadcastBitReadThreadGotBytes = 2,
            /// <summary>Sent by the read thread when it exits to inform clients.</summary>
            BroadcastBitReadThreadDidExit = 4,
            /// <summary>Sent by clients that need to cancel the read thread.</summary>
            BroadcastBitReadThreadShouldExit = 8,
            /// <summary>Sent when data received makes a complete packet.</summary>
            BroadcastBitPacketAvailable = 16,
            AllEventBits = 0xffffffff
        }

        [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointerAttribute(global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public unsafe delegate void ReadThreadBytesReceived(global::System.IntPtr baton, global::System.IntPtr src, uint src_len);

        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        public static readonly System.Collections.Concurrent.ConcurrentDictionary<IntPtr, Communication> NativeToManagedMap = new System.Collections.Concurrent.ConcurrentDictionary<IntPtr, Communication>();
        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        public static Communication __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new Communication(native.ToPointer(), skipVTables);
        }

        public static Communication __CreateInstance(Communication.Internal native, bool skipVTables = false)
        {
            return new Communication(native, skipVTables);
        }

        private static void* __CopyValue(Communication.Internal native)
        {
            var ret = Marshal.AllocHGlobal(8);
            *(Communication.Internal*) ret = native;
            return ret.ToPointer();
        }

        private Communication(Communication.Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected Communication(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public Communication()
        {
            __Instance = Marshal.AllocHGlobal(8);
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            Internal.ctor_0((__Instance + __PointerAdjustment));
        }

        public Communication(string broadcaster_name)
        {
            __Instance = Marshal.AllocHGlobal(8);
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            var arg0 = Marshal.StringToHGlobalAnsi(broadcaster_name);
            Internal.ctor_1((__Instance + __PointerAdjustment), arg0);
            Marshal.FreeHGlobal(arg0);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        protected virtual void Dispose(bool disposing)
        {
            LLDB.Communication __dummy;
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

        public LLDB.Broadcaster GetBroadcaster()
        {
            var __ret = new LLDB.Broadcaster.Internal();
            Internal.GetBroadcaster_0(new IntPtr(&__ret), (__Instance + __PointerAdjustment));
            return LLDB.Broadcaster.__CreateInstance(__ret);
        }

        public LLDB.ConnectionStatus AdoptFileDesriptor(int fd, bool owns_fd)
        {
            var __ret = Internal.AdoptFileDesriptor_0((__Instance + __PointerAdjustment), fd, owns_fd);
            return __ret;
        }

        public LLDB.ConnectionStatus Connect(string url)
        {
            var arg0 = Marshal.StringToHGlobalAnsi(url);
            var __ret = Internal.Connect_0((__Instance + __PointerAdjustment), arg0);
            Marshal.FreeHGlobal(arg0);
            return __ret;
        }

        public LLDB.ConnectionStatus Disconnect()
        {
            var __ret = Internal.Disconnect_0((__Instance + __PointerAdjustment));
            return __ret;
        }

        public bool IsConnected()
        {
            var __ret = Internal.IsConnected_0((__Instance + __PointerAdjustment));
            return __ret;
        }

        public uint Read(global::System.IntPtr dst, uint dst_len, uint timeout_usec, LLDB.ConnectionStatus* status)
        {
            var arg0 = dst;
            var arg3 = status;
            var __ret = Internal.Read_0((__Instance + __PointerAdjustment), arg0, dst_len, timeout_usec, arg3);
            return __ret;
        }

        public uint Write(global::System.IntPtr src, uint src_len, LLDB.ConnectionStatus* status)
        {
            var arg0 = src;
            var arg2 = status;
            var __ret = Internal.Write_0((__Instance + __PointerAdjustment), arg0, src_len, arg2);
            return __ret;
        }

        public bool ReadThreadStart()
        {
            var __ret = Internal.ReadThreadStart_0((__Instance + __PointerAdjustment));
            return __ret;
        }

        public bool ReadThreadStop()
        {
            var __ret = Internal.ReadThreadStop_0((__Instance + __PointerAdjustment));
            return __ret;
        }

        public bool ReadThreadIsRunning()
        {
            var __ret = Internal.ReadThreadIsRunning_0((__Instance + __PointerAdjustment));
            return __ret;
        }

        public bool SetReadThreadBytesReceivedCallback(LLDB.Communication.ReadThreadBytesReceived callback, global::System.IntPtr callback_baton)
        {
            var arg0 = callback == null ? global::System.IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(callback);
            var arg1 = callback_baton;
            var __ret = Internal.SetReadThreadBytesReceivedCallback_0((__Instance + __PointerAdjustment), arg0, arg1);
            return __ret;
        }

        public static string BroadcasterClass
        {
            get
            {
                var __ret = Internal.GetBroadcasterClass_0();
                return Marshal.PtrToStringAnsi(__ret);
            }
        }

        public bool CloseOnEOF
        {
            get
            {
                var __ret = Internal.GetCloseOnEOF_0((__Instance + __PointerAdjustment));
                return __ret;
            }

            set
            {
                Internal.SetCloseOnEOF_0((__Instance + __PointerAdjustment), value);
            }
        }
    }
}
