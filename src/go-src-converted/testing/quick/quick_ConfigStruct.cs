//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 10:06:01 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using flag = go.flag_package;
using fmt = go.fmt_package;
using math = go.math_package;
using rand = go.math.rand_package;
using reflect = go.reflect_package;
using strings = go.strings_package;
using time = go.time_package;
using go;

namespace go {
namespace testing
{
    public static partial class quick_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Config
        {
            // Constructors
            public Config(NilType _)
            {
                this.MaxCount = default;
                this.MaxCountScale = default;
                this.Rand = default;
                this.Values = default;
            }

            public Config(long MaxCount = default, double MaxCountScale = default, ref ptr<rand.Rand> Rand = default, Action<slice<reflect.Value>, ref rand.Rand> Values = default)
            {
                this.MaxCount = MaxCount;
                this.MaxCountScale = MaxCountScale;
                this.Rand = Rand;
                this.Values = Values;
            }

            // Enable comparisons between nil and Config struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Config value, NilType nil) => value.Equals(default(Config));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Config value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Config value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Config value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Config(NilType nil) => default(Config);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Config Config_cast(dynamic value)
        {
            return new Config(value.MaxCount, value.MaxCountScale, ref value.Rand, value.Values);
        }
    }
}}