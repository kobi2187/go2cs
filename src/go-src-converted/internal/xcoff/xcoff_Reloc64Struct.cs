//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:02:16 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

using go;

namespace go {
namespace @internal
{
    public static partial class xcoff_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Reloc64
        {
            // Constructors
            public Reloc64(NilType _)
            {
                this.Rvaddr = default;
                this.Rsymndx = default;
                this.Rsize = default;
                this.Rtype = default;
            }

            public Reloc64(ulong Rvaddr = default, uint Rsymndx = default, byte Rsize = default, byte Rtype = default)
            {
                this.Rvaddr = Rvaddr;
                this.Rsymndx = Rsymndx;
                this.Rsize = Rsize;
                this.Rtype = Rtype;
            }

            // Enable comparisons between nil and Reloc64 struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Reloc64 value, NilType nil) => value.Equals(default(Reloc64));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Reloc64 value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Reloc64 value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Reloc64 value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Reloc64(NilType nil) => default(Reloc64);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Reloc64 Reloc64_cast(dynamic value)
        {
            return new Reloc64(value.Rvaddr, value.Rsymndx, value.Rsize, value.Rtype);
        }
    }
}}