//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:44:58 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using fmt = go.fmt_package;
using ast = go.go.ast_package;
using parser = go.go.parser_package;
using token = go.go.token_package;
using os = go.os_package;
using path = go.path_package;
using reflect = go.reflect_package;
using strconv = go.strconv_package;
using strings = go.strings_package;

#nullable enable

namespace go
{
    public static partial class main_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct rename
        {
            // Constructors
            public rename(NilType _)
            {
                this.OldImport = default;
                this.NewImport = default;
                this.Old = default;
                this.New = default;
            }

            public rename(@string OldImport = default, @string NewImport = default, @string Old = default, @string New = default)
            {
                this.OldImport = OldImport;
                this.NewImport = NewImport;
                this.Old = Old;
                this.New = New;
            }

            // Enable comparisons between nil and rename struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(rename value, NilType nil) => value.Equals(default(rename));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(rename value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, rename value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, rename value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator rename(NilType nil) => default(rename);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static rename rename_cast(dynamic value)
        {
            return new rename(value.OldImport, value.NewImport, value.Old, value.New);
        }
    }
}