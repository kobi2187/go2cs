// package p -- go2cs converted at 2020 August 29 10:02:02 UTC
// import "cmd/go/testdata/src.p" ==> using p = go.cmd.go.testdata.src.p_package
// Original source: C:\Go\src\cmd\go\testdata\src\cgocover3\p.go
/*
void
f(void)
{
}
*/
using C = go.C_package;
using static go.builtin;

namespace go {
namespace cmd {
namespace go {
namespace testdata
{
    public static partial class p_package
    {
        private static bool b = default;

        public static void F()
        {
            if (b)
            {
                while (true)
                {
                }

            }
            C.f();
        }
    }
}}}}