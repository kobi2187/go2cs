// Copyright 2019 The Go Authors. All rights reserved.
// Use of this source code is governed by a BSD-style
// license that can be found in the LICENSE file.

// package lib -- go2cs converted at 2020 October 09 05:50:37 UTC
// import "cmd/link/internal/ld/testdata/issue32233/lib" ==> using lib = go.cmd.link.@internal.ld.testdata.issue32233.lib_package
// Original source: C:\Go\src\cmd\link\internal\ld\testdata\issue32233\lib\lib.go
/*
#cgo darwin CFLAGS: -D__MAC_OS_X_VERSION_MAX_ALLOWED=101450
#cgo darwin LDFLAGS: -framework Foundation -framework AppKit
#include "stdlib.h"
int function(void);
*/
using C = go.C_package;/*
#cgo darwin CFLAGS: -D__MAC_OS_X_VERSION_MAX_ALLOWED=101450
#cgo darwin LDFLAGS: -framework Foundation -framework AppKit
#include "stdlib.h"
int function(void);
*/

using fmt = go.fmt_package;
using static go.builtin;

namespace go {
namespace cmd {
namespace link {
namespace @internal {
namespace ld {
namespace testdata {
namespace issue32233
{
    public static partial class lib_package
    {
        public static void DoC()
        {
            C.function();
            fmt.Println("called c function");
        }
    }
}}}}}}}
