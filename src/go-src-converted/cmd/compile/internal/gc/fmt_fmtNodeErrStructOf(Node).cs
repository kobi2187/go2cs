//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:41:29 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using go;

#nullable enable

namespace go {
namespace cmd {
namespace compile {
namespace @internal
{
    public static partial class gc_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct fmtNodeErr
        {
            // Value of the fmtNodeErr struct
            private readonly Node m_value;

            public fmtNodeErr(Node value) => m_value = value;

            // Enable implicit conversions between Node and fmtNodeErr struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator fmtNodeErr(Node value) => new fmtNodeErr(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Node(fmtNodeErr value) => value.m_value;
            
            // Enable comparisons between nil and fmtNodeErr struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(fmtNodeErr value, NilType nil) => value.Equals(default(fmtNodeErr));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(fmtNodeErr value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, fmtNodeErr value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, fmtNodeErr value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator fmtNodeErr(NilType nil) => default(fmtNodeErr);
        }
    }
}}}}
