//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 04:46:33 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;

#nullable enable

namespace go
{
    public static partial class runtime_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct memHdrPtr
        {
            // Value of the memHdrPtr struct
            private readonly System.UIntPtr m_value;

            public memHdrPtr(System.UIntPtr value) => m_value = value;

            // Enable implicit conversions between System.UIntPtr and memHdrPtr struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator memHdrPtr(System.UIntPtr value) => new memHdrPtr(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator System.UIntPtr(memHdrPtr value) => value.m_value;
            
            // Enable comparisons between nil and memHdrPtr struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(memHdrPtr value, NilType nil) => value.Equals(default(memHdrPtr));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(memHdrPtr value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, memHdrPtr value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, memHdrPtr value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator memHdrPtr(NilType nil) => default(memHdrPtr);
        }
    }
}
