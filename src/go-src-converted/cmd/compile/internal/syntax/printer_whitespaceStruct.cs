//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 09:26:23 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using bytes = go.bytes_package;
using fmt = go.fmt_package;
using io = go.io_package;
using strings = go.strings_package;
using go;

namespace go {
namespace cmd {
namespace compile {
namespace @internal
{
    public static partial class syntax_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct whitespace
        {
            // Constructors
            public whitespace(NilType _)
            {
                this.last = default;
                this.kind = default;
            }

            public whitespace(token last = default, ctrlSymbol kind = default)
            {
                this.last = last;
                this.kind = kind;
            }

            // Enable comparisons between nil and whitespace struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(whitespace value, NilType nil) => value.Equals(default(whitespace));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(whitespace value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, whitespace value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, whitespace value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator whitespace(NilType nil) => default(whitespace);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static whitespace whitespace_cast(dynamic value)
        {
            return new whitespace(value.last, value.kind);
        }
    }
}}}}