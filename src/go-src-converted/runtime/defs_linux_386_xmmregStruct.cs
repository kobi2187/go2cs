//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 04:45:50 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;


#nullable enable

namespace go
{
    public static partial class runtime_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct xmmreg
        {
            // Constructors
            public xmmreg(NilType _)
            {
                this.element = default;
            }

            public xmmreg(array<uint> element = default)
            {
                this.element = element;
            }

            // Enable comparisons between nil and xmmreg struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(xmmreg value, NilType nil) => value.Equals(default(xmmreg));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(xmmreg value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, xmmreg value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, xmmreg value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator xmmreg(NilType nil) => default(xmmreg);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static xmmreg xmmreg_cast(dynamic value)
        {
            return new xmmreg(value.element);
        }
    }
}