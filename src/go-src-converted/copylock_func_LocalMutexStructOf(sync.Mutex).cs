//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 06:03:57 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using go;

#nullable enable

namespace go {
namespace golang.org {
namespace x {
namespace tools {
namespace go {
namespace analysis {
namespace passes {
namespace copylock {
namespace testdata {
namespace src
{
    public static partial class a_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct LocalMutex
        {
            // Value of the LocalMutex struct
            private readonly sync.Mutex m_value;

            public LocalMutex(sync.Mutex value) => m_value = value;

            // Enable implicit conversions between sync.Mutex and LocalMutex struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator LocalMutex(sync.Mutex value) => new LocalMutex(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator sync.Mutex(LocalMutex value) => value.m_value;
            
            // Enable comparisons between nil and LocalMutex struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(LocalMutex value, NilType nil) => value.Equals(default(LocalMutex));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(LocalMutex value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, LocalMutex value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, LocalMutex value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator LocalMutex(NilType nil) => default(LocalMutex);
        }
    }
}}}}}}}}}}