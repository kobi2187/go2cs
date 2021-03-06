// Copyright 2017 The Go Authors. All rights reserved.
// Use of this source code is governed by a BSD-style
// license that can be found in the LICENSE file.

// package types -- go2cs converted at 2020 October 09 05:24:16 UTC
// import "cmd/compile/internal/types" ==> using types = go.cmd.compile.@internal.types_package
// Original source: C:\Go\src\cmd\compile\internal\types\utils.go
using obj = go.cmd.@internal.obj_package;
using fmt = go.fmt_package;
using static go.builtin;
using System;

namespace go {
namespace cmd {
namespace compile {
namespace @internal
{
    public static partial class types_package
    {
        public static readonly long BADWIDTH = (long)-1000000000L;

        // The following variables must be initialized early by the frontend.
        // They are here to break import cycles.
        // TODO(gri) eliminate these dependencies.


        // The following variables must be initialized early by the frontend.
        // They are here to break import cycles.
        // TODO(gri) eliminate these dependencies.
        public static long Widthptr = default;        public static Action<ptr<Type>> Dowidth = default;        public static Action<@string, object> Fatalf = default;        public static Func<ptr<Sym>, long, long, @string> Sconv = default;        public static Func<ptr<Type>, long, long, @string> Tconv = default;        public static Action<ptr<Sym>, fmt.State, int, long> FormatSym = default;        public static Action<ptr<Type>, fmt.State, int, long> FormatType = default;        public static Func<ptr<Type>, ptr<obj.LSym>> TypeLinkSym = default;        public static ptr<obj.Link> Ctxt;        public static long FmtLeft = default;        public static long FmtUnsigned = default;        public static long FErr = default;

        private static @string String(this ptr<Sym> _addr_s)
        {
            ref Sym s = ref _addr_s.val;

            return Sconv(s, 0L, FErr);
        }

        private static void Format(this ptr<Sym> _addr_sym, fmt.State s, int verb)
        {
            ref Sym sym = ref _addr_sym.val;

            FormatSym(sym, s, verb, FErr);
        }

        private static @string String(this ptr<Type> _addr_t)
        {
            ref Type t = ref _addr_t.val;
 
            // The implementation of tconv (including typefmt and fldconv)
            // must handle recursive types correctly.
            return Tconv(t, 0L, FErr);

        }

        // ShortString generates a short description of t.
        // It is used in autogenerated method names, reflection,
        // and itab names.
        private static @string ShortString(this ptr<Type> _addr_t)
        {
            ref Type t = ref _addr_t.val;

            return Tconv(t, FmtLeft, FErr);
        }

        // LongString generates a complete description of t.
        // It is useful for reflection,
        // or when a unique fingerprint or hash of a type is required.
        private static @string LongString(this ptr<Type> _addr_t)
        {
            ref Type t = ref _addr_t.val;

            return Tconv(t, FmtLeft | FmtUnsigned, FErr);
        }

        private static void Format(this ptr<Type> _addr_t, fmt.State s, int verb)
        {
            ref Type t = ref _addr_t.val;

            FormatType(t, s, verb, FErr);
        }

        private partial struct bitset8 // : byte
        {
        }

        private static void set(this ptr<bitset8> _addr_f, byte mask, bool b)
        {
            ref bitset8 f = ref _addr_f.val;

            if (b)
            {
                (uint8.val)(f).val;

                mask;

            }
            else
            {
                (uint8.val)(f).val;

                mask;

            }

        }
    }
}}}}
