//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 06:00:27 UTC
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
namespace cmd {
namespace vendor {
namespace golang.org {
namespace x {
namespace sys
{
    public static partial class unix_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Stat_t
        {
            // Constructors
            public Stat_t(NilType _)
            {
                this.Dev = default;
                this.Ino = default;
                this.Mode = default;
                this.Nlink = default;
                this.Flag = default;
                this.Uid = default;
                this.Gid = default;
                this.Rdev = default;
                this.Ssize = default;
                this.Atim = default;
                this.Mtim = default;
                this.Ctim = default;
                this.Blksize = default;
                this.Blocks = default;
                this.Vfstype = default;
                this.Vfs = default;
                this.Type = default;
                this.Gen = default;
                this.Reserved = default;
                this.Padto_ll = default;
                this.Size = default;
            }

            public Stat_t(ulong Dev = default, ulong Ino = default, uint Mode = default, short Nlink = default, ushort Flag = default, uint Uid = default, uint Gid = default, ulong Rdev = default, int Ssize = default, Timespec Atim = default, Timespec Mtim = default, Timespec Ctim = default, long Blksize = default, long Blocks = default, int Vfstype = default, uint Vfs = default, uint Type = default, uint Gen = default, array<uint> Reserved = default, uint Padto_ll = default, long Size = default)
            {
                this.Dev = Dev;
                this.Ino = Ino;
                this.Mode = Mode;
                this.Nlink = Nlink;
                this.Flag = Flag;
                this.Uid = Uid;
                this.Gid = Gid;
                this.Rdev = Rdev;
                this.Ssize = Ssize;
                this.Atim = Atim;
                this.Mtim = Mtim;
                this.Ctim = Ctim;
                this.Blksize = Blksize;
                this.Blocks = Blocks;
                this.Vfstype = Vfstype;
                this.Vfs = Vfs;
                this.Type = Type;
                this.Gen = Gen;
                this.Reserved = Reserved;
                this.Padto_ll = Padto_ll;
                this.Size = Size;
            }

            // Enable comparisons between nil and Stat_t struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Stat_t value, NilType nil) => value.Equals(default(Stat_t));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Stat_t value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Stat_t value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Stat_t value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Stat_t(NilType nil) => default(Stat_t);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Stat_t Stat_t_cast(dynamic value)
        {
            return new Stat_t(value.Dev, value.Ino, value.Mode, value.Nlink, value.Flag, value.Uid, value.Gid, value.Rdev, value.Ssize, value.Atim, value.Mtim, value.Ctim, value.Blksize, value.Blocks, value.Vfstype, value.Vfs, value.Type, value.Gen, value.Reserved, value.Padto_ll, value.Size);
        }
    }
}}}}}}