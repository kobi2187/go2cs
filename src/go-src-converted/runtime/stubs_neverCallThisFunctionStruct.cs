//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 04:48:47 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using @unsafe = go.@unsafe_package;

#nullable enable

namespace go
{
    public static partial class runtime_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct neverCallThisFunction
        {
            // Constructors
            public neverCallThisFunction(NilType _)
            {
            }
            // Enable comparisons between nil and neverCallThisFunction struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(neverCallThisFunction value, NilType nil) => value.Equals(default(neverCallThisFunction));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(neverCallThisFunction value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, neverCallThisFunction value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, neverCallThisFunction value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator neverCallThisFunction(NilType nil) => default(neverCallThisFunction);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static neverCallThisFunction neverCallThisFunction_cast(dynamic value)
        {
            return new neverCallThisFunction();
        }
    }
}