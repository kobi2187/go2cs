//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 04:48:09 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using cpu = go.@internal.cpu_package;
using atomic = go.runtime.@internal.atomic_package;
using sys = go.runtime.@internal.sys_package;
using @unsafe = go.@unsafe_package;

#nullable enable

namespace go
{
    public static partial class runtime_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct wincallbackcontext
        {
            // Constructors
            public wincallbackcontext(NilType _)
            {
                this.gobody = default;
                this.argsize = default;
                this.restorestack = default;
                this.cleanstack = default;
            }

            public wincallbackcontext(unsafe.Pointer gobody = default, System.UIntPtr argsize = default, System.UIntPtr restorestack = default, bool cleanstack = default)
            {
                this.gobody = gobody;
                this.argsize = argsize;
                this.restorestack = restorestack;
                this.cleanstack = cleanstack;
            }

            // Enable comparisons between nil and wincallbackcontext struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(wincallbackcontext value, NilType nil) => value.Equals(default(wincallbackcontext));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(wincallbackcontext value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, wincallbackcontext value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, wincallbackcontext value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator wincallbackcontext(NilType nil) => default(wincallbackcontext);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static wincallbackcontext wincallbackcontext_cast(dynamic value)
        {
            return new wincallbackcontext(value.gobody, value.argsize, value.restorestack, value.cleanstack);
        }
    }
}