//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:20:07 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using go;

#nullable enable

namespace go {
namespace cmd {
namespace api {
namespace testdata {
namespace src {
namespace pkg
{
    public static partial class p1_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct MyInt
        {
            // Value of the MyInt struct
            private readonly long m_value;

            public MyInt(long value) => m_value = value;

            // Enable implicit conversions between long and MyInt struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator MyInt(long value) => new MyInt(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator long(MyInt value) => value.m_value;
            
            // Enable comparisons between nil and MyInt struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(MyInt value, NilType nil) => value.Equals(default(MyInt));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(MyInt value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, MyInt value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, MyInt value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator MyInt(NilType nil) => default(MyInt);
        }
    }
}}}}}}
