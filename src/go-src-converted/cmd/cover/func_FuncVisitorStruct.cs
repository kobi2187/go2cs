//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 09:59:27 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using bufio = go.bufio_package;
using fmt = go.fmt_package;
using ast = go.go.ast_package;
using build = go.go.build_package;
using parser = go.go.parser_package;
using token = go.go.token_package;
using os = go.os_package;
using filepath = go.path.filepath_package;
using tabwriter = go.text.tabwriter_package;

namespace go
{
    public static partial class main_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct FuncVisitor
        {
            // Constructors
            public FuncVisitor(NilType _)
            {
                this.fset = default;
                this.name = default;
                this.astFile = default;
                this.funcs = default;
            }

            public FuncVisitor(ref ptr<token.FileSet> fset = default, @string name = default, ref ptr<ast.File> astFile = default, slice<ref FuncExtent> funcs = default)
            {
                this.fset = fset;
                this.name = name;
                this.astFile = astFile;
                this.funcs = funcs;
            }

            // Enable comparisons between nil and FuncVisitor struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(FuncVisitor value, NilType nil) => value.Equals(default(FuncVisitor));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(FuncVisitor value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, FuncVisitor value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, FuncVisitor value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator FuncVisitor(NilType nil) => default(FuncVisitor);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static FuncVisitor FuncVisitor_cast(dynamic value)
        {
            return new FuncVisitor(ref value.fset, value.name, ref value.astFile, value.funcs);
        }
    }
}