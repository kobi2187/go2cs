//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:10:33 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using go;

namespace go {
namespace cmd {
namespace compile {
namespace @internal
{
    public static partial class ssa_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct ByTopo
        {
            // Value of the ByTopo struct
            private readonly slice<ptr<FuncLines>> m_value;

            public ByTopo(slice<ptr<FuncLines>> value) => m_value = value;

            // Enable implicit conversions between slice<ptr<FuncLines>> and ByTopo struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator ByTopo(slice<ptr<FuncLines>> value) => new ByTopo(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator slice<ptr<FuncLines>>(ByTopo value) => value.m_value;
            
            // Enable comparisons between nil and ByTopo struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(ByTopo value, NilType nil) => value.Equals(default(ByTopo));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(ByTopo value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, ByTopo value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, ByTopo value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator ByTopo(NilType nil) => default(ByTopo);
        }
    }
}}}}