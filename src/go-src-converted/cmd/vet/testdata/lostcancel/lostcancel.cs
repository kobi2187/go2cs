// Copyright 2016 The Go Authors. All rights reserved.
// Use of this source code is governed by a BSD-style
// license that can be found in the LICENSE file.

// package lostcancel -- go2cs converted at 2020 October 09 06:05:09 UTC
// import "cmd/vet/testdata/lostcancel" ==> using lostcancel = go.cmd.vet.testdata.lostcancel_package
// Original source: C:\Go\src\cmd\vet\testdata\lostcancel\lostcancel.go
using context = go.context_package;
using static go.builtin;

namespace go {
namespace cmd {
namespace vet {
namespace testdata
{
    public static partial class lostcancel_package
    {
        private static void _()
        {
 // ERROR "the cancel function is not used on all paths \(possible context leak\)"
            if (false)
            {
                _ = cancel;
            }
        } // ERROR "this return statement may be reached without using the cancel var defined on line 10"
    }
}}}}
