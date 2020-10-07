//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 10:04:48 UTC
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
using errors = go.errors_package;
using fmt = go.fmt_package;
using io = go.io_package;
using log = go.log_package;
using os = go.os_package;
using strconv = go.strconv_package;
using strings = go.strings_package;
using time = go.time_package;
using utf8 = go.unicode.utf8_package;

namespace go
{
    public static partial class main_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Archive
        {
            // Constructors
            public Archive(NilType _)
            {
                this.fd = default;
                this.files = default;
                this.pad = default;
                this.matchAll = default;
            }

            public Archive(ref ptr<os.File> fd = default, slice<@string> files = default, long pad = default, bool matchAll = default)
            {
                this.fd = fd;
                this.files = files;
                this.pad = pad;
                this.matchAll = matchAll;
            }

            // Enable comparisons between nil and Archive struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Archive value, NilType nil) => value.Equals(default(Archive));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Archive value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Archive value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Archive value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Archive(NilType nil) => default(Archive);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Archive Archive_cast(dynamic value)
        {
            return new Archive(ref value.fd, value.files, value.pad, value.matchAll);
        }
    }
}