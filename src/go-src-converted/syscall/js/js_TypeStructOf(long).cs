//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 04:53:05 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using go;

#nullable enable

namespace go {
namespace syscall
{
    public static partial class js_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Type
        {
            // Value of the Type struct
            private readonly long m_value;

            public Type(long value) => m_value = value;

            // Enable implicit conversions between long and Type struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Type(long value) => new Type(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator long(Type value) => value.m_value;
            
            // Enable comparisons between nil and Type struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Type value, NilType nil) => value.Equals(default(Type));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Type value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Type value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Type value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Type(NilType nil) => default(Type);
        }
    }
}}
