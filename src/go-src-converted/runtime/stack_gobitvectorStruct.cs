//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:20:57 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using atomic = go.runtime.@internal.atomic_package;
using sys = go.runtime.@internal.sys_package;
using @unsafe = go.@unsafe_package;

namespace go
{
    public static partial class runtime_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct gobitvector
        {
            // Constructors
            public gobitvector(NilType _)
            {
                this.n = default;
                this.bytedata = default;
            }

            public gobitvector(System.UIntPtr n = default, slice<byte> bytedata = default)
            {
                this.n = n;
                this.bytedata = bytedata;
            }

            // Enable comparisons between nil and gobitvector struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(gobitvector value, NilType nil) => value.Equals(default(gobitvector));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(gobitvector value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, gobitvector value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, gobitvector value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator gobitvector(NilType nil) => default(gobitvector);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static gobitvector gobitvector_cast(dynamic value)
        {
            return new gobitvector(value.n, value.bytedata);
        }
    }
}