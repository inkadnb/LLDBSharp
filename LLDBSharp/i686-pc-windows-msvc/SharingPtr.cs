//----------------------------------------------------------------------------
// This is autogenerated code by CppSharp.
// Do not edit this file or all your changes will be lost after re-generation.
//----------------------------------------------------------------------------
using System;
using System.Runtime.InteropServices;
using System.Security;

namespace lldb_private
{
    public unsafe partial class SharingPtr
    {
        [StructLayout(LayoutKind.Explicit, Size = 0)]
        public partial struct Internal
        {
            [FieldOffset(0)]
            public global::System.IntPtr ptr_;

            [FieldOffset(0)]
            public global::System.IntPtr cntrl_;
        }

        internal unsafe partial class nat
        {
            [StructLayout(LayoutKind.Explicit, Size = 0)]
            public partial struct Internal
            {
                [FieldOffset(0)]
                public int for_bool_;
            }
        }
    }

    public unsafe partial class LoggingSharingPtr
    {
        [StructLayout(LayoutKind.Explicit, Size = 0)]
        public partial struct Internal
        {
            [FieldOffset(0)]
            public global::System.IntPtr baton_;
        }
    }

    public unsafe partial class ReferenceCountedBase
    {
        [StructLayout(LayoutKind.Explicit, Size = 0)]
        public partial struct Internal
        {
            [FieldOffset(0)]
            public int shared_owners_;
        }
    }

    public unsafe partial class ReferenceCountedBaseVirtual
    {
        [StructLayout(LayoutKind.Explicit, Size = 0)]
        public new partial struct Internal
        {
            [FieldOffset(4)]
            public int shared_owners_;
        }
    }

    namespace imp
    {
        public unsafe abstract partial class shared_count : IDisposable
        {
            [StructLayout(LayoutKind.Explicit, Size = 8)]
            public partial struct Internal
            {
                [FieldOffset(4)]
                public int shared_owners_;

                [FieldOffset(0)]
                public global::System.IntPtr vfptr0;

                [SuppressUnmanagedCodeSecurity]
                [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                    EntryPoint="??0shared_count@imp@lldb_private@@QAE@J@Z")]
                internal static extern global::System.IntPtr ctor_1(global::System.IntPtr instance, int refs);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                    EntryPoint="??1shared_count@imp@lldb_private@@MAE@XZ")]
                internal static extern void dtor_0(global::System.IntPtr instance, int delete);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                    EntryPoint="?add_shared@shared_count@imp@lldb_private@@QAEXXZ")]
                internal static extern void add_shared_0(global::System.IntPtr instance);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                    EntryPoint="?release_shared@shared_count@imp@lldb_private@@QAEXXZ")]
                internal static extern void release_shared_0(global::System.IntPtr instance);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                    EntryPoint="?use_count@shared_count@imp@lldb_private@@QBEJXZ")]
                internal static extern int use_count_0(global::System.IntPtr instance);
            }

            public global::System.IntPtr __Instance { get; protected set; }
            public static readonly System.Collections.Concurrent.ConcurrentDictionary<IntPtr, shared_count> NativeToManagedMap = new System.Collections.Concurrent.ConcurrentDictionary<IntPtr, shared_count>();

            private readonly bool __ownsNativeInstance;

            public static shared_count __CreateInstance(global::System.IntPtr native)
            {
                return new shared_countInternal((shared_count.Internal*) native);
            }

            public static shared_count __CreateInstance(shared_count.Internal native)
            {
                return new shared_countInternal(native);
            }

            protected shared_count(shared_count.Internal* native, bool isInternalImpl = false)
            {
                __Instance = new global::System.IntPtr(native);
                if (__Instance != global::System.IntPtr.Zero && !isInternalImpl)
                    SetupVTables(__Instance);
            }

            protected shared_count(int refs)
            {
                __Instance = Marshal.AllocHGlobal(8);
                __ownsNativeInstance = true;
                NativeToManagedMap[__Instance] = this;
                Internal.ctor_1(__Instance, refs);
                SetupVTables(__Instance);
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
                lldb_private.imp.shared_count __dummy;
                NativeToManagedMap.TryRemove(__Instance, out __dummy);
                if (__ownsNativeInstance || force)
                    Internal.dtor_0(__Instance, 0);
                if (__ownsNativeInstance)
                    Marshal.FreeHGlobal(__Instance);
            }

            public void add_shared()
            {
                Internal.add_shared_0(__Instance);
            }

            public void release_shared()
            {
                Internal.release_shared_0(__Instance);
            }

            public int use_count()
            {
                var __ret = Internal.use_count_0(__Instance);
                return __ret;
            }

            protected int shared_owners_
            {
                get
                {
                    return ((Internal*) __Instance)->shared_owners_;
                }

                set
                {
                    ((Internal*) __Instance)->shared_owners_ = value;
                }
            }

            #region Virtual table interop

            // virtual ~shared_count()
            [SuppressUnmanagedCodeSecurity]
            [UnmanagedFunctionPointerAttribute(global::System.Runtime.InteropServices.CallingConvention.ThisCall)]
            internal delegate void _dtor_0Delegate(global::System.IntPtr instance, int delete);
            private static _dtor_0Delegate _dtor_0DelegateInstance;

            private static void _dtor_0DelegateHook(global::System.IntPtr instance, int delete)
            {
                if (!_References.ContainsKey(instance))
                    throw new global::System.Exception("No managed instance was found");

                var target = (shared_count) _References[instance].Target;
                target.DestroyNativeInstance();
            }

            private static void*[] _OldVTables;
            private static void*[] _NewVTables;
            private static void*[] _Thunks;
            private static System.Collections.Generic.Dictionary<IntPtr, WeakReference> _References;

            void SetupVTables(global::System.IntPtr instance)
            {
                var native = (Internal*)instance.ToPointer();

                if (_References == null)
                    _References = new System.Collections.Generic.Dictionary<IntPtr, WeakReference>();

                if (_References.ContainsKey(instance))
                    return;

                _References[instance] = new WeakReference(this);

                if (_OldVTables == null)
                {
                    _OldVTables = new void*[1];
                    _OldVTables[0] = native->vfptr0.ToPointer();
                }

                if (_Thunks == null)
                {
                    _Thunks = new void*[1];
                    _dtor_0DelegateInstance += _dtor_0DelegateHook;
                    _Thunks[0] = Marshal.GetFunctionPointerForDelegate(_dtor_0DelegateInstance).ToPointer();
                }

                if (_NewVTables == null)
                {
                    _NewVTables = new void*[1];
                    var vfptr0 = Marshal.AllocHGlobal(2 * 4);
                    _NewVTables[0] = vfptr0.ToPointer();
                    *(void**)(vfptr0 + 0) = _Thunks[0];
                    *(void**)(vfptr0 + 4) = *(void**)(native->vfptr0 + 4);
                }

                native->vfptr0 = new IntPtr(_NewVTables[0]);
            }

            #endregion
        }

        public unsafe partial class shared_ptr_pointer
        {
            [StructLayout(LayoutKind.Explicit, Size = 0)]
            public new partial struct Internal
            {
                [FieldOffset(4)]
                public int shared_owners_;
            }
        }

        public unsafe partial class shared_ptr_emplace
        {
            [StructLayout(LayoutKind.Explicit, Size = 0)]
            public new partial struct Internal
            {
                [FieldOffset(4)]
                public int shared_owners_;
            }
        }

        internal unsafe partial class shared_countInternal : lldb_private.imp.shared_count, IDisposable
        {
            private readonly bool __ownsNativeInstance;

            private static shared_count.Internal* __CopyValue(shared_count.Internal native)
            {
                var ret = (shared_count.Internal*) Marshal.AllocHGlobal(8);
                *ret = native;
                return ret;
            }

            internal shared_countInternal(shared_count.Internal native)
                : this(__CopyValue(native))
            {
                __ownsNativeInstance = true;
                NativeToManagedMap[__Instance] = this;
            }

            internal shared_countInternal(shared_count.Internal* native, bool isInternalImpl = false)
                : base((lldb_private.imp.shared_count.Internal*) native, true)
            {
            }

            protected override void Dispose(bool disposing)
            {
                DestroyNativeInstance(false);
                base.Dispose(disposing);
            }

            public override void DestroyNativeInstance()
            {
                DestroyNativeInstance(true);
            }

            private void DestroyNativeInstance(bool force)
            {
                lldb_private.imp.shared_count __dummy;
                NativeToManagedMap.TryRemove(__Instance, out __dummy);
                if (__ownsNativeInstance)
                    Marshal.FreeHGlobal(__Instance);
            }
        }
    }
}
