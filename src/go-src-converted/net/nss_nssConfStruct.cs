//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:27:10 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using errors = go.errors_package;
using io = go.io_package;
using os = go.os_package;

namespace go
{
    public static partial class net_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct nssConf
        {
            // Constructors
            public nssConf(NilType _)
            {
                this.err = default;
                this.sources = default;
            }

            public nssConf(error err = default, map<@string, slice<nssSource>> sources = default)
            {
                this.err = err;
                this.sources = sources;
            }

            // Enable comparisons between nil and nssConf struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(nssConf value, NilType nil) => value.Equals(default(nssConf));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(nssConf value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, nssConf value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, nssConf value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator nssConf(NilType nil) => default(nssConf);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static nssConf nssConf_cast(dynamic value)
        {
            return new nssConf(value.err, value.sources);
        }
    }
}