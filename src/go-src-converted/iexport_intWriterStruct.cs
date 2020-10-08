//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:55:32 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using bytes = go.bytes_package;
using binary = go.encoding.binary_package;
using ast = go.go.ast_package;
using constant = go.go.constant_package;
using token = go.go.token_package;
using types = go.go.types_package;
using io = go.io_package;
using big = go.math.big_package;
using reflect = go.reflect_package;
using sort = go.sort_package;
using go;

namespace go {
namespace golang.org {
namespace x {
namespace tools {
namespace go {
namespace @internal
{
    public static partial class gcimporter_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        [PromotedStruct(typeof(bytes.Buffer))]
        private partial struct intWriter
        {
            // Buffer structure promotion - sourced from value copy
            private readonly ptr<Buffer> m_BufferRef;

            private ref Buffer Buffer_val => ref m_BufferRef.Value;

            public ref slice<byte> buf => ref m_BufferRef.Value.buf;

            public ref long off => ref m_BufferRef.Value.off;

            public ref readOp lastRead => ref m_BufferRef.Value.lastRead;

            // Constructors
            public intWriter(NilType _)
            {
                this.m_BufferRef = new ptr<bytes.Buffer>(new bytes.Buffer(nil));
            }

            public intWriter(bytes.Buffer Buffer = default)
            {
                this.m_BufferRef = new ptr<bytes.Buffer>(Buffer);
            }

            // Enable comparisons between nil and intWriter struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(intWriter value, NilType nil) => value.Equals(default(intWriter));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(intWriter value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, intWriter value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, intWriter value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator intWriter(NilType nil) => default(intWriter);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static intWriter intWriter_cast(dynamic value)
        {
            return new intWriter(value.Buffer);
        }
    }
}}}}}}