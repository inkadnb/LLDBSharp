//----------------------------------------------------------------------------
// This is autogenerated code by CppSharp.
// Do not edit this file or all your changes will be lost after re-generation.
//----------------------------------------------------------------------------
using System;
using System.Runtime.InteropServices;
using System.Security;

namespace LLDB
{
    public unsafe partial class Module : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 8)]
        public partial struct Internal
        {
            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb8SBModuleC2Ev")]
            internal static extern void ctor_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb8SBModuleC2ERKS0_")]
            internal static extern void cctor_1(global::System.IntPtr instance, global::System.IntPtr rhs);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb8SBModuleC2ERKNS_12SBModuleSpecE")]
            internal static extern void ctor_2(global::System.IntPtr instance, global::System.IntPtr module_spec);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb8SBModuleC2ERNS_9SBProcessEy")]
            internal static extern void ctor_3(global::System.IntPtr instance, global::System.IntPtr process, ulong header_addr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb8SBModuleD2Ev")]
            internal static extern void dtor_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZNK4lldb8SBModule7IsValidEv")]
            [return: MarshalAsAttribute(UnmanagedType.I1)]
            internal static extern bool IsValid_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb8SBModule5ClearEv")]
            internal static extern void Clear_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZNK4lldb8SBModule11GetFileSpecEv")]
            internal static extern void GetFileSpec_0(global::System.IntPtr @return, global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZNK4lldb8SBModule19GetPlatformFileSpecEv")]
            internal static extern void GetPlatformFileSpec_0(global::System.IntPtr @return, global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb8SBModule19SetPlatformFileSpecERKNS_10SBFileSpecE")]
            [return: MarshalAsAttribute(UnmanagedType.I1)]
            internal static extern bool SetPlatformFileSpec_0(global::System.IntPtr instance, global::System.IntPtr platform_file);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb8SBModule24GetRemoteInstallFileSpecEv")]
            internal static extern void GetRemoteInstallFileSpec_0(global::System.IntPtr @return, global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb8SBModule24SetRemoteInstallFileSpecERNS_10SBFileSpecE")]
            [return: MarshalAsAttribute(UnmanagedType.I1)]
            internal static extern bool SetRemoteInstallFileSpec_0(global::System.IntPtr instance, global::System.IntPtr file);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZNK4lldb8SBModuleeqERKS0_")]
            [return: MarshalAsAttribute(UnmanagedType.I1)]
            internal static extern bool OperatorEqualEqual_0(global::System.IntPtr instance, global::System.IntPtr rhs);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZNK4lldb8SBModuleneERKS0_")]
            [return: MarshalAsAttribute(UnmanagedType.I1)]
            internal static extern bool OperatorExclaimEqual_0(global::System.IntPtr instance, global::System.IntPtr rhs);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb8SBModule11FindSectionEPKc")]
            internal static extern void FindSection_0(global::System.IntPtr @return, global::System.IntPtr instance, global::System.IntPtr sect_name);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb8SBModule18ResolveFileAddressEy")]
            internal static extern void ResolveFileAddress_0(global::System.IntPtr @return, global::System.IntPtr instance, ulong vm_addr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb8SBModule30ResolveSymbolContextForAddressERKNS_9SBAddressEj")]
            internal static extern void ResolveSymbolContextForAddress_0(global::System.IntPtr @return, global::System.IntPtr instance, global::System.IntPtr addr, uint resolve_scope);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb8SBModule14GetDescriptionERNS_8SBStreamE")]
            [return: MarshalAsAttribute(UnmanagedType.I1)]
            internal static extern bool GetDescription_0(global::System.IntPtr instance, global::System.IntPtr description);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb8SBModule21GetCompileUnitAtIndexEj")]
            internal static extern void GetCompileUnitAtIndex_0(global::System.IntPtr @return, global::System.IntPtr instance, uint _0);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb8SBModule16GetSymbolAtIndexEm")]
            internal static extern void GetSymbolAtIndex_0(global::System.IntPtr @return, global::System.IntPtr instance, uint idx);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb8SBModule10FindSymbolEPKcNS_10SymbolTypeE")]
            internal static extern void FindSymbol_0(global::System.IntPtr @return, global::System.IntPtr instance, global::System.IntPtr name, LLDB.SymbolType type);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb8SBModule11FindSymbolsEPKcNS_10SymbolTypeE")]
            internal static extern void FindSymbols_0(global::System.IntPtr @return, global::System.IntPtr instance, global::System.IntPtr name, LLDB.SymbolType type);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb8SBModule17GetSectionAtIndexEm")]
            internal static extern void GetSectionAtIndex_0(global::System.IntPtr @return, global::System.IntPtr instance, uint idx);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb8SBModule13FindFunctionsEPKcj")]
            internal static extern void FindFunctions_0(global::System.IntPtr @return, global::System.IntPtr instance, global::System.IntPtr name, uint name_type_mask);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb8SBModule19FindGlobalVariablesERNS_8SBTargetEPKcj")]
            internal static extern void FindGlobalVariables_0(global::System.IntPtr @return, global::System.IntPtr instance, global::System.IntPtr target, global::System.IntPtr name, uint max_matches);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb8SBModule23FindFirstGlobalVariableERNS_8SBTargetEPKc")]
            internal static extern void FindFirstGlobalVariable_0(global::System.IntPtr @return, global::System.IntPtr instance, global::System.IntPtr target, global::System.IntPtr name);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb8SBModule13FindFirstTypeEPKc")]
            internal static extern void FindFirstType_0(global::System.IntPtr @return, global::System.IntPtr instance, global::System.IntPtr name);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb8SBModule9FindTypesEPKc")]
            internal static extern void FindTypes_0(global::System.IntPtr @return, global::System.IntPtr instance, global::System.IntPtr type);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb8SBModule11GetTypeByIDEy")]
            internal static extern void GetTypeByID_0(global::System.IntPtr @return, global::System.IntPtr instance, ulong uid);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb8SBModule12GetBasicTypeENS_9BasicTypeE")]
            internal static extern void GetBasicType_0(global::System.IntPtr @return, global::System.IntPtr instance, LLDB.BasicType type);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb8SBModule8GetTypesEj")]
            internal static extern void GetTypes_0(global::System.IntPtr @return, global::System.IntPtr instance, uint type_mask);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb8SBModule10GetVersionEPjj")]
            internal static extern uint GetVersion_0(global::System.IntPtr instance, uint* versions, uint num_versions);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZNK4lldb8SBModule17GetSymbolFileSpecEv")]
            internal static extern void GetSymbolFileSpec_0(global::System.IntPtr @return, global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZNK4lldb8SBModule26GetObjectFileHeaderAddressEv")]
            internal static extern void GetObjectFileHeaderAddress_0(global::System.IntPtr @return, global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb8SBModule12GetByteOrderEv")]
            internal static extern LLDB.ByteOrder GetByteOrder_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb8SBModule18GetAddressByteSizeEv")]
            internal static extern uint GetAddressByteSize_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb8SBModule9GetTripleEv")]
            internal static extern global::System.IntPtr GetTriple_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZNK4lldb8SBModule12GetUUIDBytesEv")]
            internal static extern byte* GetUUIDBytes_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZNK4lldb8SBModule13GetUUIDStringEv")]
            internal static extern global::System.IntPtr GetUUIDString_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb8SBModule18GetNumCompileUnitsEv")]
            internal static extern uint GetNumCompileUnits_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb8SBModule13GetNumSymbolsEv")]
            internal static extern uint GetNumSymbols_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("lldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZN4lldb8SBModule14GetNumSectionsEv")]
            internal static extern uint GetNumSections_0(global::System.IntPtr instance);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        public static readonly System.Collections.Concurrent.ConcurrentDictionary<IntPtr, Module> NativeToManagedMap = new System.Collections.Concurrent.ConcurrentDictionary<IntPtr, Module>();
        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        public static Module __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new Module(native.ToPointer(), skipVTables);
        }

        public static Module __CreateInstance(Module.Internal native, bool skipVTables = false)
        {
            return new Module(native, skipVTables);
        }

        private static void* __CopyValue(Module.Internal native)
        {
            var ret = Marshal.AllocHGlobal(8);
            LLDB.Module.Internal.cctor_1(ret, new global::System.IntPtr(&native));
            return ret.ToPointer();
        }

        private Module(Module.Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected Module(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public Module()
        {
            __Instance = Marshal.AllocHGlobal(8);
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            Internal.ctor_0((__Instance + __PointerAdjustment));
        }

        public Module(LLDB.Module rhs)
        {
            __Instance = Marshal.AllocHGlobal(8);
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            if (ReferenceEquals(rhs, null))
                throw new global::System.ArgumentNullException("rhs", "Cannot be null because it is a C++ reference (&).");
            var arg0 = rhs.__Instance;
            Internal.cctor_1((__Instance + __PointerAdjustment), arg0);
        }

        public Module(LLDB.ModuleSpec module_spec)
        {
            __Instance = Marshal.AllocHGlobal(8);
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            if (ReferenceEquals(module_spec, null))
                throw new global::System.ArgumentNullException("module_spec", "Cannot be null because it is a C++ reference (&).");
            var arg0 = module_spec.__Instance;
            Internal.ctor_2((__Instance + __PointerAdjustment), arg0);
        }

        public Module(LLDB.Process process, ulong header_addr)
        {
            __Instance = Marshal.AllocHGlobal(8);
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            if (ReferenceEquals(process, null))
                throw new global::System.ArgumentNullException("process", "Cannot be null because it is a C++ reference (&).");
            var arg0 = process.__Instance;
            Internal.ctor_3((__Instance + __PointerAdjustment), arg0, header_addr);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        protected virtual void Dispose(bool disposing)
        {
            LLDB.Module __dummy;
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

        public void Clear()
        {
            Internal.Clear_0((__Instance + __PointerAdjustment));
        }

        /// <summary>
        /// <para>Get const accessor for the module file specification.</para>
        /// </summary>
        /// <remarks>
        /// <para>This function returns the file for the module on the host system</para>
        /// <para>that is running LLDB. This can differ from the path on the </para>
        /// <para>platform since we might be doing remote debugging.</para>
        /// <para> </para>
        /// </remarks>
        public LLDB.FileSpec GetFileSpec()
        {
            var __ret = new LLDB.FileSpec.Internal();
            Internal.GetFileSpec_0(new IntPtr(&__ret), (__Instance + __PointerAdjustment));
            return LLDB.FileSpec.__CreateInstance(__ret);
        }

        /// <summary>
        /// <para>Get accessor for the module platform file specification.</para>
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
        /// <para> </para>
        /// </remarks>
        public LLDB.FileSpec GetPlatformFileSpec()
        {
            var __ret = new LLDB.FileSpec.Internal();
            Internal.GetPlatformFileSpec_0(new IntPtr(&__ret), (__Instance + __PointerAdjustment));
            return LLDB.FileSpec.__CreateInstance(__ret);
        }

        public bool SetPlatformFileSpec(LLDB.FileSpec platform_file)
        {
            if (ReferenceEquals(platform_file, null))
                throw new global::System.ArgumentNullException("platform_file", "Cannot be null because it is a C++ reference (&).");
            var arg0 = platform_file.__Instance;
            var __ret = Internal.SetPlatformFileSpec_0((__Instance + __PointerAdjustment), arg0);
            return __ret;
        }

        /// <summary>
        /// <para>Get accessor for the remote install path for a module.</para>
        /// </summary>
        /// <remarks>
        /// <para>When debugging to a remote platform by connecting to a remote</para>
        /// <para>platform, the install path of the module can be set. If the</para>
        /// <para>install path is set, every time the process is about to launch</para>
        /// <para>the target will install this module on the remote platform prior</para>
        /// <para>to launching.</para>
        /// <para> </para>
        /// </remarks>
        public LLDB.FileSpec GetRemoteInstallFileSpec()
        {
            var __ret = new LLDB.FileSpec.Internal();
            Internal.GetRemoteInstallFileSpec_0(new IntPtr(&__ret), (__Instance + __PointerAdjustment));
            return LLDB.FileSpec.__CreateInstance(__ret);
        }

        /// <summary>
        /// <para>Set accessor for the remote install path for a module.</para>
        /// </summary>
        /// <remarks>
        /// <para>When debugging to a remote platform by connecting to a remote</para>
        /// <para>platform, the install path of the module can be set. If the</para>
        /// <para>install path is set, every time the process is about to launch</para>
        /// <para>the target will install this module on the remote platform prior</para>
        /// <para>to launching.</para>
        /// <para>If </para>
        /// <para>specifies a full path to an install location, the</para>
        /// <para>module will be installed to this path. If the path is relative</para>
        /// <para>(no directory specified, or the path is partial like &quot;usr/lib&quot;</para>
        /// <para>or &quot;./usr/lib&quot;, then the install path will be resolved using</para>
        /// <para>the platform's current working directory as the base path.</para>
        /// <para> </para>
        /// </remarks>
        public bool SetRemoteInstallFileSpec(LLDB.FileSpec file)
        {
            if (ReferenceEquals(file, null))
                throw new global::System.ArgumentNullException("file", "Cannot be null because it is a C++ reference (&).");
            var arg0 = file.__Instance;
            var __ret = Internal.SetRemoteInstallFileSpec_0((__Instance + __PointerAdjustment), arg0);
            return __ret;
        }

        public static bool operator ==(LLDB.Module __op, LLDB.Module rhs)
        {
            bool __opNull = ReferenceEquals(__op, null);
            bool rhsNull = ReferenceEquals(rhs, null);
            if (__opNull || rhsNull)
                return __opNull && rhsNull;
            var arg0 = __op.__Instance;
            var arg1 = rhs.__Instance;
            var __ret = Internal.OperatorEqualEqual_0(arg0, arg1);
            return __ret;
        }

        public override bool Equals(object obj)
        {
            return this == obj as Module;
        }

        public override int GetHashCode()
        {
            if (__Instance == global::System.IntPtr.Zero)
                return global::System.IntPtr.Zero.GetHashCode();
            return (*(Internal*) __Instance).GetHashCode();
        }

        public static bool operator !=(LLDB.Module __op, LLDB.Module rhs)
        {
            bool __opNull = ReferenceEquals(__op, null);
            bool rhsNull = ReferenceEquals(rhs, null);
            if (__opNull || rhsNull)
                return !(__opNull && rhsNull);
            var arg0 = __op.__Instance;
            var arg1 = rhs.__Instance;
            var __ret = Internal.OperatorExclaimEqual_0(arg0, arg1);
            return __ret;
        }

        public LLDB.Section FindSection(string sect_name)
        {
            var arg0 = Marshal.StringToHGlobalAnsi(sect_name);
            var __ret = new LLDB.Section.Internal();
            Internal.FindSection_0(new IntPtr(&__ret), (__Instance + __PointerAdjustment), arg0);
            Marshal.FreeHGlobal(arg0);
            return LLDB.Section.__CreateInstance(__ret);
        }

        public LLDB.Address ResolveFileAddress(ulong vm_addr)
        {
            var __ret = new LLDB.Address.Internal();
            Internal.ResolveFileAddress_0(new IntPtr(&__ret), (__Instance + __PointerAdjustment), vm_addr);
            return LLDB.Address.__CreateInstance(__ret);
        }

        public LLDB.SymbolContext ResolveSymbolContextForAddress(LLDB.Address addr, uint resolve_scope)
        {
            if (ReferenceEquals(addr, null))
                throw new global::System.ArgumentNullException("addr", "Cannot be null because it is a C++ reference (&).");
            var arg0 = addr.__Instance;
            var __ret = new LLDB.SymbolContext.Internal();
            Internal.ResolveSymbolContextForAddress_0(new IntPtr(&__ret), (__Instance + __PointerAdjustment), arg0, resolve_scope);
            return LLDB.SymbolContext.__CreateInstance(__ret);
        }

        public bool GetDescription(LLDB.Stream description)
        {
            if (ReferenceEquals(description, null))
                throw new global::System.ArgumentNullException("description", "Cannot be null because it is a C++ reference (&).");
            var arg0 = description.__Instance;
            var __ret = Internal.GetDescription_0((__Instance + __PointerAdjustment), arg0);
            return __ret;
        }

        public LLDB.CompileUnit GetCompileUnitAtIndex(uint _0)
        {
            var __ret = new LLDB.CompileUnit.Internal();
            Internal.GetCompileUnitAtIndex_0(new IntPtr(&__ret), (__Instance + __PointerAdjustment), _0);
            return LLDB.CompileUnit.__CreateInstance(__ret);
        }

        public LLDB.Symbol GetSymbolAtIndex(uint idx)
        {
            var __ret = new LLDB.Symbol.Internal();
            Internal.GetSymbolAtIndex_0(new IntPtr(&__ret), (__Instance + __PointerAdjustment), idx);
            return LLDB.Symbol.__CreateInstance(__ret);
        }

        public LLDB.Symbol FindSymbol(string name, LLDB.SymbolType type)
        {
            var arg0 = Marshal.StringToHGlobalAnsi(name);
            var arg1 = type;
            var __ret = new LLDB.Symbol.Internal();
            Internal.FindSymbol_0(new IntPtr(&__ret), (__Instance + __PointerAdjustment), arg0, arg1);
            Marshal.FreeHGlobal(arg0);
            return LLDB.Symbol.__CreateInstance(__ret);
        }

        public LLDB.SymbolContextList FindSymbols(string name, LLDB.SymbolType type)
        {
            var arg0 = Marshal.StringToHGlobalAnsi(name);
            var arg1 = type;
            var __ret = new LLDB.SymbolContextList.Internal();
            Internal.FindSymbols_0(new IntPtr(&__ret), (__Instance + __PointerAdjustment), arg0, arg1);
            Marshal.FreeHGlobal(arg0);
            return LLDB.SymbolContextList.__CreateInstance(__ret);
        }

        public LLDB.Section GetSectionAtIndex(uint idx)
        {
            var __ret = new LLDB.Section.Internal();
            Internal.GetSectionAtIndex_0(new IntPtr(&__ret), (__Instance + __PointerAdjustment), idx);
            return LLDB.Section.__CreateInstance(__ret);
        }

        /// <summary>
        /// <para>Find functions by name.</para>
        /// </summary>
        /// <remarks>
        /// <para> </para>
        /// <para> </para>
        /// <para> </para>
        /// </remarks>
        public LLDB.SymbolContextList FindFunctions(string name, uint name_type_mask)
        {
            var arg0 = Marshal.StringToHGlobalAnsi(name);
            var __ret = new LLDB.SymbolContextList.Internal();
            Internal.FindFunctions_0(new IntPtr(&__ret), (__Instance + __PointerAdjustment), arg0, name_type_mask);
            Marshal.FreeHGlobal(arg0);
            return LLDB.SymbolContextList.__CreateInstance(__ret);
        }

        /// <summary>
        /// <para>Find global and static variables by name.</para>
        /// </summary>
        /// <remarks>
        /// <para> </para>
        /// <para> </para>
        /// <para> </para>
        /// <para> </para>
        /// </remarks>
        public LLDB.ValueList FindGlobalVariables(LLDB.Target target, string name, uint max_matches)
        {
            if (ReferenceEquals(target, null))
                throw new global::System.ArgumentNullException("target", "Cannot be null because it is a C++ reference (&).");
            var arg0 = target.__Instance;
            var arg1 = Marshal.StringToHGlobalAnsi(name);
            var __ret = new LLDB.ValueList.Internal();
            Internal.FindGlobalVariables_0(new IntPtr(&__ret), (__Instance + __PointerAdjustment), arg0, arg1, max_matches);
            Marshal.FreeHGlobal(arg1);
            return LLDB.ValueList.__CreateInstance(__ret);
        }

        /// <summary>
        /// <para>Find the first global (or static) variable by name.</para>
        /// </summary>
        /// <remarks>
        /// <para> </para>
        /// <para> </para>
        /// <para> </para>
        /// </remarks>
        public LLDB.Value FindFirstGlobalVariable(LLDB.Target target, string name)
        {
            if (ReferenceEquals(target, null))
                throw new global::System.ArgumentNullException("target", "Cannot be null because it is a C++ reference (&).");
            var arg0 = target.__Instance;
            var arg1 = Marshal.StringToHGlobalAnsi(name);
            var __ret = new LLDB.Value.Internal();
            Internal.FindFirstGlobalVariable_0(new IntPtr(&__ret), (__Instance + __PointerAdjustment), arg0, arg1);
            Marshal.FreeHGlobal(arg1);
            return LLDB.Value.__CreateInstance(__ret);
        }

        public LLDB.Type FindFirstType(string name)
        {
            var arg0 = Marshal.StringToHGlobalAnsi(name);
            var __ret = new LLDB.Type.Internal();
            Internal.FindFirstType_0(new IntPtr(&__ret), (__Instance + __PointerAdjustment), arg0);
            Marshal.FreeHGlobal(arg0);
            return LLDB.Type.__CreateInstance(__ret);
        }

        public LLDB.TypeList FindTypes(string type)
        {
            var arg0 = Marshal.StringToHGlobalAnsi(type);
            var __ret = new LLDB.TypeList.Internal();
            Internal.FindTypes_0(new IntPtr(&__ret), (__Instance + __PointerAdjustment), arg0);
            Marshal.FreeHGlobal(arg0);
            return LLDB.TypeList.__CreateInstance(__ret);
        }

        /// <summary>
        /// <para>Get a type using its type ID.</para>
        /// </summary>
        /// <remarks>
        /// <para>Each symbol file reader will assign different user IDs to their</para>
        /// <para>types, but it is sometimes useful when debugging type issues to</para>
        /// <para>be able to grab a type using its type ID.</para>
        /// <para>For DWARF debug info, the type ID is the DIE offset.</para>
        /// <para> </para>
        /// <para> </para>
        /// </remarks>
        public LLDB.Type GetTypeByID(ulong uid)
        {
            var __ret = new LLDB.Type.Internal();
            Internal.GetTypeByID_0(new IntPtr(&__ret), (__Instance + __PointerAdjustment), uid);
            return LLDB.Type.__CreateInstance(__ret);
        }

        public LLDB.Type GetBasicType(LLDB.BasicType type)
        {
            var arg0 = type;
            var __ret = new LLDB.Type.Internal();
            Internal.GetBasicType_0(new IntPtr(&__ret), (__Instance + __PointerAdjustment), arg0);
            return LLDB.Type.__CreateInstance(__ret);
        }

        /// <summary>
        /// <para>Get all types matching </para>
        /// </summary>
        /// <remarks>
        /// <para>from debug info in this</para>
        /// <para>module.</para>
        /// <para> </para>
        /// <para> </para>
        /// </remarks>
        public LLDB.TypeList GetTypes(uint type_mask)
        {
            var __ret = new LLDB.TypeList.Internal();
            Internal.GetTypes_0(new IntPtr(&__ret), (__Instance + __PointerAdjustment), type_mask);
            return LLDB.TypeList.__CreateInstance(__ret);
        }

        /// <summary>
        /// <para>Get the module version numbers.</para>
        /// </summary>
        /// <remarks>
        /// <para>Many object files have a set of version numbers that describe</para>
        /// <para>the version of the executable or shared library. Typically there</para>
        /// <para>are major, minor and build, but there may be more. This function</para>
        /// <para>will extract the versions from object files if they are available.</para>
        /// <para>If </para>
        /// <para>is NULL, or if </para>
        /// <para>is 0, the return</para>
        /// <para>value will indicate how many version numbers are available in</para>
        /// <para>this object file. Then a subsequent call can be made to this </para>
        /// <para>function with a value of </para>
        /// <para>and </para>
        /// <para>that</para>
        /// <para>has enough storage to store some or all version numbers.</para>
        /// <para> </para>
        /// <para> </para>
        /// <para> </para>
        /// </remarks>
        public uint GetVersion(ref uint versions, uint num_versions)
        {
            fixed (uint* __refParamPtr0 = &versions)
            {
                var arg0 = __refParamPtr0;
                var __ret = Internal.GetVersion_0((__Instance + __PointerAdjustment), arg0, num_versions);
                return __ret;
            }
        }

        /// <summary>
        /// <para>Get accessor for the symbol file specification.</para>
        /// </summary>
        /// <remarks>
        /// <para>When debugging an object file an additional debug information can</para>
        /// <para>be provided in separate file. Therefore if you debugging something</para>
        /// <para>like '/usr/lib/liba.dylib' then debug information can be located</para>
        /// <para>in folder like '/usr/lib/liba.dylib.dSYM/'.</para>
        /// <para> </para>
        /// </remarks>
        public LLDB.FileSpec GetSymbolFileSpec()
        {
            var __ret = new LLDB.FileSpec.Internal();
            Internal.GetSymbolFileSpec_0(new IntPtr(&__ret), (__Instance + __PointerAdjustment));
            return LLDB.FileSpec.__CreateInstance(__ret);
        }

        public LLDB.Address GetObjectFileHeaderAddress()
        {
            var __ret = new LLDB.Address.Internal();
            Internal.GetObjectFileHeaderAddress_0(new IntPtr(&__ret), (__Instance + __PointerAdjustment));
            return LLDB.Address.__CreateInstance(__ret);
        }

        public LLDB.ByteOrder ByteOrder
        {
            get
            {
                var __ret = Internal.GetByteOrder_0((__Instance + __PointerAdjustment));
                return __ret;
            }
        }

        public uint AddressByteSize
        {
            get
            {
                var __ret = Internal.GetAddressByteSize_0((__Instance + __PointerAdjustment));
                return __ret;
            }
        }

        public string Triple
        {
            get
            {
                var __ret = Internal.GetTriple_0((__Instance + __PointerAdjustment));
                return Marshal.PtrToStringAnsi(__ret);
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

        public string UUIDString
        {
            get
            {
                var __ret = Internal.GetUUIDString_0((__Instance + __PointerAdjustment));
                return Marshal.PtrToStringAnsi(__ret);
            }
        }

        public uint NumCompileUnits
        {
            get
            {
                var __ret = Internal.GetNumCompileUnits_0((__Instance + __PointerAdjustment));
                return __ret;
            }
        }

        public uint NumSymbols
        {
            get
            {
                var __ret = Internal.GetNumSymbols_0((__Instance + __PointerAdjustment));
                return __ret;
            }
        }

        public uint NumSections
        {
            get
            {
                var __ret = Internal.GetNumSections_0((__Instance + __PointerAdjustment));
                return __ret;
            }
        }
    }
}
