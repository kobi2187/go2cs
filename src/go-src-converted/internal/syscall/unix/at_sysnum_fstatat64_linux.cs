// Copyright 2018 The Go Authors. All rights reserved.
// Use of this source code is governed by a BSD-style
// license that can be found in the LICENSE file.

// +build arm mips mipsle 386

// package unix -- go2cs converted at 2020 October 09 04:50:55 UTC
// import "internal/syscall/unix" ==> using unix = go.@internal.syscall.unix_package
// Original source: C:\Go\src\internal\syscall\unix\at_sysnum_fstatat64_linux.go
using syscall = go.syscall_package;
using static go.builtin;

namespace go {
namespace @internal {
namespace syscall
{
    public static partial class unix_package
    {
        private static readonly System.UIntPtr fstatatTrap = (System.UIntPtr)syscall.SYS_FSTATAT64;

    }
}}}
