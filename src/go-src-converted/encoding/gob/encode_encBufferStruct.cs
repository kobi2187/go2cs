//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 04:59:55 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using encoding = go.encoding_package;
using binary = go.encoding.binary_package;
using math = go.math_package;
using bits = go.math.bits_package;
using reflect = go.reflect_package;
using sync = go.sync_package;
using go;

#nullable enable

namespace go {
namespace encoding
{
    public static partial class gob_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct encBuffer
        {
            // Constructors
            public encBuffer(NilType _)
            {
                this.data = default;
                this.scratch = default;
            }

            public encBuffer(slice<byte> data = default, array<byte> scratch = default)
            {
                this.data = data;
                this.scratch = scratch;
            }

            // Enable comparisons between nil and encBuffer struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(encBuffer value, NilType nil) => value.Equals(default(encBuffer));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(encBuffer value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, encBuffer value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, encBuffer value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator encBuffer(NilType nil) => default(encBuffer);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static encBuffer encBuffer_cast(dynamic value)
        {
            return new encBuffer(value.data, value.scratch);
        }
    }
}}