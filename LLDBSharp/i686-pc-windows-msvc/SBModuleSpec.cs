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
    public unsafe partial class ModuleSpec : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 4)]
        public partial struct Internal
        {
            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="??0SBModuleSpec@lldb@@QAE@XZ")]
            internal static extern global::System.IntPtr ctor_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="??0SBModuleSpec@lldb@@QAE@ABV01@@Z")]
            internal static extern global::System.IntPtr cctor_1(global::System.IntPtr instance, global::System.IntPtr rhs);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="??1SBModuleSpec@lldb@@QAE@XZ")]
            internal static extern void dtor_0(global::System.IntPtr instance, int delete);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?IsValid@SBModuleSpec@lldb@@QBE_NXZ")]
            [return: MarshalAsAttribute(UnmanagedType.I1)]
            internal static extern bool IsValid_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?Clear@SBModuleSpec@lldb@@QAEXXZ")]
            internal static extern void Clear_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?GetFileSpec@SBModuleSpec@lldb@@QAE?AVSBFileSpec@2@XZ")]
            internal static extern void GetFileSpec_0(global::System.IntPtr instance, global::System.IntPtr @return);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?GetPlatformFileSpec@SBModuleSpec@lldb@@QAE?AVSBFileSpec@2@XZ")]
            internal static extern void GetPlatformFileSpec_0(global::System.IntPtr instance, global::System.IntPtr @return);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?GetSymbolFileSpec@SBModuleSpec@lldb@@QAE?AVSBFileSpec@2@XZ")]
            internal static extern void GetSymbolFileSpec_0(global::System.IntPtr instance, global::System.IntPtr @return);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?SetUUIDBytes@SBModuleSpec@lldb@@QAE_NPBEI@Z")]
            [return: MarshalAsAttribute(UnmanagedType.I1)]
            internal static extern bool SetUUIDBytes_0(global::System.IntPtr instance, byte* uuid, uint uuid_len);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?GetDescription@SBModuleSpec@lldb@@QAE_NAAVSBStream@2@@Z")]
            [return: MarshalAsAttribute(UnmanagedType.I1)]
            internal static extern bool GetDescription_0(global::System.IntPtr instance, global::System.IntPtr description);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?SetFileSpec@SBModuleSpec@lldb@@QAEXABVSBFileSpec@2@@Z")]
            internal static extern void SetFileSpec_0(global::System.IntPtr instance, global::System.IntPtr fspec);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?SetPlatformFileSpec@SBModuleSpec@lldb@@QAEXABVSBFileSpec@2@@Z")]
            internal static extern void SetPlatformFileSpec_0(global::System.IntPtr instance, global::System.IntPtr fspec);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?SetSymbolFileSpec@SBModuleSpec@lldb@@QAEXABVSBFileSpec@2@@Z")]
            internal static extern void SetSymbolFileSpec_0(global::System.IntPtr instance, global::System.IntPtr fspec);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?GetObjectName@SBModuleSpec@lldb@@QAEPBDXZ")]
            internal static extern global::System.IntPtr GetObjectName_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?SetObjectName@SBModuleSpec@lldb@@QAEXPBD@Z")]
            internal static extern void SetObjectName_0(global::System.IntPtr instance, global::System.IntPtr name);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?GetTriple@SBModuleSpec@lldb@@QAEPBDXZ")]
            internal static extern global::System.IntPtr GetTriple_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?SetTriple@SBModuleSpec@lldb@@QAEXPBD@Z")]
            internal static extern void SetTriple_0(global::System.IntPtr instance, global::System.IntPtr triple);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?GetUUIDBytes@SBModuleSpec@lldb@@QAEPBEXZ")]
            internal static extern byte* GetUUIDBytes_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?GetUUIDLength@SBModuleSpec@lldb@@QAEIXZ")]
            internal static extern uint GetUUIDLength_0(global::System.IntPtr instance);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        public static readonly System.Collections.Concurrent.ConcurrentDictionary<IntPtr, ModuleSpec> NativeToManagedMap = new System.Collections.Concurrent.ConcurrentDictionary<IntPtr, ModuleSpec>();
        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        public static ModuleSpec __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new ModuleSpec(native.ToPointer(), skipVTables);
        }

        public static ModuleSpec __CreateInstance(ModuleSpec.Internal native, bool skipVTables = false)
        {
            return new ModuleSpec(native, skipVTables);
        }

        private static void* __CopyValue(ModuleSpec.Internal native)
        {
            var ret = Marshal.AllocHGlobal(4);
            LLDB.ModuleSpec.Internal.cctor_1(ret, new global::System.IntPtr(&native));
            return ret.ToPointer();
        }

        private ModuleSpec(ModuleSpec.Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected ModuleSpec(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public ModuleSpec()
        {
            __Instance = Marshal.AllocHGlobal(4);
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            Internal.ctor_0((__Instance + __PointerAdjustment));
        }

        public ModuleSpec(LLDB.ModuleSpec rhs)
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
            LLDB.ModuleSpec __dummy;
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

        public void Clear()
        {
            Internal.Clear_0((__Instance + __PointerAdjustment));
        }

        /// <summary>
        /// <para>Get const accessor for the module file.</para>
        /// </summary>
        /// <remarks>
        /// <para>This function returns the file for the module on the host system</para>
        /// <para>that is running LLDB. This can differ from the path on the </para>
        /// <para>platform since we might be doing remote debugging.</para>
        /// </remarks>
        /// <returns>
        /// <para>A const reference to the file specification object.</para>
        /// </returns>
        public LLDB.FileSpec GetFileSpec()
        {
            var __ret = new LLDB.FileSpec.Internal();
            Internal.GetFileSpec_0((__Instance + __PointerAdjustment), new IntPtr(&__ret));
            return LLDB.FileSpec.__CreateInstance(__ret);
        }

        /// <summary>
        /// <para>Get accessor for the module platform file.</para>
        /// </summary>
        /// <remarks>
        /// <para>Platform file refers to the path of the module as it is known on</para>
        /// <para>the remote system on which it is being debugged. For local </para>
        /// <para>debugging this is always the same as Module::GetFileSpec(). But</para>
        /// <para>remote debugging might mention a file '/usr/lib/liba.dylib'</para>
        /// <para>which might be locally downloaded and cached. In this case the</para>
        /// <para>platform file could be something like:</para>
        /// <para>'/tmp/lldb/platform-cache/remote.host.computer/usr/lib/liba.dylib'</para>
        /// <para>The file could also be cached in a local developer kit directory.</para>
        /// </remarks>
        /// <returns>
        /// <para>A const reference to the file specification object.</para>
        /// </returns>
        public LLDB.FileSpec GetPlatformFileSpec()
        {
            var __ret = new LLDB.FileSpec.Internal();
            Internal.GetPlatformFileSpec_0((__Instance + __PointerAdjustment), new IntPtr(&__ret));
            return LLDB.FileSpec.__CreateInstance(__ret);
        }

        public LLDB.FileSpec GetSymbolFileSpec()
        {
            var __ret = new LLDB.FileSpec.Internal();
            Internal.GetSymbolFileSpec_0((__Instance + __PointerAdjustment), new IntPtr(&__ret));
            return LLDB.FileSpec.__CreateInstance(__ret);
        }

        public bool SetUUIDBytes(byte* uuid, uint uuid_len)
        {
            var arg0 = uuid;
            var __ret = Internal.SetUUIDBytes_0((__Instance + __PointerAdjustment), arg0, uuid_len);
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

        public LLDB.FileSpec FileSpec
        {
            set
            {
                if (ReferenceEquals(value, null))
                    throw new global::System.ArgumentNullException("value", "Cannot be null because it is a C++ reference (&).");
                var arg0 = value.__Instance;
                Internal.SetFileSpec_0((__Instance + __PointerAdjustment), arg0);
            }
        }

        public LLDB.FileSpec PlatformFileSpec
        {
            set
            {
                if (ReferenceEquals(value, null))
                    throw new global::System.ArgumentNullException("value", "Cannot be null because it is a C++ reference (&).");
                var arg0 = value.__Instance;
                Internal.SetPlatformFileSpec_0((__Instance + __PointerAdjustment), arg0);
            }
        }

        public LLDB.FileSpec SymbolFileSpec
        {
            set
            {
                if (ReferenceEquals(value, null))
                    throw new global::System.ArgumentNullException("value", "Cannot be null because it is a C++ reference (&).");
                var arg0 = value.__Instance;
                Internal.SetSymbolFileSpec_0((__Instance + __PointerAdjustment), arg0);
            }
        }

        public string ObjectName
        {
            get
            {
                var __ret = Internal.GetObjectName_0((__Instance + __PointerAdjustment));
                return Marshal.PtrToStringAnsi(__ret);
            }

            set
            {
                var arg0 = Marshal.StringToHGlobalAnsi(value);
                Internal.SetObjectName_0((__Instance + __PointerAdjustment), arg0);
                Marshal.FreeHGlobal(arg0);
            }
        }

        public string Triple
        {
            get
            {
                var __ret = Internal.GetTriple_0((__Instance + __PointerAdjustment));
                return Marshal.PtrToStringAnsi(__ret);
            }

            set
            {
                var arg0 = Marshal.StringToHGlobalAnsi(value);
                Internal.SetTriple_0((__Instance + __PointerAdjustment), arg0);
                Marshal.FreeHGlobal(arg0);
            }
        }

        public byte* UUIDBytes
        {
            get
            {
                var __ret = Internal.GetUUIDBytes_0((__Instance + __PointerAdjustment));
                return __ret;
            }
        }

        public uint UUIDLength
        {
            get
            {
                var __ret = Internal.GetUUIDLength_0((__Instance + __PointerAdjustment));
                return __ret;
            }
        }
    }

    public unsafe partial class ModuleSpecList : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 4)]
        public partial struct Internal
        {
            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="??0SBModuleSpecList@lldb@@QAE@XZ")]
            internal static extern global::System.IntPtr ctor_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="??0SBModuleSpecList@lldb@@QAE@ABV01@@Z")]
            internal static extern global::System.IntPtr cctor_1(global::System.IntPtr instance, global::System.IntPtr rhs);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="??1SBModuleSpecList@lldb@@QAE@XZ")]
            internal static extern void dtor_0(global::System.IntPtr instance, int delete);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="?GetModuleSpecifications@SBModuleSpecList@lldb@@SA?AV12@PBD@Z")]
            internal static extern void GetModuleSpecifications_0(global::System.IntPtr @return, global::System.IntPtr path);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?Append@SBModuleSpecList@lldb@@QAEXABVSBModuleSpec@2@@Z")]
            internal static extern void Append_0(global::System.IntPtr instance, global::System.IntPtr spec);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?Append@SBModuleSpecList@lldb@@QAEXABV12@@Z")]
            internal static extern void Append_1(global::System.IntPtr instance, global::System.IntPtr spec_list);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?FindFirstMatchingSpec@SBModuleSpecList@lldb@@QAE?AVSBModuleSpec@2@ABV32@@Z")]
            internal static extern void FindFirstMatchingSpec_0(global::System.IntPtr instance, global::System.IntPtr @return, global::System.IntPtr match_spec);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?FindMatchingSpecs@SBModuleSpecList@lldb@@QAE?AV12@ABVSBModuleSpec@2@@Z")]
            internal static extern void FindMatchingSpecs_0(global::System.IntPtr instance, global::System.IntPtr @return, global::System.IntPtr match_spec);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?GetSpecAtIndex@SBModuleSpecList@lldb@@QAE?AVSBModuleSpec@2@I@Z")]
            internal static extern void GetSpecAtIndex_0(global::System.IntPtr instance, global::System.IntPtr @return, uint i);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?GetDescription@SBModuleSpecList@lldb@@QAE_NAAVSBStream@2@@Z")]
            [return: MarshalAsAttribute(UnmanagedType.I1)]
            internal static extern bool GetDescription_0(global::System.IntPtr instance, global::System.IntPtr description);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?GetSize@SBModuleSpecList@lldb@@QAEIXZ")]
            internal static extern uint GetSize_0(global::System.IntPtr instance);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        public static readonly System.Collections.Concurrent.ConcurrentDictionary<IntPtr, ModuleSpecList> NativeToManagedMap = new System.Collections.Concurrent.ConcurrentDictionary<IntPtr, ModuleSpecList>();
        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        public static ModuleSpecList __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new ModuleSpecList(native.ToPointer(), skipVTables);
        }

        public static ModuleSpecList __CreateInstance(ModuleSpecList.Internal native, bool skipVTables = false)
        {
            return new ModuleSpecList(native, skipVTables);
        }

        private static void* __CopyValue(ModuleSpecList.Internal native)
        {
            var ret = Marshal.AllocHGlobal(4);
            LLDB.ModuleSpecList.Internal.cctor_1(ret, new global::System.IntPtr(&native));
            return ret.ToPointer();
        }

        private ModuleSpecList(ModuleSpecList.Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected ModuleSpecList(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public ModuleSpecList()
        {
            __Instance = Marshal.AllocHGlobal(4);
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            Internal.ctor_0((__Instance + __PointerAdjustment));
        }

        public ModuleSpecList(LLDB.ModuleSpecList rhs)
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
            LLDB.ModuleSpecList __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            Internal.dtor_0((__Instance + __PointerAdjustment), 0);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
        }

        public void Append(LLDB.ModuleSpec spec)
        {
            if (ReferenceEquals(spec, null))
                throw new global::System.ArgumentNullException("spec", "Cannot be null because it is a C++ reference (&).");
            var arg0 = spec.__Instance;
            Internal.Append_0((__Instance + __PointerAdjustment), arg0);
        }

        public void Append(LLDB.ModuleSpecList spec_list)
        {
            if (ReferenceEquals(spec_list, null))
                throw new global::System.ArgumentNullException("spec_list", "Cannot be null because it is a C++ reference (&).");
            var arg0 = spec_list.__Instance;
            Internal.Append_1((__Instance + __PointerAdjustment), arg0);
        }

        public LLDB.ModuleSpec FindFirstMatchingSpec(LLDB.ModuleSpec match_spec)
        {
            if (ReferenceEquals(match_spec, null))
                throw new global::System.ArgumentNullException("match_spec", "Cannot be null because it is a C++ reference (&).");
            var arg0 = match_spec.__Instance;
            var __ret = new LLDB.ModuleSpec.Internal();
            Internal.FindFirstMatchingSpec_0((__Instance + __PointerAdjustment), new IntPtr(&__ret), arg0);
            return LLDB.ModuleSpec.__CreateInstance(__ret);
        }

        public LLDB.ModuleSpecList FindMatchingSpecs(LLDB.ModuleSpec match_spec)
        {
            if (ReferenceEquals(match_spec, null))
                throw new global::System.ArgumentNullException("match_spec", "Cannot be null because it is a C++ reference (&).");
            var arg0 = match_spec.__Instance;
            var __ret = new LLDB.ModuleSpecList.Internal();
            Internal.FindMatchingSpecs_0((__Instance + __PointerAdjustment), new IntPtr(&__ret), arg0);
            return LLDB.ModuleSpecList.__CreateInstance(__ret);
        }

        public LLDB.ModuleSpec GetSpecAtIndex(uint i)
        {
            var __ret = new LLDB.ModuleSpec.Internal();
            Internal.GetSpecAtIndex_0((__Instance + __PointerAdjustment), new IntPtr(&__ret), i);
            return LLDB.ModuleSpec.__CreateInstance(__ret);
        }

        public bool GetDescription(LLDB.Stream description)
        {
            if (ReferenceEquals(description, null))
                throw new global::System.ArgumentNullException("description", "Cannot be null because it is a C++ reference (&).");
            var arg0 = description.__Instance;
            var __ret = Internal.GetDescription_0((__Instance + __PointerAdjustment), arg0);
            return __ret;
        }

        public static LLDB.ModuleSpecList GetModuleSpecifications(string path)
        {
            var arg0 = Marshal.StringToHGlobalAnsi(path);
            var __ret = new LLDB.ModuleSpecList.Internal();
            Internal.GetModuleSpecifications_0(new IntPtr(&__ret), arg0);
            Marshal.FreeHGlobal(arg0);
            return LLDB.ModuleSpecList.__CreateInstance(__ret);
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
