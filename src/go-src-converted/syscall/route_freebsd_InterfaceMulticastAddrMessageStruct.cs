//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:01:29 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using @unsafe = go.@unsafe_package;

#nullable enable

namespace go
{
    public static partial class syscall_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct InterfaceMulticastAddrMessage
        {
            // Constructors
            public InterfaceMulticastAddrMessage(NilType _)
            {
                this.Header = default;
                this.Data = default;
            }

            public InterfaceMulticastAddrMessage(IfmaMsghdr Header = default, slice<byte> Data = default)
            {
                this.Header = Header;
                this.Data = Data;
            }

            // Enable comparisons between nil and InterfaceMulticastAddrMessage struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(InterfaceMulticastAddrMessage value, NilType nil) => value.Equals(default(InterfaceMulticastAddrMessage));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(InterfaceMulticastAddrMessage value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, InterfaceMulticastAddrMessage value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, InterfaceMulticastAddrMessage value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator InterfaceMulticastAddrMessage(NilType nil) => default(InterfaceMulticastAddrMessage);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static InterfaceMulticastAddrMessage InterfaceMulticastAddrMessage_cast(dynamic value)
        {
            return new InterfaceMulticastAddrMessage(value.Header, value.Data);
        }
    }
}