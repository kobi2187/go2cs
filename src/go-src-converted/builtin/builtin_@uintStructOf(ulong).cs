//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:08:14 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;

#nullable enable

namespace go
{
    public static partial class builtin_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct @uint
        {
            // Value of the @uint struct
            private readonly ulong m_value;

            public @uint(ulong value) => m_value = value;

            // Enable implicit conversions between ulong and @uint struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator @uint(ulong value) => new @uint(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator ulong(@uint value) => value.m_value;
            
            // Enable comparisons between nil and @uint struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(@uint value, NilType nil) => value.Equals(default(@uint));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(@uint value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, @uint value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, @uint value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator @uint(NilType nil) => default(@uint);
        }
    }
}
