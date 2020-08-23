//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 23 15:59:56 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using fmt = go.fmt_package;

#pragma warning disable CS0660, CS0661

namespace go
{
    public static partial class main_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial interface V
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static V As<T>(in T target) => (V<T>)target!;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static V As<T>(ptr<T> target_ptr) => (V<T>)target_ptr;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static V? As(object target) =>
                typeof(V<>).CreateInterfaceHandler<V>(target);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public class V<T> : V
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

            public V(in T target) => m_target = target;

            public V(ptr<T> target_ptr)
            {
                m_target_ptr = target_ptr;
                m_target_is_ptr = true;
            }

            private delegate void NByRef(ref T value);
            private delegate void NByVal(T value);

            private static readonly NByRef s_NByRef;
            private static readonly NByVal s_NByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public void N()
            {
                T target = m_target;

                if (m_target_is_ptr && !(m_target_ptr is null))
                    target = m_target_ptr.Value;
                if (s_NByRef is null)
                {
                    s_NByVal!(target);
                    return;
                }

                s_NByRef(ref target);
                return;
                
            }

            private delegate void MByRef(ref T value);
            private delegate void MByVal(T value);

            private static readonly MByRef s_MByRef;
            private static readonly MByVal s_MByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public void M()
            {
                T target = m_target;

                if (m_target_is_ptr && !(m_target_ptr is null))
                    target = m_target_ptr.Value;
                if (s_MByRef is null)
                {
                    s_MByVal!(target);
                    return;
                }

                s_MByRef(ref target);
                return;
                
            }

            private delegate @string ErrorByRef(ref T value);
            private delegate @string ErrorByVal(T value);

            private static readonly ErrorByRef s_ErrorByRef;
            private static readonly ErrorByVal s_ErrorByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public @string Error()
            {
                T target = m_target;

                if (m_target_is_ptr && !(m_target_ptr is null))
                    target = m_target_ptr.Value;
                if (s_ErrorByRef is null)
                    return s_ErrorByVal!(target);

                return s_ErrorByRef(ref target);
            }
            
            public string ToString(string format, IFormatProvider formatProvider) => format;

            [DebuggerStepperBoundary]
            static V()
            {
                Type targetType = typeof(T);
                Type targetTypeByRef = targetType.MakeByRefType();
                MethodInfo extensionMethod;

               extensionMethod = targetTypeByRef.GetExtensionMethod("N");

                if (!(extensionMethod is null))
                    s_NByRef = extensionMethod.CreateStaticDelegate(typeof(NByRef)) as NByRef;

                if (s_NByRef is null)
                {
                    extensionMethod = targetType.GetExtensionMethod("N");

                    if (!(extensionMethod is null))
                        s_NByVal = extensionMethod.CreateStaticDelegate(typeof(NByVal)) as NByVal;
                }

                if (s_NByRef is null && s_NByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement V.N method", new Exception("N"));

               extensionMethod = targetTypeByRef.GetExtensionMethod("M");

                if (!(extensionMethod is null))
                    s_MByRef = extensionMethod.CreateStaticDelegate(typeof(MByRef)) as MByRef;

                if (s_MByRef is null)
                {
                    extensionMethod = targetType.GetExtensionMethod("M");

                    if (!(extensionMethod is null))
                        s_MByVal = extensionMethod.CreateStaticDelegate(typeof(MByVal)) as MByVal;
                }

                if (s_MByRef is null && s_MByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement V.M method", new Exception("M"));

               extensionMethod = targetTypeByRef.GetExtensionMethod("Error");

                if (!(extensionMethod is null))
                    s_ErrorByRef = extensionMethod.CreateStaticDelegate(typeof(ErrorByRef)) as ErrorByRef;

                if (s_ErrorByRef is null)
                {
                    extensionMethod = targetType.GetExtensionMethod("Error");

                    if (!(extensionMethod is null))
                        s_ErrorByVal = extensionMethod.CreateStaticDelegate(typeof(ErrorByVal)) as ErrorByVal;
                }

                if (s_ErrorByRef is null && s_ErrorByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement V.Error method", new Exception("Error"));
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator V<T>(in ptr<T> target_ptr) => new V<T>(target_ptr);

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator V<T>(in T target) => new V<T>(target);

            // Enable comparisons between nil and V<T> interface instance
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(V<T> value, NilType nil) => Activator.CreateInstance<V<T>>().Equals(value);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(V<T> value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, V<T> value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, V<T> value) => value != nil;
        }
    }
}

namespace go
{
    public static class main_VExtensions
    {
        private static readonly ConcurrentDictionary<Type, MethodInfo> s_conversionOperators = new ConcurrentDictionary<Type, MethodInfo>();

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static T _<T>(this go.main_package.V target)
        {
            try
            {
                return ((go.main_package.V<T>)target).Target;
            }
            catch (NotImplementedException ex)
            {
                throw new PanicException($"interface conversion: {GetGoTypeName(target.GetType())} is not {GetGoTypeName(typeof(T))}: missing method {ex.InnerException?.Message}");
            }
        }

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static bool _<T>(this go.main_package.V target, out T result)
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
        public static object? _(this go.main_package.V target, Type type)
        {
            try
            {
                MethodInfo? conversionOperator = s_conversionOperators.GetOrAdd(type, _ => typeof(go.main_package.V<>).GetExplicitGenericConversionOperator(type));

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
        public static bool _(this go.main_package.V target, Type type, out object? result)
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