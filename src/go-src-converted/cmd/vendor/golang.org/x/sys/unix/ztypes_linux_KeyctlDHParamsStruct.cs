//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 06:00:33 UTC
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
        public partial struct KeyctlDHParams
        {
            // Constructors
            public KeyctlDHParams(NilType _)
            {
                this.Private = default;
                this.Prime = default;
                this.Base = default;
            }

            public KeyctlDHParams(int Private = default, int Prime = default, int Base = default)
            {
                this.Private = Private;
                this.Prime = Prime;
                this.Base = Base;
            }

            // Enable comparisons between nil and KeyctlDHParams struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(KeyctlDHParams value, NilType nil) => value.Equals(default(KeyctlDHParams));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(KeyctlDHParams value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, KeyctlDHParams value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, KeyctlDHParams value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator KeyctlDHParams(NilType nil) => default(KeyctlDHParams);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static KeyctlDHParams KeyctlDHParams_cast(dynamic value)
        {
            return new KeyctlDHParams(value.Private, value.Prime, value.Base);
        }
    }
}}}}}}