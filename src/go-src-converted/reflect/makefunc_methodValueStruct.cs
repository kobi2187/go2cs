//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:06:35 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using @unsafe = go.@unsafe_package;

#nullable enable

namespace go
{
    public static partial class reflect_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct methodValue
        {
            // Constructors
            public methodValue(NilType _)
            {
                this.fn = default;
                this.stack = default;
                this.argLen = default;
                this.method = default;
                this.rcvr = default;
            }

            public methodValue(System.UIntPtr fn = default, ref ptr<bitVector> stack = default, System.UIntPtr argLen = default, long method = default, Value rcvr = default)
            {
                this.fn = fn;
                this.stack = stack;
                this.argLen = argLen;
                this.method = method;
                this.rcvr = rcvr;
            }

            // Enable comparisons between nil and methodValue struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(methodValue value, NilType nil) => value.Equals(default(methodValue));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(methodValue value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, methodValue value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, methodValue value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator methodValue(NilType nil) => default(methodValue);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static methodValue methodValue_cast(dynamic value)
        {
            return new methodValue(value.fn, ref value.stack, value.argLen, value.method, value.rcvr);
        }
    }
}