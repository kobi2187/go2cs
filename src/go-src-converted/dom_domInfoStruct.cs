//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 06:03:16 UTC
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
using big = go.math.big_package;
using os = go.os_package;
using sort = go.sort_package;
using go;

#nullable enable

namespace go {
namespace golang.org {
namespace x {
namespace tools {
namespace go
{
    public static partial class ssa_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct domInfo
        {
            // Constructors
            public domInfo(NilType _)
            {
                this.idom = default;
                this.children = default;
                this.pre = default;
                this.post = default;
            }

            public domInfo(ref ptr<BasicBlock> idom = default, slice<ptr<BasicBlock>> children = default, int pre = default, int post = default)
            {
                this.idom = idom;
                this.children = children;
                this.pre = pre;
                this.post = post;
            }

            // Enable comparisons between nil and domInfo struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(domInfo value, NilType nil) => value.Equals(default(domInfo));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(domInfo value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, domInfo value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, domInfo value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator domInfo(NilType nil) => default(domInfo);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static domInfo domInfo_cast(dynamic value)
        {
            return new domInfo(ref value.idom, value.children, value.pre, value.post);
        }
    }
}}}}}