//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:45:43 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using go;

namespace go {
namespace cmd {
namespace vendor {
namespace golang.org {
namespace x {
namespace crypto {
namespace ssh
{
    public static partial class terminal_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct passwordReader
        {
            // Value of the passwordReader struct
            private readonly long m_value;

            public passwordReader(long value) => m_value = value;

            // Enable implicit conversions between long and passwordReader struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator passwordReader(long value) => new passwordReader(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator long(passwordReader value) => value.m_value;
            
            // Enable comparisons between nil and passwordReader struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(passwordReader value, NilType nil) => value.Equals(default(passwordReader));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(passwordReader value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, passwordReader value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, passwordReader value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator passwordReader(NilType nil) => default(passwordReader);
        }
    }
}}}}}}}