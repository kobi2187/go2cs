﻿using System.Runtime.CompilerServices;
using go;
using time = go.time_package;

public static partial class main_package
{
    public partial struct MyError
    {
        public MyError((time.Time, @string) i) :
            this(i.Item1, i.Item2) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public MyError(time.Time When = default, @string What = default) {
            this.When = When;
            this.What = What;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString() => $"{{{When}}} {{{What}}}";

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator MyError((time.Time, @string) value) => new MyError(value);

        // Person to nil comparisons
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(MyError obj, NilType _) => obj.Equals( default(MyError));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(MyError obj, NilType nil) => !(obj == nil);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(NilType nil, MyError obj) => obj == nil;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(NilType nil, MyError obj) => obj != nil;
    }
}
