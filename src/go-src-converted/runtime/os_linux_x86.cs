// Copyright 2019 The Go Authors. All rights reserved.
// Use of this source code is governed by a BSD-style
// license that can be found in the LICENSE file.

// +build linux
// +build 386 amd64

// package runtime -- go2cs converted at 2020 October 09 04:47:30 UTC
// import "runtime" ==> using runtime = go.runtime_package
// Original source: C:\Go\src\runtime\os_linux_x86.go
using atomic = go.runtime.@internal.atomic_package;
using @unsafe = go.@unsafe_package;
using static go.builtin;

namespace go
{
    public static partial class runtime_package
    {
        //go:noescape
        private static long uname(ptr<new_utsname> utsname)
;

        private static long mlock(System.UIntPtr addr, System.UIntPtr len)
;

        private static void osArchInit()
        { 
            // Linux 5.2 introduced a bug that can corrupt vector
            // registers on return from a signal if the signal stack isn't
            // faulted in:
            // https://bugzilla.kernel.org/show_bug.cgi?id=205663
            //
            // It was fixed in 5.3.15, 5.4.2, and all 5.5 and later
            // kernels.
            //
            // If we're on an affected kernel, work around this issue by
            // mlocking the top page of every signal stack. This doesn't
            // help for signal stacks created in C, but there's not much
            // we can do about that.
            //
            // TODO(austin): Remove this in Go 1.15, at which point it
            // will be unlikely to encounter any of the affected kernels
            // in the wild.

            ref new_utsname uts = ref heap(out ptr<new_utsname> _addr_uts);
            if (uname(_addr_uts) < 0L)
            {>>MARKER:FUNCTION_mlock_BLOCK_PREFIX<<
                throw("uname failed");
            } 
            // Check for null terminator to ensure gostringnocopy doesn't
            // walk off the end of the release string.
            var found = false;
            foreach (var (_, b) in uts.release)
            {
                if (b == 0L)
                {>>MARKER:FUNCTION_uname_BLOCK_PREFIX<<
                    found = true;
                    break;
                }

            }
            if (!found)
            {
                return ;
            }

            var rel = gostringnocopy(_addr_uts.release[0L]);

            var (major, minor, patch, ok) = parseRelease(rel);
            if (!ok)
            {
                return ;
            }

            if (major == 5L && minor == 4L && patch < 2L)
            { 
                // All 5.4 versions of Ubuntu are patched.
                slice<byte> procVersion = (slice<byte>)"/proc/version ";
                var f = open(_addr_procVersion[0L], _O_RDONLY, 0L);
                if (f >= 0L)
                {
                    array<byte> buf = new array<byte>(512L);
                    var p = noescape(@unsafe.Pointer(_addr_buf[0L]));
                    var n = read(f, p, int32(len(buf)));
                    closefd(f);

                    slice<byte> needle = (slice<byte>)"Ubuntu";
contains:
                    foreach (var (i, c) in buf[..n])
                    {
                        if (c != needle[0L])
                        {
                            continue;
                        }

                        if (int(n) - i < len(needle))
                        {
                            break;
                        }

                        foreach (var (j, c2) in needle)
                        {
                            if (c2 != buf[i + j])
                            {
                                _continuecontains = true;
                                break;
                            }

                        } 
                        // This is an Ubuntu system.
                        return ;

                    }

                }

            }

            if (major == 5L && (minor == 2L || minor == 3L && patch < 15L || minor == 4L && patch < 2L))
            {
                gsignalInitQuirk = mlockGsignal;
                if (m0.gsignal != null)
                {
                    throw("gsignal quirk too late");
                }

                throwReportQuirk = throwBadKernel;

            }

        }

        private static void mlockGsignal(ptr<g> _addr_gsignal)
        {
            ref g gsignal = ref _addr_gsignal.val;

            if (atomic.Load(_addr_touchStackBeforeSignal) != 0L)
            { 
                // mlock has already failed, don't try again.
                return ;

            } 

            // This mlock call may fail, but we don't report the failure.
            // Instead, if something goes badly wrong, we rely on prepareSignalM
            // and throwBadKernel to do further mitigation and to report a problem
            // to the user if mitigation fails. This is because many
            // systems have a limit on the total mlock size, and many kernels
            // that appear to have bad versions are actually patched to avoid the
            // bug described above. We want Go 1.14 to run on those systems.
            // See #37436.
            {
                var errno = mlock(gsignal.stack.hi - physPageSize, physPageSize);

                if (errno < 0L)
                {
                    atomic.Store(_addr_touchStackBeforeSignal, uint32(-errno));
                }

            }

        }

        // throwBadKernel is called, via throwReportQuirk, by throw.
        private static void throwBadKernel()
        {
            {
                var errno = atomic.Load(_addr_touchStackBeforeSignal);

                if (errno != 0L)
                {
                    println("runtime: note: your Linux kernel may be buggy");
                    println("runtime: note: see https://golang.org/wiki/LinuxKernelSignalVectorBug");
                    println("runtime: note: mlock workaround for kernel bug failed with errno", errno);
                }

            }

        }
    }
}
