//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:04:33 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;


#nullable enable

namespace go
{
    public static partial class syscall_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Kevent_t
        {
            // Constructors
            public Kevent_t(NilType _)
            {
                this.Ident = default;
                this.Filter = default;
                this.Flags = default;
                this.Fflags = default;
                this.Pad_cgo_0 = default;
                this.Data = default;
                this.Udata = default;
            }

            public Kevent_t(ulong Ident = default, uint Filter = default, uint Flags = default, uint Fflags = default, array<byte> Pad_cgo_0 = default, long Data = default, long Udata = default)
            {
                this.Ident = Ident;
                this.Filter = Filter;
                this.Flags = Flags;
                this.Fflags = Fflags;
                this.Pad_cgo_0 = Pad_cgo_0;
                this.Data = Data;
                this.Udata = Udata;
            }

            // Enable comparisons between nil and Kevent_t struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Kevent_t value, NilType nil) => value.Equals(default(Kevent_t));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Kevent_t value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Kevent_t value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Kevent_t value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Kevent_t(NilType nil) => default(Kevent_t);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Kevent_t Kevent_t_cast(dynamic value)
        {
            return new Kevent_t(value.Ident, value.Filter, value.Flags, value.Fflags, value.Pad_cgo_0, value.Data, value.Udata);
        }
    }
}