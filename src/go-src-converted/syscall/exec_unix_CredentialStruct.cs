//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:37:02 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using runtime = go.runtime_package;
using sync = go.sync_package;
using @unsafe = go.@unsafe_package;

namespace go
{
    public static partial class syscall_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Credential
        {
            // Constructors
            public Credential(NilType _)
            {
                this.Uid = default;
                this.Gid = default;
                this.Groups = default;
                this.NoSetGroups = default;
            }

            public Credential(uint Uid = default, uint Gid = default, slice<uint> Groups = default, bool NoSetGroups = default)
            {
                this.Uid = Uid;
                this.Gid = Gid;
                this.Groups = Groups;
                this.NoSetGroups = NoSetGroups;
            }

            // Enable comparisons between nil and Credential struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Credential value, NilType nil) => value.Equals(default(Credential));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Credential value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Credential value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Credential value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Credential(NilType nil) => default(Credential);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Credential Credential_cast(dynamic value)
        {
            return new Credential(value.Uid, value.Gid, value.Groups, value.NoSetGroups);
        }
    }
}