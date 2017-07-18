// ----------------------------------------------------------------------------
// <auto-generated>
// This is autogenerated code by CppSharp.
// Do not edit this file or all your changes will be lost after re-generation.
// </auto-generated>
// ----------------------------------------------------------------------------
using System;
using System.Runtime.InteropServices;
using System.Security;
using System.Runtime.CompilerServices;

[assembly:InternalsVisibleTo("CppSharp.Parser.CSharp")]

[assembly:InternalsVisibleTo("CppSharp.CppParser")]

namespace Std
{
}

namespace GnuCxx
{
}

namespace Std
{
    namespace ExceptionPtr
    {
        public unsafe partial class ExceptionPtr
        {
            [StructLayout(LayoutKind.Explicit, Size = 8)]
            public partial struct __Internal
            {
                [FieldOffset(0)]
                internal global::System.IntPtr _M_exception_object;
            }
        }
    }
}

namespace Std
{
    namespace Allocator
    {
        [StructLayout(LayoutKind.Explicit, Size = 0)]
        public unsafe partial struct __Internal
        {
            [SuppressUnmanagedCodeSecurity]
            [DllImport("Std-symbols", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZNSaIcEC2Ev")]
            internal static extern void ctorc__N_std_S_allocator__C(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("Std-symbols", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZNSaIcED2Ev")]
            internal static extern void dtorc__N_std_S_allocator__C(global::System.IntPtr instance);
        }
    }

    public unsafe partial class Allocator<_Tp> : IDisposable
    {
        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::Std.Allocator<_Tp>> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::Std.Allocator<_Tp>>();
        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::Std.Allocator<_Tp> __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::Std.Allocator<_Tp>(native.ToPointer(), skipVTables);
        }

        internal static global::Std.Allocator<_Tp> __CreateInstance(global::Std.Allocator.__Internal native, bool skipVTables = false)
        {
            return new global::Std.Allocator<_Tp>(native, skipVTables);
        }

        private static void* __CopyValue(global::Std.Allocator.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::Std.Allocator.__Internal));
            *(global::Std.Allocator.__Internal*) ret = native;
            return ret.ToPointer();
        }

        private Allocator(global::Std.Allocator.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected Allocator(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public Allocator()
        {
            var ___Tp = typeof(_Tp);
            if (___Tp.IsAssignableFrom(typeof(sbyte)))
            {
                __Instance = Marshal.AllocHGlobal(sizeof(global::Std.Allocator.__Internal));
                __ownsNativeInstance = true;
                NativeToManagedMap[__Instance] = this;
                global::Std.Allocator.__Internal.ctorc__N_std_S_allocator__C((__Instance + __PointerAdjustment));
                return;
            }
            throw new ArgumentOutOfRangeException("_Tp", string.Join(", ", new[] { typeof(_Tp).FullName }), "global::Std.Allocator<_Tp> maps a C++ template class and therefore it only supports a limited set of types and their subclasses: <sbyte>.");
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::Std.Allocator<_Tp> __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (disposing)
            {
                var ___Tp = typeof(_Tp);
                if (___Tp.IsAssignableFrom(typeof(sbyte)))
                {
                    global::Std.Allocator.__Internal.dtorc__N_std_S_allocator__C((__Instance + __PointerAdjustment));
                    return;
                }
                throw new ArgumentOutOfRangeException("_Tp", string.Join(", ", new[] { typeof(_Tp).FullName }), "global::Std.Allocator<_Tp> maps a C++ template class and therefore it only supports a limited set of types and their subclasses: <sbyte>.");
            }
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }
    }
}

namespace Std
{
    namespace VectorBase
    {
        [StructLayout(LayoutKind.Explicit, Size = 24)]
        public unsafe partial struct __Internal
        {
            [FieldOffset(0)]
            internal global::Std.VectorBase.VectorImpl.__Internal _M_impl;
        }


        public unsafe partial class VectorImpl
        {
            [StructLayout(LayoutKind.Explicit, Size = 24)]
            public partial struct __Internal
            {
                [FieldOffset(0)]
                internal global::System.IntPtr _M_start;

                [FieldOffset(8)]
                internal global::System.IntPtr _M_finish;

                [FieldOffset(16)]
                internal global::System.IntPtr _M_end_of_storage;
            }
        }
    }

    namespace Vector
    {
        [StructLayout(LayoutKind.Explicit, Size = 24)]
        public unsafe partial struct __Internal
        {
            [FieldOffset(0)]
            internal global::Std.VectorBase.VectorImpl.__Internal _M_impl;
        }
    }
}

namespace Std
{
    public unsafe partial class BitIterator
    {
        [StructLayout(LayoutKind.Explicit, Size = 16)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal global::System.IntPtr _M_p;

            [FieldOffset(8)]
            internal uint _M_offset;
        }
    }

    public unsafe partial class BitConstIterator
    {
        [StructLayout(LayoutKind.Explicit, Size = 16)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal global::System.IntPtr _M_p;

            [FieldOffset(8)]
            internal uint _M_offset;
        }
    }
}

namespace Std
{
    namespace Less
    {
        [StructLayout(LayoutKind.Explicit, Size = 0)]
        public unsafe partial struct __Internal
        {
        }
    }
}

namespace Std
{
    public enum RbTreeColor : uint
    {
        S_red = 0,
        S_black = 1
    }

    namespace RbTree
    {
        [StructLayout(LayoutKind.Explicit, Size = 48)]
        public unsafe partial struct __Internal
        {
            [FieldOffset(0)]
            internal global::Std.RbTree.RbTreeImpl.__Internal _M_impl;
        }


        public unsafe partial class RbTreeImpl
        {
            [StructLayout(LayoutKind.Explicit, Size = 48)]
            public unsafe partial struct __Internal
            {
                [FieldOffset(0)]
                internal global::Std.Less.__Internal _M_key_compare;

                [FieldOffset(8)]
                internal global::Std.RbTreeNodeBase.__Internal _M_header;

                [FieldOffset(40)]
                internal ulong _M_node_count;
            }

        }

        public unsafe partial class ReuseOrAllocNode
        {
            [StructLayout(LayoutKind.Explicit, Size = 0)]
            public partial struct __Internal
            {
            }

        }

        public unsafe partial class AllocNode
        {
            [StructLayout(LayoutKind.Explicit, Size = 0)]
            public partial struct __Internal
            {
            }
        }
    }

    public unsafe partial class RbTreeNodeBase
    {
        [StructLayout(LayoutKind.Explicit, Size = 32)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal global::Std.RbTreeColor _M_color;

            [FieldOffset(8)]
            internal global::System.IntPtr _M_parent;

            [FieldOffset(16)]
            internal global::System.IntPtr _M_left;

            [FieldOffset(24)]
            internal global::System.IntPtr _M_right;
        }
    }
}

namespace GnuCxx
{
}

namespace Std
{
    namespace Map
    {
        [StructLayout(LayoutKind.Explicit, Size = 48)]
        public unsafe partial struct __Internal
        {
            [FieldOffset(0)]
            internal global::Std.RbTree.__Internal _M_t;
        }


        public unsafe partial class ValueCompare
        {
            [StructLayout(LayoutKind.Explicit, Size = 0)]
            public partial struct __Internal
            {
            }
        }
    }
}

namespace Std
{
}

namespace Std
{
    namespace Cxx11
    {
    }

    namespace Cxx11
    {
    }
}

public unsafe partial class MbstateT
{
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial struct __Internal
    {
        [FieldOffset(0)]
        internal int __count;

        [FieldOffset(4)]
        internal global::MbstateT._.__Internal __value;
    }

    public unsafe partial struct _
    {
        [StructLayout(LayoutKind.Explicit, Size = 4)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal uint __wch;

            [FieldOffset(0)]
            internal fixed sbyte __wchb[4];
        }
    }
}

namespace Std
{
    namespace CharTraits
    {
        [StructLayout(LayoutKind.Explicit, Size = 0)]
        public unsafe partial struct __Internal
        {
        }
    }

    public unsafe partial class CharTraits<_CharT> : IDisposable
    {
        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::Std.CharTraits<_CharT>> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::Std.CharTraits<_CharT>>();
        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::Std.CharTraits<_CharT> __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::Std.CharTraits<_CharT>(native.ToPointer(), skipVTables);
        }

        internal static global::Std.CharTraits<_CharT> __CreateInstance(global::Std.CharTraits.__Internal native, bool skipVTables = false)
        {
            return new global::Std.CharTraits<_CharT>(native, skipVTables);
        }

        private static void* __CopyValue(global::Std.CharTraits.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::Std.CharTraits.__Internal));
            *(global::Std.CharTraits.__Internal*) ret = native;
            return ret.ToPointer();
        }

        private CharTraits(global::Std.CharTraits.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected CharTraits(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::Std.CharTraits<_CharT> __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }
    }
}

namespace Std
{
}

namespace Std
{
}

public unsafe partial class Timespec
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct __Internal
    {
        [FieldOffset(0)]
        internal long tv_sec;

        [FieldOffset(8)]
        internal long tv_nsec;
    }
}

public unsafe partial class Timeval
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct __Internal
    {
        [FieldOffset(0)]
        internal long tv_sec;

        [FieldOffset(8)]
        internal long tv_usec;
    }
}

public unsafe partial class PthreadInternalList
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct __Internal
    {
        [FieldOffset(0)]
        internal global::System.IntPtr __prev;

        [FieldOffset(8)]
        internal global::System.IntPtr __next;
    }
}

public unsafe partial struct PthreadMutexT
{
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public partial struct __Internal
    {
        [FieldOffset(0)]
        internal global::PthreadMutexT.PthreadMutexS.__Internal __data;

        [FieldOffset(0)]
        internal fixed sbyte __size[40];

        [FieldOffset(0)]
        internal long __align;
    }

    public unsafe partial class PthreadMutexS
    {
        [StructLayout(LayoutKind.Explicit, Size = 40)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal int __lock;

            [FieldOffset(4)]
            internal uint __count;

            [FieldOffset(8)]
            internal int __owner;

            [FieldOffset(12)]
            internal uint __nusers;

            [FieldOffset(16)]
            internal int __kind;

            [FieldOffset(20)]
            internal short __spins;

            [FieldOffset(22)]
            internal short __elision;

            [FieldOffset(24)]
            internal global::PthreadInternalList.__Internal __list;
        }
    }
}

public unsafe partial struct PthreadCondT
{
    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public partial struct __Internal
    {
        [FieldOffset(0)]
        internal global::PthreadCondT._.__Internal __data;

        [FieldOffset(0)]
        internal fixed sbyte __size[48];

        [FieldOffset(0)]
        internal long __align;
    }

    public unsafe partial class _
    {
        [StructLayout(LayoutKind.Explicit, Size = 48)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal int __lock;

            [FieldOffset(4)]
            internal uint __futex;

            [FieldOffset(8)]
            internal ulong __total_seq;

            [FieldOffset(16)]
            internal ulong __wakeup_seq;

            [FieldOffset(24)]
            internal ulong __woken_seq;

            [FieldOffset(32)]
            internal global::System.IntPtr __mutex;

            [FieldOffset(40)]
            internal uint __nwaiters;

            [FieldOffset(44)]
            internal uint __broadcast_seq;
        }
    }
}

public unsafe partial struct PthreadRwlockT
{
    [StructLayout(LayoutKind.Explicit, Size = 56)]
    public partial struct __Internal
    {
        [FieldOffset(0)]
        internal global::PthreadRwlockT._.__Internal __data;

        [FieldOffset(0)]
        internal fixed sbyte __size[56];

        [FieldOffset(0)]
        internal long __align;
    }

    public unsafe partial class _
    {
        [StructLayout(LayoutKind.Explicit, Size = 56)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal int __lock;

            [FieldOffset(4)]
            internal uint __nr_readers;

            [FieldOffset(8)]
            internal uint __readers_wakeup;

            [FieldOffset(12)]
            internal uint __writer_wakeup;

            [FieldOffset(16)]
            internal uint __nr_readers_queued;

            [FieldOffset(20)]
            internal uint __nr_writers_queued;

            [FieldOffset(24)]
            internal int __writer;

            [FieldOffset(28)]
            internal int __shared;

            [FieldOffset(32)]
            internal sbyte __rwelision;

            [FieldOffset(33)]
            internal fixed byte __pad1[7];

            [FieldOffset(40)]
            internal ulong __pad2;

            [FieldOffset(48)]
            internal uint __flags;
        }
    }
}

public unsafe partial class PthreadUnwindBufT
{
    [StructLayout(LayoutKind.Explicit, Size = 104)]
    public partial struct __Internal
    {
        [FieldOffset(0)]
        internal fixed byte __cancel_jmp_buf[72];

        [FieldOffset(72)]
        internal void* __pad;
    }

    public unsafe partial class _
    {
        [StructLayout(LayoutKind.Explicit, Size = 72)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal fixed long __cancel_jmp_buf[8];

            [FieldOffset(64)]
            internal int __mask_was_saved;
        }
    }
}

namespace Std
{
    namespace Cxx11
    {
        public unsafe static partial class BasicStringExtensions
        {
            [StructLayout(LayoutKind.Explicit, Size = 0)]
            public partial struct __Internal
            {
                [SuppressUnmanagedCodeSecurity]
                [DllImport("Std-symbols", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZNSt7__cxx1112basic_stringIcSt11char_traitsIcESaIcEEC2EPKcRKS3_")]
                internal static extern global::System.IntPtr BasicString(global::System.IntPtr instance, [MarshalAs(UnmanagedType.LPStr)] string __s, global::System.IntPtr __a);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("Std-symbols", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZNKSt7__cxx1112basic_stringIcSt11char_traitsIcESaIcEE5c_strEv")]
                internal static extern global::System.IntPtr CStr(global::System.IntPtr instance);
            }

            public static global::Std.Cxx11.BasicString<sbyte, global::Std.CharTraits<sbyte>, global::Std.Allocator<sbyte>> BasicString(string __s, global::Std.Allocator<sbyte> __a)
            {
                if (ReferenceEquals(__a, null))
                    throw new global::System.ArgumentNullException("__a", "Cannot be null because it is a C++ reference (&).");
                var __arg1 = __a.__Instance;
                var __ret = Marshal.AllocHGlobal(32);
                __Internal.BasicString(__ret, __s, __arg1);
                global::Std.Cxx11.BasicString<sbyte, global::Std.CharTraits<sbyte>, global::Std.Allocator<sbyte>> __result0;
                if (__ret == IntPtr.Zero) __result0 = null;
                else if (global::Std.Cxx11.BasicString<sbyte, global::Std.CharTraits<sbyte>, global::Std.Allocator<sbyte>>.NativeToManagedMap.ContainsKey(__ret))
                    __result0 = (global::Std.Cxx11.BasicString<sbyte, global::Std.CharTraits<sbyte>, global::Std.Allocator<sbyte>>) global::Std.Cxx11.BasicString<sbyte, global::Std.CharTraits<sbyte>, global::Std.Allocator<sbyte>>.NativeToManagedMap[__ret];
                else __result0 = global::Std.Cxx11.BasicString<sbyte, global::Std.CharTraits<sbyte>, global::Std.Allocator<sbyte>>.__CreateInstance(__ret);
                return __result0;
            }

            public static string CStr(this global::Std.Cxx11.BasicString<sbyte, global::Std.CharTraits<sbyte>, global::Std.Allocator<sbyte>> @this)
            {
                var __arg0 = ReferenceEquals(@this, null) ? global::System.IntPtr.Zero : @this.__Instance;
                var __ret = __Internal.CStr(__arg0);
                return Marshal.PtrToStringAnsi(__ret);
            }
        }

        namespace BasicString
        {
            [StructLayout(LayoutKind.Explicit, Size = 32)]
            public unsafe partial struct __Internal
            {
                [FieldOffset(0)]
                internal global::Std.Cxx11.BasicString.AllocHider.__Internal _M_dataplus;

                [FieldOffset(8)]
                internal ulong _M_string_length;

                [FieldOffset(16)]
                internal global::Std.Cxx11.BasicString._.__Internal _;

                [SuppressUnmanagedCodeSecurity]
                [DllImport("Std-symbols", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZNSt7__cxx1112basic_stringIcSt11char_traitsIcESaIcEED2Ev")]
                internal static extern void dtorc__N_std_N___cxx11_S_basic_string__C___N_std_S_char_traits__C___N_std_S_allocator__C(global::System.IntPtr instance);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("Std-symbols", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZNKSt7__cxx1112basic_stringIcSt11char_traitsIcESaIcEE5c_strEv")]
                internal static extern global::System.IntPtr CStrc__N_std_N___cxx11_S_basic_string__C___N_std_S_char_traits__C___N_std_S_allocator__C(global::System.IntPtr instance);
            }


            public unsafe partial class AllocHider
            {
                [StructLayout(LayoutKind.Explicit, Size = 8)]
                public partial struct __Internal
                {
                    [FieldOffset(0)]
                    internal global::System.IntPtr _M_p;
                }

            }

            public unsafe partial struct _
            {
                [StructLayout(LayoutKind.Explicit, Size = 16)]
                public partial struct __Internal
                {
                    [FieldOffset(0)]
                    internal fixed sbyte _M_local_buf[16];

                    [FieldOffset(0)]
                    internal ulong _M_allocated_capacity;
                }
            }
        }

        public unsafe partial class BasicString<_CharT, _Traits, _Alloc> : IDisposable
        {
            internal enum S_localCapacity
            {
                S_localCapacity = 0
            }

            public global::System.IntPtr __Instance { get; protected set; }

            protected int __PointerAdjustment;
            internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::Std.Cxx11.BasicString<_CharT, _Traits, _Alloc>> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::Std.Cxx11.BasicString<_CharT, _Traits, _Alloc>>();
            protected void*[] __OriginalVTables;

            protected bool __ownsNativeInstance;

            internal static global::Std.Cxx11.BasicString<_CharT, _Traits, _Alloc> __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
            {
                return new global::Std.Cxx11.BasicString<_CharT, _Traits, _Alloc>(native.ToPointer(), skipVTables);
            }

            internal static global::Std.Cxx11.BasicString<_CharT, _Traits, _Alloc> __CreateInstance(global::Std.Cxx11.BasicString.__Internal native, bool skipVTables = false)
            {
                return new global::Std.Cxx11.BasicString<_CharT, _Traits, _Alloc>(native, skipVTables);
            }

            private static void* __CopyValue(global::Std.Cxx11.BasicString.__Internal native)
            {
                var ret = Marshal.AllocHGlobal(sizeof(global::Std.Cxx11.BasicString.__Internal));
                *(global::Std.Cxx11.BasicString.__Internal*) ret = native;
                return ret.ToPointer();
            }

            private BasicString(global::Std.Cxx11.BasicString.__Internal native, bool skipVTables = false)
                : this(__CopyValue(native), skipVTables)
            {
                __ownsNativeInstance = true;
                NativeToManagedMap[__Instance] = this;
            }

            protected BasicString(void* native, bool skipVTables = false)
            {
                if (native == null)
                    return;
                __Instance = new global::System.IntPtr(native);
            }

            public void Dispose()
            {
                Dispose(disposing: true);
            }

            public virtual void Dispose(bool disposing)
            {
                if (__Instance == IntPtr.Zero)
                    return;
                global::Std.Cxx11.BasicString<_CharT, _Traits, _Alloc> __dummy;
                NativeToManagedMap.TryRemove(__Instance, out __dummy);
                if (disposing)
                {
                    var ___CharT = typeof(_CharT);
                    var ___Traits = typeof(_Traits);
                    var ___Alloc = typeof(_Alloc);
                    if (___CharT.IsAssignableFrom(typeof(sbyte)) && ___Traits.IsAssignableFrom(typeof(global::Std.CharTraits<sbyte>)) && ___Alloc.IsAssignableFrom(typeof(global::Std.Allocator<sbyte>)))
                    {
                        global::Std.Cxx11.BasicString.__Internal.dtorc__N_std_N___cxx11_S_basic_string__C___N_std_S_char_traits__C___N_std_S_allocator__C((__Instance + __PointerAdjustment));
                        return;
                    }
                    throw new ArgumentOutOfRangeException("_CharT, _Traits, _Alloc", string.Join(", ", new[] { typeof(_CharT).FullName, typeof(_Traits).FullName, typeof(_Alloc).FullName }), "global::Std.Cxx11.BasicString<_CharT, _Traits, _Alloc> maps a C++ template class and therefore it only supports a limited set of types and their subclasses: <sbyte, global::Std.CharTraits<sbyte>, global::Std.Allocator<sbyte>>.");
                }
                if (__ownsNativeInstance)
                    Marshal.FreeHGlobal(__Instance);
                __Instance = IntPtr.Zero;
            }
        }
    }
}

public unsafe partial struct Wait
{
    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public partial struct __Internal
    {
        [FieldOffset(0)]
        internal int w_status;

        [FieldOffset(0)]
        internal global::Wait._.__Internal __wait_terminated;

        [FieldOffset(0)]
        internal global::Wait.__.__Internal __wait_stopped;
    }

    public unsafe partial class _
    {
        [StructLayout(LayoutKind.Explicit, Size = 4)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal uint __w_termsig;

            [FieldOffset(0)]
            internal uint __w_coredump;

            [FieldOffset(1)]
            internal uint __w_retcode;

            [FieldOffset(2)]
            internal uint __;
        }
    }

    public unsafe partial class __
    {
        [StructLayout(LayoutKind.Explicit, Size = 4)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal uint __w_stopval;

            [FieldOffset(1)]
            internal uint __w_stopsig;

            [FieldOffset(2)]
            internal uint __;
        }
    }
}

namespace Std
{
    namespace Cxx11
    {
    }

    namespace Cxx11
    {
    }
}

namespace Std
{
    public unsafe partial class CowString
    {
        [StructLayout(LayoutKind.Explicit, Size = 8)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal global::Std.CowString._.__Internal _;
        }

        public unsafe partial struct _
        {
            [StructLayout(LayoutKind.Explicit, Size = 8)]
            public partial struct __Internal
            {
                [FieldOffset(0)]
                internal global::System.IntPtr _M_p;

                [FieldOffset(0)]
                internal fixed sbyte _M_bytes[8];
            }
        }
    }
}

namespace Std
{
    public unsafe partial class UsesAlloc0
    {
        [StructLayout(LayoutKind.Explicit, Size = 1)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal global::Std.UsesAlloc0.Sink.__Internal _M_a;
        }

        public unsafe partial class Sink
        {
            [StructLayout(LayoutKind.Explicit, Size = 0)]
            public partial struct __Internal
            {
            }
        }
    }
}

namespace Std
{
}

namespace Std
{
}

namespace Std
{
}
