//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 04:47:18 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using atomic = go.runtime.@internal.atomic_package;
using @unsafe = go.@unsafe_package;

#nullable enable

namespace go
{
    public static partial class runtime_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct net_op
        {
            // Constructors
            public net_op(NilType _)
            {
                this.o = default;
                this.pd = default;
                this.mode = default;
                this.errno = default;
                this.qty = default;
            }

            public net_op(overlapped o = default, ref ptr<pollDesc> pd = default, int mode = default, int errno = default, uint qty = default)
            {
                this.o = o;
                this.pd = pd;
                this.mode = mode;
                this.errno = errno;
                this.qty = qty;
            }

            // Enable comparisons between nil and net_op struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(net_op value, NilType nil) => value.Equals(default(net_op));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(net_op value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, net_op value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, net_op value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator net_op(NilType nil) => default(net_op);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static net_op net_op_cast(dynamic value)
        {
            return new net_op(value.o, ref value.pd, value.mode, value.errno, value.qty);
        }
    }
}