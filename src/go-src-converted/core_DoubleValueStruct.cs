//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 06:01:50 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

using go;

#nullable enable

namespace go {
namespace golang.org {
namespace x {
namespace tools {
namespace @internal {
namespace @event {
namespace export {
namespace ocagent
{
    public static partial class wire_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct DoubleValue
        {
            // Constructors
            public DoubleValue(NilType _)
            {
                this.Value = default;
            }

            public DoubleValue(double Value = default)
            {
                this.Value = Value;
            }

            // Enable comparisons between nil and DoubleValue struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(DoubleValue value, NilType nil) => value.Equals(default(DoubleValue));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(DoubleValue value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, DoubleValue value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, DoubleValue value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator DoubleValue(NilType nil) => default(DoubleValue);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static DoubleValue DoubleValue_cast(dynamic value)
        {
            return new DoubleValue(value.Value);
        }
    }
}}}}}}}}