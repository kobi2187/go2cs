//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:04:34 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;

#nullable enable

namespace go
{
    public static partial class syscall_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Mclpool
        {
            // Value of the Mclpool struct
            private readonly array<byte> m_value;

            public Mclpool(array<byte> value) => m_value = value;

            // Enable implicit conversions between array<byte> and Mclpool struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Mclpool(array<byte> value) => new Mclpool(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator array<byte>(Mclpool value) => value.m_value;
            
            // Enable comparisons between nil and Mclpool struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Mclpool value, NilType nil) => value.Equals(default(Mclpool));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Mclpool value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Mclpool value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Mclpool value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Mclpool(NilType nil) => default(Mclpool);
        }
    }
}
