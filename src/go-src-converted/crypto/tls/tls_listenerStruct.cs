//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:31:39 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using crypto = go.crypto_package;
using ecdsa = go.crypto.ecdsa_package;
using rsa = go.crypto.rsa_package;
using x509 = go.crypto.x509_package;
using pem = go.encoding.pem_package;
using errors = go.errors_package;
using fmt = go.fmt_package;
using ioutil = go.io.ioutil_package;
using net = go.net_package;
using strings = go.strings_package;
using time = go.time_package;
using go;

namespace go {
namespace crypto
{
    public static partial class tls_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct listener
        {
            // Listener.Accept function promotion
            private delegate Addr AcceptByVal(T value);
            private delegate Addr AcceptByRef(ref T value);

            private static readonly AcceptByVal s_AcceptByVal;
            private static readonly AcceptByRef s_AcceptByRef;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public Addr Accept() => s_AcceptByRef?.Invoke(ref this) ?? s_AcceptByVal?.Invoke(this) ?? Listener?.Accept() ?? throw new PanicException(RuntimeErrorPanic.NilPointerDereference);

            // Listener.Close function promotion
            private delegate Addr CloseByVal(T value);
            private delegate Addr CloseByRef(ref T value);

            private static readonly CloseByVal s_CloseByVal;
            private static readonly CloseByRef s_CloseByRef;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public Addr Close() => s_CloseByRef?.Invoke(ref this) ?? s_CloseByVal?.Invoke(this) ?? Listener?.Close() ?? throw new PanicException(RuntimeErrorPanic.NilPointerDereference);

            // Listener.Addr function promotion
            private delegate Addr AddrByVal(T value);
            private delegate Addr AddrByRef(ref T value);

            private static readonly AddrByVal s_AddrByVal;
            private static readonly AddrByRef s_AddrByRef;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public Addr Addr() => s_AddrByRef?.Invoke(ref this) ?? s_AddrByVal?.Invoke(this) ?? Listener?.Addr() ?? throw new PanicException(RuntimeErrorPanic.NilPointerDereference);
            
            [DebuggerStepperBoundary]
            static listener()
            {
                Type targetType = typeof(listener);
                MethodInfo extensionMethod;
                
                extensionMethod = targetType.GetExtensionMethodSearchingPromotions("Accept");

                if ((object)extensionMethod != null)
                {
                    s_AcceptByRef = extensionMethod.CreateStaticDelegate(typeof(AcceptByRef)) as AcceptByRef;

                    if ((object)s_AcceptByRef == null)
                        s_AcceptByVal = extensionMethod.CreateStaticDelegate(typeof(AcceptByVal)) as AcceptByVal;
                }
                
                extensionMethod = targetType.GetExtensionMethodSearchingPromotions("Close");

                if ((object)extensionMethod != null)
                {
                    s_CloseByRef = extensionMethod.CreateStaticDelegate(typeof(CloseByRef)) as CloseByRef;

                    if ((object)s_CloseByRef == null)
                        s_CloseByVal = extensionMethod.CreateStaticDelegate(typeof(CloseByVal)) as CloseByVal;
                }
                
                extensionMethod = targetType.GetExtensionMethodSearchingPromotions("Addr");

                if ((object)extensionMethod != null)
                {
                    s_AddrByRef = extensionMethod.CreateStaticDelegate(typeof(AddrByRef)) as AddrByRef;

                    if ((object)s_AddrByRef == null)
                        s_AddrByVal = extensionMethod.CreateStaticDelegate(typeof(AddrByVal)) as AddrByVal;
                }
            }

            // Constructors
            public listener(NilType _)
            {
                this.Listener = default;
                this.config = default;
            }

            public listener(net.Listener Listener = default, ref ptr<Config> config = default)
            {
                this.Listener = Listener;
                this.config = config;
            }

            // Enable comparisons between nil and listener struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(listener value, NilType nil) => value.Equals(default(listener));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(listener value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, listener value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, listener value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator listener(NilType nil) => default(listener);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static listener listener_cast(dynamic value)
        {
            return new listener(value.Listener, ref value.config);
        }
    }
}}