//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 10:09:35 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using bufio = go.bufio_package;
using errors = go.errors_package;
using io = go.io_package;

#pragma warning disable CS0660, CS0661

namespace go
{
    public static partial class image_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial interface reader
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static reader As<T>(in T target) => (reader<T>)target!;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static reader As<T>(ptr<T> target_ptr) => (reader<T>)target_ptr;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static reader? As(object target) =>
                typeof(reader<>).CreateInterfaceHandler<reader>(target);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private class reader<T> : reader
        {
            private T m_target;
            private readonly ptr<T>? m_target_ptr;
            private readonly bool m_target_is_ptr;

            public ref T Target
            {
                get
                {
                    if (m_target_is_ptr && !(m_target_ptr is null))
                        return ref m_target_ptr.Value;

                    return ref m_target;
                }
            }

            public reader(in T target) => m_target = target;

            public reader(ptr<T> target_ptr)
            {
                m_target_ptr = target_ptr;
                m_target_is_ptr = true;
            }

            private delegate (slice<byte>, error) PeekByRef(ref T value, long _p0);
            private delegate (slice<byte>, error) PeekByVal(T value, long _p0);

            private static readonly PeekByRef s_PeekByRef;
            private static readonly PeekByVal s_PeekByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public (slice<byte>, error) Peek(long _p0)
            {
                T target = m_target;

                if (m_target_is_ptr && !(m_target_ptr is null))
                    target = m_target_ptr.Value;
                if (s_PeekByRef is null)
                    return s_PeekByVal!(target, _p0);

                return s_PeekByRef(ref target, _p0);
            }

            private delegate (long, error) ReadByRef(ref T value, slice<byte> p);
            private delegate (long, error) ReadByVal(T value, slice<byte> p);

            private static readonly ReadByRef s_ReadByRef;
            private static readonly ReadByVal s_ReadByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public (long, error) Read(slice<byte> p)
            {
                T target = m_target;

                if (m_target_is_ptr && !(m_target_ptr is null))
                    target = m_target_ptr.Value;
                if (s_ReadByRef is null)
                    return s_ReadByVal!(target, p);

                return s_ReadByRef(ref target, p);
            }
            
            public string ToString(string format, IFormatProvider formatProvider) => format;

            [DebuggerStepperBoundary]
            static reader()
            {
                Type targetType = typeof(T);
                Type targetTypeByRef = targetType.MakeByRefType();
                MethodInfo extensionMethod;

               extensionMethod = targetTypeByRef.GetExtensionMethod("Peek");

                if (!(extensionMethod is null))
                    s_PeekByRef = extensionMethod.CreateStaticDelegate(typeof(PeekByRef)) as PeekByRef;

                if (s_PeekByRef is null)
                {
                    extensionMethod = targetType.GetExtensionMethod("Peek");

                    if (!(extensionMethod is null))
                        s_PeekByVal = extensionMethod.CreateStaticDelegate(typeof(PeekByVal)) as PeekByVal;
                }

                if (s_PeekByRef is null && s_PeekByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement reader.Peek method", new Exception("Peek"));

               extensionMethod = targetTypeByRef.GetExtensionMethod("Read");

                if (!(extensionMethod is null))
                    s_ReadByRef = extensionMethod.CreateStaticDelegate(typeof(ReadByRef)) as ReadByRef;

                if (s_ReadByRef is null)
                {
                    extensionMethod = targetType.GetExtensionMethod("Read");

                    if (!(extensionMethod is null))
                        s_ReadByVal = extensionMethod.CreateStaticDelegate(typeof(ReadByVal)) as ReadByVal;
                }

                if (s_ReadByRef is null && s_ReadByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement reader.Read method", new Exception("Read"));
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator reader<T>(in ptr<T> target_ptr) => new reader<T>(target_ptr);

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator reader<T>(in T target) => new reader<T>(target);

            // Enable comparisons between nil and reader<T> interface instance
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(reader<T> value, NilType nil) => Activator.CreateInstance<reader<T>>().Equals(value);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(reader<T> value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, reader<T> value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, reader<T> value) => value != nil;
        }
    }
}

namespace go
{
    public static class image_readerExtensions
    {
        private static readonly ConcurrentDictionary<Type, MethodInfo> s_conversionOperators = new ConcurrentDictionary<Type, MethodInfo>();

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static T _<T>(this go.image_package.reader target)
        {
            try
            {
                return ((go.image_package.reader<T>)target).Target;
            }
            catch (NotImplementedException ex)
            {
                throw new PanicException($"interface conversion: {GetGoTypeName(target.GetType())} is not {GetGoTypeName(typeof(T))}: missing method {ex.InnerException?.Message}");
            }
        }

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static bool _<T>(this go.image_package.reader target, out T result)
        {
            try
            {
                result = target._<T>();
                return true;
            }
            catch (PanicException)
            {
                result = default!;
                return false;
            }
        }

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static object? _(this go.image_package.reader target, Type type)
        {
            try
            {
                MethodInfo? conversionOperator = s_conversionOperators.GetOrAdd(type, _ => typeof(go.image_package.reader<>).GetExplicitGenericConversionOperator(type));

                if (conversionOperator is null)
                    throw new PanicException($"interface conversion: failed to create converter for {GetGoTypeName(target.GetType())} to {GetGoTypeName(type)}");

                dynamic? result = conversionOperator.Invoke(null, new object[] { target });
                return result?.Target;
            }
            catch (NotImplementedException ex)
            {
                throw new PanicException($"interface conversion: {GetGoTypeName(target.GetType())} is not {GetGoTypeName(type)}: missing method {ex.InnerException?.Message}");
            }
        }

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static bool _(this go.image_package.reader target, Type type, out object? result)
        {
            try
            {
                result = target._(type);
                return true;
            }
            catch (PanicException)
            {
                result = type.IsValueType ? Activator.CreateInstance(type) : null;
                return false;
            }
        }
    }
}