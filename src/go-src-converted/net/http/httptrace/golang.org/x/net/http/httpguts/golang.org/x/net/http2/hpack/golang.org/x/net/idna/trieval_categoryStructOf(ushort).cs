//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 04:57:41 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using go;

#nullable enable

namespace go {
namespace golang.org {
namespace x {
namespace net
{
    public static partial class idna_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct category
        {
            // Value of the category struct
            private readonly ushort m_value;

            public category(ushort value) => m_value = value;

            // Enable implicit conversions between ushort and category struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator category(ushort value) => new category(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator ushort(category value) => value.m_value;
            
            // Enable comparisons between nil and category struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(category value, NilType nil) => value.Equals(default(category));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(category value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, category value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, category value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator category(NilType nil) => default(category);
        }
    }
}}}}
