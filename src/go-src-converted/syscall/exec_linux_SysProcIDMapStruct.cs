//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:01:16 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using runtime = go.runtime_package;
using @unsafe = go.@unsafe_package;

#nullable enable

namespace go
{
    public static partial class syscall_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct SysProcIDMap
        {
            // Constructors
            public SysProcIDMap(NilType _)
            {
                this.ContainerID = default;
                this.HostID = default;
                this.Size = default;
            }

            public SysProcIDMap(long ContainerID = default, long HostID = default, long Size = default)
            {
                this.ContainerID = ContainerID;
                this.HostID = HostID;
                this.Size = Size;
            }

            // Enable comparisons between nil and SysProcIDMap struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(SysProcIDMap value, NilType nil) => value.Equals(default(SysProcIDMap));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(SysProcIDMap value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, SysProcIDMap value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, SysProcIDMap value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator SysProcIDMap(NilType nil) => default(SysProcIDMap);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static SysProcIDMap SysProcIDMap_cast(dynamic value)
        {
            return new SysProcIDMap(value.ContainerID, value.HostID, value.Size);
        }
    }
}