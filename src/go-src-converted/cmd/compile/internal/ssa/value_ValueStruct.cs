//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:39:39 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using types = go.cmd.compile.@internal.types_package;
using src = go.cmd.@internal.src_package;
using fmt = go.fmt_package;
using math = go.math_package;
using sort = go.sort_package;
using strings = go.strings_package;
using go;

#nullable enable

namespace go {
namespace cmd {
namespace compile {
namespace @internal
{
    public static partial class ssa_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Value
        {
            // Constructors
            public Value(NilType _)
            {
                this.ID = default;
                this.Op = default;
                this.Type = default;
                this.AuxInt = default;
                this.Args = default;
                this.Block = default;
                this.Pos = default;
                this.Uses = default;
                this.OnWasmStack = default;
                this.argstorage = default;
            }

            public Value(ID ID = default, Op Op = default, ref ptr<types.Type> Type = default, long AuxInt = default, slice<ptr<Value>> Args = default, ref ptr<Block> Block = default, src.XPos Pos = default, int Uses = default, bool OnWasmStack = default, array<ptr<Value>> argstorage = default)
            {
                this.ID = ID;
                this.Op = Op;
                this.Type = Type;
                this.AuxInt = AuxInt;
                this.Args = Args;
                this.Block = Block;
                this.Pos = Pos;
                this.Uses = Uses;
                this.OnWasmStack = OnWasmStack;
                this.argstorage = argstorage;
            }

            // Enable comparisons between nil and Value struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Value value, NilType nil) => value.Equals(default(Value));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Value value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Value value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Value value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Value(NilType nil) => default(Value);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Value Value_cast(dynamic value)
        {
            return new Value(value.ID, value.Op, ref value.Type, value.AuxInt, value.Args, ref value.Block, value.Pos, value.Uses, value.OnWasmStack, value.argstorage);
        }
    }
}}}}