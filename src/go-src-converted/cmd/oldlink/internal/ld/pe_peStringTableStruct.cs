//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:52:33 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using objabi = go.cmd.@internal.objabi_package;
using sys = go.cmd.@internal.sys_package;
using sym = go.cmd.oldlink.@internal.sym_package;
using pe = go.debug.pe_package;
using binary = go.encoding.binary_package;
using fmt = go.fmt_package;
using sort = go.sort_package;
using strconv = go.strconv_package;
using strings = go.strings_package;
using go;

#nullable enable

namespace go {
namespace cmd {
namespace oldlink {
namespace @internal
{
    public static partial class ld_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct peStringTable
        {
            // Constructors
            public peStringTable(NilType _)
            {
                this.strings = default;
                this.stringsLen = default;
            }

            public peStringTable(slice<@string> strings = default, long stringsLen = default)
            {
                this.strings = strings;
                this.stringsLen = stringsLen;
            }

            // Enable comparisons between nil and peStringTable struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(peStringTable value, NilType nil) => value.Equals(default(peStringTable));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(peStringTable value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, peStringTable value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, peStringTable value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator peStringTable(NilType nil) => default(peStringTable);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static peStringTable peStringTable_cast(dynamic value)
        {
            return new peStringTable(value.strings, value.stringsLen);
        }
    }
}}}}