//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 04:49:20 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;

#nullable enable

namespace go
{
    public static partial class sort_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct IntSlice
        {
            // Value of the IntSlice struct
            private readonly slice<long> m_value;

            public IntSlice(slice<long> value) => m_value = value;

            // Enable implicit conversions between slice<long> and IntSlice struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator IntSlice(slice<long> value) => new IntSlice(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator slice<long>(IntSlice value) => value.m_value;
            
            // Enable comparisons between nil and IntSlice struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(IntSlice value, NilType nil) => value.Equals(default(IntSlice));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(IntSlice value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, IntSlice value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, IntSlice value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator IntSlice(NilType nil) => default(IntSlice);
        }
    }
}
