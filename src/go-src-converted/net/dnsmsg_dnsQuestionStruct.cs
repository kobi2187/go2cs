//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:26:05 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;


namespace go
{
    public static partial class net_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct dnsQuestion
        {
            // Constructors
            public dnsQuestion(NilType _)
            {
                this.Name = default;
                this.Qtype = default;
                this.Qclass = default;
            }

            public dnsQuestion(@string Name = default, ushort Qtype = default, ushort Qclass = default)
            {
                this.Name = Name;
                this.Qtype = Qtype;
                this.Qclass = Qclass;
            }

            // Enable comparisons between nil and dnsQuestion struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(dnsQuestion value, NilType nil) => value.Equals(default(dnsQuestion));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(dnsQuestion value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, dnsQuestion value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, dnsQuestion value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator dnsQuestion(NilType nil) => default(dnsQuestion);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static dnsQuestion dnsQuestion_cast(dynamic value)
        {
            return new dnsQuestion(value.Name, value.Qtype, value.Qclass);
        }
    }
}