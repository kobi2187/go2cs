//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 04:58:36 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using io = go.io_package;
using syntax = go.regexp.syntax_package;
using sync = go.sync_package;

#nullable enable

namespace go
{
    public static partial class regexp_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct onePassMachine
        {
            // Constructors
            public onePassMachine(NilType _)
            {
                this.inputs = default;
                this.matchcap = default;
            }

            public onePassMachine(inputs inputs = default, slice<long> matchcap = default)
            {
                this.inputs = inputs;
                this.matchcap = matchcap;
            }

            // Enable comparisons between nil and onePassMachine struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(onePassMachine value, NilType nil) => value.Equals(default(onePassMachine));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(onePassMachine value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, onePassMachine value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, onePassMachine value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator onePassMachine(NilType nil) => default(onePassMachine);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static onePassMachine onePassMachine_cast(dynamic value)
        {
            return new onePassMachine(value.inputs, value.matchcap);
        }
    }
}