//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 09:58:24 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;

namespace go
{
    public static partial class main_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct B
        {
            // Value of the B struct
            private readonly array<long> m_value;

            public B(array<long> value) => m_value = value;

            // Enable implicit conversions between array<long> and B struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator B(array<long> value) => new B(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator array<long>(B value) => value.m_value;
            
            // Enable comparisons between nil and B struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(B value, NilType nil) => value.Equals(default(B));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(B value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, B value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, B value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator B(NilType nil) => default(B);
        }
    }
}