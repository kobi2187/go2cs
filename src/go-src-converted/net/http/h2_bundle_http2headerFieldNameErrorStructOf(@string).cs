//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:33:17 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using go;

namespace go {
namespace net
{
    public static partial class http_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct http2headerFieldNameError
        {
            // Value of the http2headerFieldNameError struct
            private readonly @string m_value;

            public http2headerFieldNameError(@string value) => m_value = value;

            // Enable implicit conversions between @string and http2headerFieldNameError struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator http2headerFieldNameError(@string value) => new http2headerFieldNameError(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator @string(http2headerFieldNameError value) => value.m_value;
            
            // Enable comparisons between nil and http2headerFieldNameError struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(http2headerFieldNameError value, NilType nil) => value.Equals(default(http2headerFieldNameError));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(http2headerFieldNameError value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, http2headerFieldNameError value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, http2headerFieldNameError value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator http2headerFieldNameError(NilType nil) => default(http2headerFieldNameError);
        }
    }
}}