//----------------------------------------------------------------------------
// This is autogenerated code by CppSharp.
// Do not edit this file or all your changes will be lost after re-generation.
//----------------------------------------------------------------------------
using System;
using System.Runtime.InteropServices;
using System.Security;

namespace LLDB
{
    public unsafe partial class QueueItem : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 8)]
        public partial struct Internal
        {
            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb11SBQueueItemC2Ev")]
            internal static extern void ctor_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb11SBQueueItemC2ERKS0_")]
            internal static extern void cctor_2(global::System.IntPtr instance, global::System.IntPtr _0);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb11SBQueueItemD2Ev")]
            internal static extern void dtor_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZNK4lldb11SBQueueItem7IsValidEv")]
            [return: MarshalAsAttribute(UnmanagedType.I1)]
            internal static extern bool IsValid_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb11SBQueueItem5ClearEv")]
            internal static extern void Clear_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZNK4lldb11SBQueueItem10GetAddressEv")]
            internal static extern void GetAddress_0(global::System.IntPtr @return, global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb11SBQueueItem26GetExtendedBacktraceThreadEPKc")]
            internal static extern void GetExtendedBacktraceThread_0(global::System.IntPtr @return, global::System.IntPtr instance, global::System.IntPtr type);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZNK4lldb11SBQueueItem7GetKindEv")]
            internal static extern LLDB.QueueItemKind GetKind_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb11SBQueueItem7SetKindENS_13QueueItemKindE")]
            internal static extern void SetKind_0(global::System.IntPtr instance, LLDB.QueueItemKind kind);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb11SBQueueItem10SetAddressENS_9SBAddressE")]
            internal static extern void SetAddress_0(global::System.IntPtr instance, LLDB.Address.Internal addr);
        }

        public global::System.IntPtr __Instance { get; protected set; }
        public static readonly System.Collections.Concurrent.ConcurrentDictionary<IntPtr, QueueItem> NativeToManagedMap = new System.Collections.Concurrent.ConcurrentDictionary<IntPtr, QueueItem>();

        private readonly bool __ownsNativeInstance;

        public static QueueItem __CreateInstance(global::System.IntPtr native)
        {
            return new QueueItem((QueueItem.Internal*) native);
        }

        public static QueueItem __CreateInstance(QueueItem.Internal native)
        {
            return new QueueItem(native);
        }

        private static QueueItem.Internal* __CopyValue(QueueItem.Internal native)
        {
            var ret = (QueueItem.Internal*) Marshal.AllocHGlobal(8);
            *ret = native;
            return ret;
        }

        private QueueItem(QueueItem.Internal native)
            : this(__CopyValue(native))
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected QueueItem(QueueItem.Internal* native, bool isInternalImpl = false)
        {
            __Instance = new global::System.IntPtr(native);
        }

        public QueueItem()
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
            LLDB.QueueItem __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance || force)
                Internal.dtor_0(__Instance);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
        }

        public bool IsValid()
        {
            var __ret = Internal.IsValid_0(__Instance);
            return __ret;
        }

        public void Clear()
        {
            Internal.Clear_0(__Instance);
        }

        public LLDB.Address GetAddress()
        {
            var __ret = new LLDB.Address.Internal();
            Internal.GetAddress_0(new IntPtr(&__ret), __Instance);
            return LLDB.Address.__CreateInstance(__ret);
        }

        public LLDB.Thread GetExtendedBacktraceThread(string type)
        {
            var arg0 = Marshal.StringToHGlobalAnsi(type);
            var __ret = new LLDB.Thread.Internal();
            Internal.GetExtendedBacktraceThread_0(new IntPtr(&__ret), __Instance, arg0);
            Marshal.FreeHGlobal(arg0);
            return LLDB.Thread.__CreateInstance(__ret);
        }

        public LLDB.QueueItemKind Kind
        {
            get
            {
                var __ret = Internal.GetKind_0(__Instance);
                return __ret;
            }

            set
            {
                var arg0 = value;
                Internal.SetKind_0(__Instance, arg0);
            }
        }

        public LLDB.Address Address
        {
            set
            {
                var arg0 = ReferenceEquals(value, null) ? new LLDB.Address.Internal() : *(LLDB.Address.Internal*) (value.__Instance);
                Internal.SetAddress_0(__Instance, arg0);
            }
        }
    }
}