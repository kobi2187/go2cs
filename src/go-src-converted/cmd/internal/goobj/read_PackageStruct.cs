//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:46:18 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using bufio = go.bufio_package;
using bytes = go.bytes_package;
using objabi = go.cmd.@internal.objabi_package;
using errors = go.errors_package;
using fmt = go.fmt_package;
using io = go.io_package;
using os = go.os_package;
using strconv = go.strconv_package;
using strings = go.strings_package;
using go;

namespace go {
namespace cmd {
namespace @internal
{
    public static partial class goobj_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Package
        {
            // Constructors
            public Package(NilType _)
            {
                this.ImportPath = default;
                this.Imports = default;
                this.SymRefs = default;
                this.Syms = default;
                this.MaxVersion = default;
                this.Arch = default;
                this.Native = default;
            }

            public Package(@string ImportPath = default, slice<@string> Imports = default, slice<SymID> SymRefs = default, slice<ref Sym> Syms = default, long MaxVersion = default, @string Arch = default, slice<ref NativeReader> Native = default)
            {
                this.ImportPath = ImportPath;
                this.Imports = Imports;
                this.SymRefs = SymRefs;
                this.Syms = Syms;
                this.MaxVersion = MaxVersion;
                this.Arch = Arch;
                this.Native = Native;
            }

            // Enable comparisons between nil and Package struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Package value, NilType nil) => value.Equals(default(Package));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Package value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Package value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Package value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Package(NilType nil) => default(Package);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Package Package_cast(dynamic value)
        {
            return new Package(value.ImportPath, value.Imports, value.SymRefs, value.Syms, value.MaxVersion, value.Arch, value.Native);
        }
    }
}}}