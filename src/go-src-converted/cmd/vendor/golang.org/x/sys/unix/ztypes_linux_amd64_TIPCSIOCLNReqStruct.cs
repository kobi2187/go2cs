//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 06:00:35 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

using go;

#nullable enable

namespace go {
namespace cmd {
namespace vendor {
namespace golang.org {
namespace x {
namespace sys
{
    public static partial class unix_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct TIPCSIOCLNReq
        {
            // Constructors
            public TIPCSIOCLNReq(NilType _)
            {
                this.Peer = default;
                this.Id = default;
                this.Linkname = default;
            }

            public TIPCSIOCLNReq(uint Peer = default, uint Id = default, array<sbyte> Linkname = default)
            {
                this.Peer = Peer;
                this.Id = Id;
                this.Linkname = Linkname;
            }

            // Enable comparisons between nil and TIPCSIOCLNReq struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(TIPCSIOCLNReq value, NilType nil) => value.Equals(default(TIPCSIOCLNReq));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(TIPCSIOCLNReq value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, TIPCSIOCLNReq value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, TIPCSIOCLNReq value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator TIPCSIOCLNReq(NilType nil) => default(TIPCSIOCLNReq);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static TIPCSIOCLNReq TIPCSIOCLNReq_cast(dynamic value)
        {
            return new TIPCSIOCLNReq(value.Peer, value.Id, value.Linkname);
        }
    }
}}}}}}