//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 06:01:50 UTC
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
namespace golang.org {
namespace x {
namespace tools {
namespace @internal {
namespace @event {
namespace export {
namespace ocagent
{
    public static partial class wire_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct StackFrame
        {
            // Constructors
            public StackFrame(NilType _)
            {
                this.FunctionName = default;
                this.OriginalFunctionName = default;
                this.FileName = default;
                this.LineNumber = default;
                this.ColumnNumber = default;
                this.LoadModule = default;
                this.SourceVersion = default;
            }

            public StackFrame(ref ptr<TruncatableString> FunctionName = default, ref ptr<TruncatableString> OriginalFunctionName = default, ref ptr<TruncatableString> FileName = default, long LineNumber = default, long ColumnNumber = default, ref ptr<Module> LoadModule = default, ref ptr<TruncatableString> SourceVersion = default)
            {
                this.FunctionName = FunctionName;
                this.OriginalFunctionName = OriginalFunctionName;
                this.FileName = FileName;
                this.LineNumber = LineNumber;
                this.ColumnNumber = ColumnNumber;
                this.LoadModule = LoadModule;
                this.SourceVersion = SourceVersion;
            }

            // Enable comparisons between nil and StackFrame struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(StackFrame value, NilType nil) => value.Equals(default(StackFrame));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(StackFrame value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, StackFrame value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, StackFrame value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator StackFrame(NilType nil) => default(StackFrame);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static StackFrame StackFrame_cast(dynamic value)
        {
            return new StackFrame(ref value.FunctionName, ref value.OriginalFunctionName, ref value.FileName, value.LineNumber, value.ColumnNumber, ref value.LoadModule, ref value.SourceVersion);
        }
    }
}}}}}}}}