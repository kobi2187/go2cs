//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:47:34 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using context = go.context_package;
using go;

#nullable enable
#pragma warning disable CS0660, CS0661

namespace go {
namespace golang.org {
namespace x {
namespace mod {
namespace sumdb
{
    public static partial class storage_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial interface Transaction
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static Transaction As<T>(in T target) => (Transaction<T>)target!;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static Transaction As<T>(ptr<T> target_ptr) => (Transaction<T>)target_ptr;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static Transaction? As(object target) =>
                typeof(Transaction<>).CreateInterfaceHandler<Transaction>(target);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public class Transaction<T> : Transaction
        {
            private T m_target = default!;
            private readonly ptr<T>? m_target_ptr;
            private readonly bool m_target_is_ptr;

            public ref T Target
            {
                get
                {
                    if (m_target_is_ptr && !(m_target_ptr is null))
                        return ref m_target_ptr.val;

                    return ref m_target;
                }
            }

            public Transaction(in T target) => m_target = target;

            public Transaction(ptr<T> target_ptr)
            {
                m_target_ptr = target_ptr;
                m_target_is_ptr = true;
            }

            private delegate error ReadValueByPtr(ptr<T> value, context.Context ctx, @string key);
            private delegate error ReadValueByVal(T value, context.Context ctx, @string key);

            private static readonly ReadValueByPtr? s_ReadValueByPtr;
            private static readonly ReadValueByVal? s_ReadValueByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public error ReadValue(context.Context ctx, @string key)
            {
                T target = m_target;

                if (m_target_is_ptr && !(m_target_ptr is null))
                    target = m_target_ptr.val;

                if (s_ReadValueByPtr is null || !m_target_is_ptr)
                    return s_ReadValueByVal!(target, ctx, key);

                return s_ReadValueByPtr(m_target_ptr, ctx, key);
            }

            private delegate error ReadValuesByPtr(ptr<T> value, context.Context ctx, slice<@string> keys);
            private delegate error ReadValuesByVal(T value, context.Context ctx, slice<@string> keys);

            private static readonly ReadValuesByPtr? s_ReadValuesByPtr;
            private static readonly ReadValuesByVal? s_ReadValuesByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public error ReadValues(context.Context ctx, slice<@string> keys)
            {
                T target = m_target;

                if (m_target_is_ptr && !(m_target_ptr is null))
                    target = m_target_ptr.val;

                if (s_ReadValuesByPtr is null || !m_target_is_ptr)
                    return s_ReadValuesByVal!(target, ctx, keys);

                return s_ReadValuesByPtr(m_target_ptr, ctx, keys);
            }

            private delegate error BufferWritesByPtr(ptr<T> value, slice<Write> writes);
            private delegate error BufferWritesByVal(T value, slice<Write> writes);

            private static readonly BufferWritesByPtr? s_BufferWritesByPtr;
            private static readonly BufferWritesByVal? s_BufferWritesByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public error BufferWrites(slice<Write> writes)
            {
                T target = m_target;

                if (m_target_is_ptr && !(m_target_ptr is null))
                    target = m_target_ptr.val;

                if (s_BufferWritesByPtr is null || !m_target_is_ptr)
                    return s_BufferWritesByVal!(target, writes);

                return s_BufferWritesByPtr(m_target_ptr, writes);
            }
            
            public string ToString(string? format, IFormatProvider? formatProvider) => format;

            [DebuggerStepperBoundary]
            static Transaction()
            {
                Type targetType = typeof(T);
                Type targetTypeByPtr = typeof(ptr<T>);
                MethodInfo extensionMethod;

               extensionMethod = targetTypeByPtr.GetExtensionMethod("ReadValue");

                if (!(extensionMethod is null))
                    s_ReadValueByPtr = extensionMethod.CreateStaticDelegate(typeof(ReadValueByPtr)) as ReadValueByPtr;

                extensionMethod = targetType.GetExtensionMethod("ReadValue");

                if (!(extensionMethod is null))
                    s_ReadValueByVal = extensionMethod.CreateStaticDelegate(typeof(ReadValueByVal)) as ReadValueByVal;

                if (s_ReadValueByPtr is null && s_ReadValueByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement Transaction.ReadValue method", new Exception("ReadValue"));

               extensionMethod = targetTypeByPtr.GetExtensionMethod("ReadValues");

                if (!(extensionMethod is null))
                    s_ReadValuesByPtr = extensionMethod.CreateStaticDelegate(typeof(ReadValuesByPtr)) as ReadValuesByPtr;

                extensionMethod = targetType.GetExtensionMethod("ReadValues");

                if (!(extensionMethod is null))
                    s_ReadValuesByVal = extensionMethod.CreateStaticDelegate(typeof(ReadValuesByVal)) as ReadValuesByVal;

                if (s_ReadValuesByPtr is null && s_ReadValuesByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement Transaction.ReadValues method", new Exception("ReadValues"));

               extensionMethod = targetTypeByPtr.GetExtensionMethod("BufferWrites");

                if (!(extensionMethod is null))
                    s_BufferWritesByPtr = extensionMethod.CreateStaticDelegate(typeof(BufferWritesByPtr)) as BufferWritesByPtr;

                extensionMethod = targetType.GetExtensionMethod("BufferWrites");

                if (!(extensionMethod is null))
                    s_BufferWritesByVal = extensionMethod.CreateStaticDelegate(typeof(BufferWritesByVal)) as BufferWritesByVal;

                if (s_BufferWritesByPtr is null && s_BufferWritesByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement Transaction.BufferWrites method", new Exception("BufferWrites"));
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator Transaction<T>(in ptr<T> target_ptr) => new Transaction<T>(target_ptr);

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator Transaction<T>(in T target) => new Transaction<T>(target);

            // Enable comparisons between nil and Transaction<T> interface instance
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Transaction<T> value, NilType nil) => Activator.CreateInstance<Transaction<T>>().Equals(value);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Transaction<T> value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Transaction<T> value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Transaction<T> value) => value != nil;
        }
    }
}}}}}

namespace go
{
    public static class storage_TransactionExtensions
    {
        private static readonly ConcurrentDictionary<Type, MethodInfo> s_conversionOperators = new ConcurrentDictionary<Type, MethodInfo>();

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static T _<T>(this go.golang.org.x.mod.sumdb.storage_package.Transaction target)
        {
            try
            {
                return ((go.golang.org.x.mod.sumdb.storage_package.Transaction<T>)target).Target;
            }
            catch (NotImplementedException ex)
            {
                throw new PanicException($"interface conversion: {GetGoTypeName(target.GetType())} is not {GetGoTypeName(typeof(T))}: missing method {ex.InnerException?.Message}");
            }
        }

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static bool _<T>(this go.golang.org.x.mod.sumdb.storage_package.Transaction target, out T result)
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
        public static object? _(this go.golang.org.x.mod.sumdb.storage_package.Transaction target, Type type)
        {
            try
            {
                MethodInfo? conversionOperator = s_conversionOperators.GetOrAdd(type, _ => typeof(go.golang.org.x.mod.sumdb.storage_package.Transaction<>).GetExplicitGenericConversionOperator(type));

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
        public static bool _(this go.golang.org.x.mod.sumdb.storage_package.Transaction target, Type type, out object? result)
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