//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:16:12 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

using go;

namespace go {
namespace unicode
{
    public static partial class utf8_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct acceptRange
        {
            // Constructors
            public acceptRange(NilType _)
            {
                this.lo = default;
                this.hi = default;
            }

            public acceptRange(byte lo = default, byte hi = default)
            {
                this.lo = lo;
                this.hi = hi;
            }

            // Enable comparisons between nil and acceptRange struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(acceptRange value, NilType nil) => value.Equals(default(acceptRange));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(acceptRange value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, acceptRange value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, acceptRange value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator acceptRange(NilType nil) => default(acceptRange);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static acceptRange acceptRange_cast(dynamic value)
        {
            return new acceptRange(value.lo, value.hi);
        }
    }
}}