//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 04:59:15 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using go;

#nullable enable

namespace go {
namespace html
{
    public static partial class template_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct ErrorCode
        {
            // Value of the ErrorCode struct
            private readonly long m_value;

            public ErrorCode(long value) => m_value = value;

            // Enable implicit conversions between long and ErrorCode struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator ErrorCode(long value) => new ErrorCode(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator long(ErrorCode value) => value.m_value;
            
            // Enable comparisons between nil and ErrorCode struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(ErrorCode value, NilType nil) => value.Equals(default(ErrorCode));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(ErrorCode value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, ErrorCode value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, ErrorCode value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator ErrorCode(NilType nil) => default(ErrorCode);
        }
    }
}}
