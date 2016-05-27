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
    public unsafe partial class AttachInfo : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 8)]
        public partial struct Internal
        {
            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="??0SBAttachInfo@lldb@@QAE@XZ")]
            internal static extern global::System.IntPtr ctor_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="??0SBAttachInfo@lldb@@QAE@_K@Z")]
            internal static extern global::System.IntPtr ctor_1(global::System.IntPtr instance, ulong pid);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="??0SBAttachInfo@lldb@@QAE@PBD_N@Z")]
            internal static extern global::System.IntPtr ctor_2(global::System.IntPtr instance, global::System.IntPtr path, bool wait_for);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="??0SBAttachInfo@lldb@@QAE@PBD_N1@Z")]
            internal static extern global::System.IntPtr ctor_3(global::System.IntPtr instance, global::System.IntPtr path, bool wait_for, bool async);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="??0SBAttachInfo@lldb@@QAE@ABV01@@Z")]
            internal static extern global::System.IntPtr cctor_4(global::System.IntPtr instance, global::System.IntPtr rhs);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="??1SBAttachInfo@lldb@@QAE@XZ")]
            internal static extern void dtor_0(global::System.IntPtr instance, int delete);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?SetExecutable@SBAttachInfo@lldb@@QAEXPBD@Z")]
            internal static extern void SetExecutable_0(global::System.IntPtr instance, global::System.IntPtr path);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?SetExecutable@SBAttachInfo@lldb@@QAEXVSBFileSpec@2@@Z")]
            internal static extern void SetExecutable_1(global::System.IntPtr instance, LLDB.FileSpec.Internal exe_file);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?SetWaitForLaunch@SBAttachInfo@lldb@@QAEX_N0@Z")]
            internal static extern void SetWaitForLaunch_1(global::System.IntPtr instance, bool b, bool async);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?UserIDIsValid@SBAttachInfo@lldb@@QAE_NXZ")]
            [return: MarshalAsAttribute(UnmanagedType.I1)]
            internal static extern bool UserIDIsValid_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?GroupIDIsValid@SBAttachInfo@lldb@@QAE_NXZ")]
            [return: MarshalAsAttribute(UnmanagedType.I1)]
            internal static extern bool GroupIDIsValid_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?EffectiveUserIDIsValid@SBAttachInfo@lldb@@QAE_NXZ")]
            [return: MarshalAsAttribute(UnmanagedType.I1)]
            internal static extern bool EffectiveUserIDIsValid_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?EffectiveGroupIDIsValid@SBAttachInfo@lldb@@QAE_NXZ")]
            [return: MarshalAsAttribute(UnmanagedType.I1)]
            internal static extern bool EffectiveGroupIDIsValid_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?ParentProcessIDIsValid@SBAttachInfo@lldb@@QAE_NXZ")]
            [return: MarshalAsAttribute(UnmanagedType.I1)]
            internal static extern bool ParentProcessIDIsValid_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?GetListener@SBAttachInfo@lldb@@QAE?AVSBListener@2@XZ")]
            internal static extern void GetListener_0(global::System.IntPtr instance, global::System.IntPtr @return);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?GetProcessID@SBAttachInfo@lldb@@QAE_KXZ")]
            internal static extern ulong GetProcessID_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?SetProcessID@SBAttachInfo@lldb@@QAEX_K@Z")]
            internal static extern void SetProcessID_0(global::System.IntPtr instance, ulong pid);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?GetWaitForLaunch@SBAttachInfo@lldb@@QAE_NXZ")]
            [return: MarshalAsAttribute(UnmanagedType.I1)]
            internal static extern bool GetWaitForLaunch_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?SetWaitForLaunch@SBAttachInfo@lldb@@QAEX_N@Z")]
            internal static extern void SetWaitForLaunch_0(global::System.IntPtr instance, bool b);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?GetIgnoreExisting@SBAttachInfo@lldb@@QAE_NXZ")]
            [return: MarshalAsAttribute(UnmanagedType.I1)]
            internal static extern bool GetIgnoreExisting_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?SetIgnoreExisting@SBAttachInfo@lldb@@QAEX_N@Z")]
            internal static extern void SetIgnoreExisting_0(global::System.IntPtr instance, bool b);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?GetResumeCount@SBAttachInfo@lldb@@QAEIXZ")]
            internal static extern uint GetResumeCount_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?SetResumeCount@SBAttachInfo@lldb@@QAEXI@Z")]
            internal static extern void SetResumeCount_0(global::System.IntPtr instance, uint c);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?GetProcessPluginName@SBAttachInfo@lldb@@QAEPBDXZ")]
            internal static extern global::System.IntPtr GetProcessPluginName_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?SetProcessPluginName@SBAttachInfo@lldb@@QAEXPBD@Z")]
            internal static extern void SetProcessPluginName_0(global::System.IntPtr instance, global::System.IntPtr plugin_name);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?GetUserID@SBAttachInfo@lldb@@QAEIXZ")]
            internal static extern uint GetUserID_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?SetUserID@SBAttachInfo@lldb@@QAEXI@Z")]
            internal static extern void SetUserID_0(global::System.IntPtr instance, uint uid);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?GetGroupID@SBAttachInfo@lldb@@QAEIXZ")]
            internal static extern uint GetGroupID_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?SetGroupID@SBAttachInfo@lldb@@QAEXI@Z")]
            internal static extern void SetGroupID_0(global::System.IntPtr instance, uint gid);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?GetEffectiveUserID@SBAttachInfo@lldb@@QAEIXZ")]
            internal static extern uint GetEffectiveUserID_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?SetEffectiveUserID@SBAttachInfo@lldb@@QAEXI@Z")]
            internal static extern void SetEffectiveUserID_0(global::System.IntPtr instance, uint uid);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?GetEffectiveGroupID@SBAttachInfo@lldb@@QAEIXZ")]
            internal static extern uint GetEffectiveGroupID_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?SetEffectiveGroupID@SBAttachInfo@lldb@@QAEXI@Z")]
            internal static extern void SetEffectiveGroupID_0(global::System.IntPtr instance, uint gid);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?GetParentProcessID@SBAttachInfo@lldb@@QAE_KXZ")]
            internal static extern ulong GetParentProcessID_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?SetParentProcessID@SBAttachInfo@lldb@@QAEX_K@Z")]
            internal static extern void SetParentProcessID_0(global::System.IntPtr instance, ulong pid);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?SetListener@SBAttachInfo@lldb@@QAEXAAVSBListener@2@@Z")]
            internal static extern void SetListener_0(global::System.IntPtr instance, global::System.IntPtr listener);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        public static readonly System.Collections.Concurrent.ConcurrentDictionary<IntPtr, AttachInfo> NativeToManagedMap = new System.Collections.Concurrent.ConcurrentDictionary<IntPtr, AttachInfo>();
        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        public static AttachInfo __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new AttachInfo(native.ToPointer(), skipVTables);
        }

        public static AttachInfo __CreateInstance(AttachInfo.Internal native, bool skipVTables = false)
        {
            return new AttachInfo(native, skipVTables);
        }

        private static void* __CopyValue(AttachInfo.Internal native)
        {
            var ret = Marshal.AllocHGlobal(8);
            LLDB.AttachInfo.Internal.cctor_4(ret, new global::System.IntPtr(&native));
            return ret.ToPointer();
        }

        private AttachInfo(AttachInfo.Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected AttachInfo(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public AttachInfo()
        {
            __Instance = Marshal.AllocHGlobal(8);
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            Internal.ctor_0((__Instance + __PointerAdjustment));
        }

        public AttachInfo(ulong pid)
        {
            __Instance = Marshal.AllocHGlobal(8);
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            Internal.ctor_1((__Instance + __PointerAdjustment), pid);
        }

        /// <summary>
        /// <para>Attach to a process by name.</para>
        /// </summary>
        /// <remarks>
        /// <para>This function implies that a future call to SBTarget::Attach(...)</para>
        /// <para>will be synchronous.</para>
        /// </remarks>
        /// <param name="path">
        /// <para>A full or partial name for the process to attach to.</para>
        /// </param>
        /// <param name="wait_for">
        /// <para>If</para>
        /// <para>attach to an existing process whose name matches.</para>
        /// <para>If</para>
        /// <para>then wait for the next process whose name matches.</para>
        /// </param>
        public AttachInfo(string path, bool wait_for)
        {
            __Instance = Marshal.AllocHGlobal(8);
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            var arg0 = Marshal.StringToHGlobalAnsi(path);
            Internal.ctor_2((__Instance + __PointerAdjustment), arg0, wait_for);
            Marshal.FreeHGlobal(arg0);
        }

        /// <summary>
        /// <para>Attach to a process by name.</para>
        /// </summary>
        /// <remarks>
        /// <para>Future calls to SBTarget::Attach(...) will be synchronous or</para>
        /// <para>asynchronous depending on the </para>
        /// <para>argument.</para>
        /// </remarks>
        /// <param name="path">
        /// <para>A full or partial name for the process to attach to.</para>
        /// </param>
        /// <param name="wait_for">
        /// <para>If</para>
        /// <para>attach to an existing process whose name matches.</para>
        /// <para>If</para>
        /// <para>then wait for the next process whose name matches.</para>
        /// </param>
        /// <param name="async">
        /// <para>If</para>
        /// <para>then the SBTarget::Attach(...) call will be a</para>
        /// <para>synchronous call with no way to cancel the attach in</para>
        /// <para>progress.</para>
        /// <para>If</para>
        /// <para>then the SBTarget::Attach(...) function will</para>
        /// <para>return immediately and clients are expected to wait for a</para>
        /// <para>process eStateStopped event if a suitable process is</para>
        /// <para>eventually found. If the client wants to cancel the event,</para>
        /// <para>SBProcess::Stop() can be called and an eStateExited process</para>
        /// <para>event will be delivered.</para>
        /// </param>
        public AttachInfo(string path, bool wait_for, bool async)
        {
            __Instance = Marshal.AllocHGlobal(8);
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            var arg0 = Marshal.StringToHGlobalAnsi(path);
            Internal.ctor_3((__Instance + __PointerAdjustment), arg0, wait_for, async);
            Marshal.FreeHGlobal(arg0);
        }

        public AttachInfo(LLDB.AttachInfo rhs)
        {
            __Instance = Marshal.AllocHGlobal(8);
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            if (ReferenceEquals(rhs, null))
                throw new global::System.ArgumentNullException("rhs", "Cannot be null because it is a C++ reference (&).");
            var arg0 = rhs.__Instance;
            Internal.cctor_4((__Instance + __PointerAdjustment), arg0);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        protected virtual void Dispose(bool disposing)
        {
            LLDB.AttachInfo __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            Internal.dtor_0((__Instance + __PointerAdjustment), 0);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
        }

        public void SetExecutable(string path)
        {
            var arg0 = Marshal.StringToHGlobalAnsi(path);
            Internal.SetExecutable_0((__Instance + __PointerAdjustment), arg0);
            Marshal.FreeHGlobal(arg0);
        }

        public void SetExecutable(LLDB.FileSpec exe_file)
        {
            var arg0 = ReferenceEquals(exe_file, null) ? new LLDB.FileSpec.Internal() : *(LLDB.FileSpec.Internal*) (exe_file.__Instance);
            Internal.SetExecutable_1((__Instance + __PointerAdjustment), arg0);
        }

        /// <summary>
        /// <para>Set attach by process name settings.</para>
        /// </summary>
        /// <remarks>
        /// <para>Designed to be used after a call to SBAttachInfo::SetExecutable().</para>
        /// <para>Future calls to SBTarget::Attach(...) will be synchronous or</para>
        /// <para>asynchronous depending on the </para>
        /// <para>argument.</para>
        /// </remarks>
        /// <param name="wait_for">
        /// <para>If</para>
        /// <para>attach to an existing process whose name matches.</para>
        /// <para>If</para>
        /// <para>then wait for the next process whose name matches.</para>
        /// </param>
        /// <param name="async">
        /// <para>If</para>
        /// <para>then the SBTarget::Attach(...) call will be a</para>
        /// <para>synchronous call with no way to cancel the attach in</para>
        /// <para>progress.</para>
        /// <para>If</para>
        /// <para>then the SBTarget::Attach(...) function will</para>
        /// <para>return immediately and clients are expected to wait for a</para>
        /// <para>process eStateStopped event if a suitable process is</para>
        /// <para>eventually found. If the client wants to cancel the event,</para>
        /// <para>SBProcess::Stop() can be called and an eStateExited process</para>
        /// <para>event will be delivered.</para>
        /// </param>
        public void SetWaitForLaunch(bool b, bool async)
        {
            Internal.SetWaitForLaunch_1((__Instance + __PointerAdjustment), b, async);
        }

        public bool UserIDIsValid()
        {
            var __ret = Internal.UserIDIsValid_0((__Instance + __PointerAdjustment));
            return __ret;
        }

        public bool GroupIDIsValid()
        {
            var __ret = Internal.GroupIDIsValid_0((__Instance + __PointerAdjustment));
            return __ret;
        }

        public bool EffectiveUserIDIsValid()
        {
            var __ret = Internal.EffectiveUserIDIsValid_0((__Instance + __PointerAdjustment));
            return __ret;
        }

        public bool EffectiveGroupIDIsValid()
        {
            var __ret = Internal.EffectiveGroupIDIsValid_0((__Instance + __PointerAdjustment));
            return __ret;
        }

        public bool ParentProcessIDIsValid()
        {
            var __ret = Internal.ParentProcessIDIsValid_0((__Instance + __PointerAdjustment));
            return __ret;
        }

        /// <summary>
        /// <para>Get the listener that will be used to receive process events.</para>
        /// </summary>
        /// <remarks>
        /// <para>If no listener has been set via a call to</para>
        /// <para>SBLaunchInfo::SetListener(), then an invalid SBListener will be</para>
        /// <para>returned (SBListener::IsValid() will return false). If a listener</para>
        /// <para>has been set, then the valid listener object will be returned.</para>
        /// </remarks>
        public LLDB.Listener GetListener()
        {
            var __ret = new LLDB.Listener.Internal();
            Internal.GetListener_0((__Instance + __PointerAdjustment), new IntPtr(&__ret));
            return LLDB.Listener.__CreateInstance(__ret);
        }

        public ulong ProcessID
        {
            get
            {
                var __ret = Internal.GetProcessID_0((__Instance + __PointerAdjustment));
                return __ret;
            }

            set
            {
                Internal.SetProcessID_0((__Instance + __PointerAdjustment), value);
            }
        }

        public bool WaitForLaunch
        {
            get
            {
                var __ret = Internal.GetWaitForLaunch_0((__Instance + __PointerAdjustment));
                return __ret;
            }

            set
            {
                Internal.SetWaitForLaunch_0((__Instance + __PointerAdjustment), value);
            }
        }

        public bool IgnoreExisting
        {
            get
            {
                var __ret = Internal.GetIgnoreExisting_0((__Instance + __PointerAdjustment));
                return __ret;
            }

            set
            {
                Internal.SetIgnoreExisting_0((__Instance + __PointerAdjustment), value);
            }
        }

        public uint ResumeCount
        {
            get
            {
                var __ret = Internal.GetResumeCount_0((__Instance + __PointerAdjustment));
                return __ret;
            }

            set
            {
                Internal.SetResumeCount_0((__Instance + __PointerAdjustment), value);
            }
        }

        public string ProcessPluginName
        {
            get
            {
                var __ret = Internal.GetProcessPluginName_0((__Instance + __PointerAdjustment));
                return Marshal.PtrToStringAnsi(__ret);
            }

            set
            {
                var arg0 = Marshal.StringToHGlobalAnsi(value);
                Internal.SetProcessPluginName_0((__Instance + __PointerAdjustment), arg0);
                Marshal.FreeHGlobal(arg0);
            }
        }

        public uint UserID
        {
            get
            {
                var __ret = Internal.GetUserID_0((__Instance + __PointerAdjustment));
                return __ret;
            }

            set
            {
                Internal.SetUserID_0((__Instance + __PointerAdjustment), value);
            }
        }

        public uint GroupID
        {
            get
            {
                var __ret = Internal.GetGroupID_0((__Instance + __PointerAdjustment));
                return __ret;
            }

            set
            {
                Internal.SetGroupID_0((__Instance + __PointerAdjustment), value);
            }
        }

        public uint EffectiveUserID
        {
            get
            {
                var __ret = Internal.GetEffectiveUserID_0((__Instance + __PointerAdjustment));
                return __ret;
            }

            set
            {
                Internal.SetEffectiveUserID_0((__Instance + __PointerAdjustment), value);
            }
        }

        public uint EffectiveGroupID
        {
            get
            {
                var __ret = Internal.GetEffectiveGroupID_0((__Instance + __PointerAdjustment));
                return __ret;
            }

            set
            {
                Internal.SetEffectiveGroupID_0((__Instance + __PointerAdjustment), value);
            }
        }

        public ulong ParentProcessID
        {
            get
            {
                var __ret = Internal.GetParentProcessID_0((__Instance + __PointerAdjustment));
                return __ret;
            }

            set
            {
                Internal.SetParentProcessID_0((__Instance + __PointerAdjustment), value);
            }
        }

        public LLDB.Listener Listener
        {
            set
            {
                if (ReferenceEquals(value, null))
                    throw new global::System.ArgumentNullException("value", "Cannot be null because it is a C++ reference (&).");
                var arg0 = value.__Instance;
                Internal.SetListener_0((__Instance + __PointerAdjustment), arg0);
            }
        }
    }
}
