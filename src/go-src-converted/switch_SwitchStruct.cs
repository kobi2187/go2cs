//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 06:03:53 UTC
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
using token = go.go.token_package;
using types = go.go.types_package;
using ssa = go.golang.org.x.tools.go.ssa_package;
using go;

#nullable enable

namespace go {
namespace golang.org {
namespace x {
namespace tools {
namespace go {
namespace ssa
{
    public static partial class ssautil_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Switch
        {
            // Constructors
            public Switch(NilType _)
            {
                this.Start = default;
                this.X = default;
                this.ConstCases = default;
                this.TypeCases = default;
                this.Default = default;
            }

            public Switch(ref ptr<ssa.BasicBlock> Start = default, ssa.Value X = default, slice<ConstCase> ConstCases = default, slice<TypeCase> TypeCases = default, ref ptr<ssa.BasicBlock> Default = default)
            {
                this.Start = Start;
                this.X = X;
                this.ConstCases = ConstCases;
                this.TypeCases = TypeCases;
                this.Default = Default;
            }

            // Enable comparisons between nil and Switch struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Switch value, NilType nil) => value.Equals(default(Switch));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Switch value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Switch value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Switch value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Switch(NilType nil) => default(Switch);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Switch Switch_cast(dynamic value)
        {
            return new Switch(ref value.Start, value.X, value.ConstCases, value.TypeCases, ref value.Default);
        }
    }
}}}}}}