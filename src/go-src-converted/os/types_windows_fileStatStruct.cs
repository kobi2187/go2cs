//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:44:40 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using sync = go.sync_package;
using syscall = go.syscall_package;
using time = go.time_package;

namespace go
{
    public static partial class os_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        [PromotedStruct(typeof(sync.Mutex))]
        private partial struct fileStat
        {
            // Mutex structure promotion - sourced from value copy
            private readonly ptr<Mutex> m_MutexRef;

            private ref Mutex Mutex_val => ref m_MutexRef.Value;

            public ref int state => ref m_MutexRef.Value.state;

            public ref uint sema => ref m_MutexRef.Value.sema;

            // Constructors
            public fileStat(NilType _)
            {
                this.name = default;
                this.sys = default;
                this.filetype = default;
                this.m_MutexRef = new ptr<sync.Mutex>(new sync.Mutex(nil));
                this.path = default;
                this.vol = default;
                this.idxhi = default;
                this.idxlo = default;
                this.appendNameToPath = default;
            }

            public fileStat(@string name = default, syscall.Win32FileAttributeData sys = default, uint filetype = default, sync.Mutex Mutex = default, @string path = default, uint vol = default, uint idxhi = default, uint idxlo = default, bool appendNameToPath = default)
            {
                this.name = name;
                this.sys = sys;
                this.filetype = filetype;
                this.m_MutexRef = new ptr<sync.Mutex>(Mutex);
                this.path = path;
                this.vol = vol;
                this.idxhi = idxhi;
                this.idxlo = idxlo;
                this.appendNameToPath = appendNameToPath;
            }

            // Enable comparisons between nil and fileStat struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(fileStat value, NilType nil) => value.Equals(default(fileStat));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(fileStat value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, fileStat value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, fileStat value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator fileStat(NilType nil) => default(fileStat);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static fileStat fileStat_cast(dynamic value)
        {
            return new fileStat(value.name, value.sys, value.filetype, value.Mutex, value.path, value.vol, value.idxhi, value.idxlo, value.appendNameToPath);
        }
    }
}