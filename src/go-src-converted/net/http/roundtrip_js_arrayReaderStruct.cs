//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 04:57:53 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using errors = go.errors_package;
using fmt = go.fmt_package;
using io = go.io_package;
using ioutil = go.io.ioutil_package;
using strconv = go.strconv_package;
using js = go.syscall.js_package;
using go;

#nullable enable

namespace go {
namespace net
{
    public static partial class http_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct arrayReader
        {
            // Constructors
            public arrayReader(NilType _)
            {
                this.arrayPromise = default;
                this.pending = default;
                this.read = default;
                this.err = default;
            }

            public arrayReader(js.Value arrayPromise = default, slice<byte> pending = default, bool read = default, error err = default)
            {
                this.arrayPromise = arrayPromise;
                this.pending = pending;
                this.read = read;
                this.err = err;
            }

            // Enable comparisons between nil and arrayReader struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(arrayReader value, NilType nil) => value.Equals(default(arrayReader));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(arrayReader value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, arrayReader value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, arrayReader value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator arrayReader(NilType nil) => default(arrayReader);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static arrayReader arrayReader_cast(dynamic value)
        {
            return new arrayReader(value.arrayPromise, value.pending, value.read, value.err);
        }
    }
}}