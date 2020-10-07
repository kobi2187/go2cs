// Copyright 2014 The Go Authors. All rights reserved.
// Use of this source code is governed by a BSD-style
// license that can be found in the LICENSE file.

// package hpack -- go2cs converted at 2020 August 29 10:11:44 UTC
// import "vendor/golang_org/x/net/http2/hpack" ==> using hpack = go.vendor.golang_org.x.net.http2.hpack_package
// Original source: C:\Go\src\vendor\golang_org\x\net\http2\hpack\tables.go
using fmt = go.fmt_package;
using static go.builtin;

namespace go {
namespace vendor {
namespace golang_org {
namespace x {
namespace net {
namespace http2
{
    public static partial class hpack_package
    {
        // headerFieldTable implements a list of HeaderFields.
        // This is used to implement the static and dynamic tables.
        private partial struct headerFieldTable
        {
            public slice<HeaderField> ents;
            public ulong evictCount; // byName maps a HeaderField name to the unique id of the newest entry with
// the same name. See above for a definition of "unique id".
            public map<@string, ulong> byName; // byNameValue maps a HeaderField name/value pair to the unique id of the newest
// entry with the same name and value. See above for a definition of "unique id".
            public map<pairNameValue, ulong> byNameValue;
        }

        private partial struct pairNameValue
        {
            public @string name;
            public @string value;
        }

        private static void init(this ref headerFieldTable t)
        {
            t.byName = make_map<@string, ulong>();
            t.byNameValue = make_map<pairNameValue, ulong>();
        }

        // len reports the number of entries in the table.
        private static long len(this ref headerFieldTable t)
        {
            return len(t.ents);
        }

        // addEntry adds a new entry.
        private static void addEntry(this ref headerFieldTable t, HeaderField f)
        {
            var id = uint64(t.len()) + t.evictCount + 1L;
            t.byName[f.Name] = id;
            t.byNameValue[new pairNameValue(f.Name,f.Value)] = id;
            t.ents = append(t.ents, f);
        }

        // evictOldest evicts the n oldest entries in the table.
        private static void evictOldest(this ref headerFieldTable _t, long n) => func(_t, (ref headerFieldTable t, Defer _, Panic panic, Recover __) =>
        {
            if (n > t.len())
            {
                panic(fmt.Sprintf("evictOldest(%v) on table with %v entries", n, t.len()));
            }
            {
                long k__prev1 = k;

                for (long k = 0L; k < n; k++)
                {
                    var f = t.ents[k];
                    var id = t.evictCount + uint64(k) + 1L;
                    if (t.byName[f.Name] == id)
                    {
                        delete(t.byName, f.Name);
                    }
                    {
                        pairNameValue p = (new pairNameValue(f.Name,f.Value));

                        if (t.byNameValue[p] == id)
                        {
                            delete(t.byNameValue, p);
                        }

                    }
                }


                k = k__prev1;
            }
            copy(t.ents, t.ents[n..]);
            {
                long k__prev1 = k;

                for (k = t.len() - n; k < t.len(); k++)
                {
                    t.ents[k] = new HeaderField(); // so strings can be garbage collected
                }


                k = k__prev1;
            }
            t.ents = t.ents[..t.len() - n];
            if (t.evictCount + uint64(n) < t.evictCount)
            {
                panic("evictCount overflow");
            }
            t.evictCount += uint64(n);
        });

        // search finds f in the table. If there is no match, i is 0.
        // If both name and value match, i is the matched index and nameValueMatch
        // becomes true. If only name matches, i points to that index and
        // nameValueMatch becomes false.
        //
        // The returned index is a 1-based HPACK index. For dynamic tables, HPACK says
        // that index 1 should be the newest entry, but t.ents[0] is the oldest entry,
        // meaning t.ents is reversed for dynamic tables. Hence, when t is a dynamic
        // table, the return value i actually refers to the entry t.ents[t.len()-i].
        //
        // All tables are assumed to be a dynamic tables except for the global
        // staticTable pointer.
        //
        // See Section 2.3.3.
        private static (ulong, bool) search(this ref headerFieldTable t, HeaderField f)
        {
            if (!f.Sensitive)
            {
                {
                    var id__prev2 = id;

                    var id = t.byNameValue[new pairNameValue(f.Name,f.Value)];

                    if (id != 0L)
                    {
                        return (t.idToIndex(id), true);
                    }

                    id = id__prev2;

                }
            }
            {
                var id__prev1 = id;

                id = t.byName[f.Name];

                if (id != 0L)
                {
                    return (t.idToIndex(id), false);
                }

                id = id__prev1;

            }
            return (0L, false);
        }

        // idToIndex converts a unique id to an HPACK index.
        // See Section 2.3.3.
        private static ulong idToIndex(this ref headerFieldTable _t, ulong id) => func(_t, (ref headerFieldTable t, Defer _, Panic panic, Recover __) =>
        {
            if (id <= t.evictCount)
            {
                panic(fmt.Sprintf("id (%v) <= evictCount (%v)", id, t.evictCount));
            }
            var k = id - t.evictCount - 1L; // convert id to an index t.ents[k]
            if (t != staticTable)
            {
                return uint64(t.len()) - k; // dynamic table
            }
            return k + 1L;
        });

        // http://tools.ietf.org/html/draft-ietf-httpbis-header-compression-07#appendix-B
        private static var staticTable = newStaticTable();
        private static array<HeaderField> staticTableEntries = new array<HeaderField>(new HeaderField[] { HeaderField{Name:":authority"}, HeaderField{Name:":method",Value:"GET"}, HeaderField{Name:":method",Value:"POST"}, HeaderField{Name:":path",Value:"/"}, HeaderField{Name:":path",Value:"/index.html"}, HeaderField{Name:":scheme",Value:"http"}, HeaderField{Name:":scheme",Value:"https"}, HeaderField{Name:":status",Value:"200"}, HeaderField{Name:":status",Value:"204"}, HeaderField{Name:":status",Value:"206"}, HeaderField{Name:":status",Value:"304"}, HeaderField{Name:":status",Value:"400"}, HeaderField{Name:":status",Value:"404"}, HeaderField{Name:":status",Value:"500"}, HeaderField{Name:"accept-charset"}, HeaderField{Name:"accept-encoding",Value:"gzip, deflate"}, HeaderField{Name:"accept-language"}, HeaderField{Name:"accept-ranges"}, HeaderField{Name:"accept"}, HeaderField{Name:"access-control-allow-origin"}, HeaderField{Name:"age"}, HeaderField{Name:"allow"}, HeaderField{Name:"authorization"}, HeaderField{Name:"cache-control"}, HeaderField{Name:"content-disposition"}, HeaderField{Name:"content-encoding"}, HeaderField{Name:"content-language"}, HeaderField{Name:"content-length"}, HeaderField{Name:"content-location"}, HeaderField{Name:"content-range"}, HeaderField{Name:"content-type"}, HeaderField{Name:"cookie"}, HeaderField{Name:"date"}, HeaderField{Name:"etag"}, HeaderField{Name:"expect"}, HeaderField{Name:"expires"}, HeaderField{Name:"from"}, HeaderField{Name:"host"}, HeaderField{Name:"if-match"}, HeaderField{Name:"if-modified-since"}, HeaderField{Name:"if-none-match"}, HeaderField{Name:"if-range"}, HeaderField{Name:"if-unmodified-since"}, HeaderField{Name:"last-modified"}, HeaderField{Name:"link"}, HeaderField{Name:"location"}, HeaderField{Name:"max-forwards"}, HeaderField{Name:"proxy-authenticate"}, HeaderField{Name:"proxy-authorization"}, HeaderField{Name:"range"}, HeaderField{Name:"referer"}, HeaderField{Name:"refresh"}, HeaderField{Name:"retry-after"}, HeaderField{Name:"server"}, HeaderField{Name:"set-cookie"}, HeaderField{Name:"strict-transport-security"}, HeaderField{Name:"transfer-encoding"}, HeaderField{Name:"user-agent"}, HeaderField{Name:"vary"}, HeaderField{Name:"via"}, HeaderField{Name:"www-authenticate"} });

        private static ref headerFieldTable newStaticTable()
        {
            headerFieldTable t = ref new headerFieldTable();
            t.init();
            foreach (var (_, e) in staticTableEntries[..])
            {
                t.addEntry(e);
            }
            return t;
        }

        private static array<uint> huffmanCodes = new array<uint>(new uint[] { 0x1ff8, 0x7fffd8, 0xfffffe2, 0xfffffe3, 0xfffffe4, 0xfffffe5, 0xfffffe6, 0xfffffe7, 0xfffffe8, 0xffffea, 0x3ffffffc, 0xfffffe9, 0xfffffea, 0x3ffffffd, 0xfffffeb, 0xfffffec, 0xfffffed, 0xfffffee, 0xfffffef, 0xffffff0, 0xffffff1, 0xffffff2, 0x3ffffffe, 0xffffff3, 0xffffff4, 0xffffff5, 0xffffff6, 0xffffff7, 0xffffff8, 0xffffff9, 0xffffffa, 0xffffffb, 0x14, 0x3f8, 0x3f9, 0xffa, 0x1ff9, 0x15, 0xf8, 0x7fa, 0x3fa, 0x3fb, 0xf9, 0x7fb, 0xfa, 0x16, 0x17, 0x18, 0x0, 0x1, 0x2, 0x19, 0x1a, 0x1b, 0x1c, 0x1d, 0x1e, 0x1f, 0x5c, 0xfb, 0x7ffc, 0x20, 0xffb, 0x3fc, 0x1ffa, 0x21, 0x5d, 0x5e, 0x5f, 0x60, 0x61, 0x62, 0x63, 0x64, 0x65, 0x66, 0x67, 0x68, 0x69, 0x6a, 0x6b, 0x6c, 0x6d, 0x6e, 0x6f, 0x70, 0x71, 0x72, 0xfc, 0x73, 0xfd, 0x1ffb, 0x7fff0, 0x1ffc, 0x3ffc, 0x22, 0x7ffd, 0x3, 0x23, 0x4, 0x24, 0x5, 0x25, 0x26, 0x27, 0x6, 0x74, 0x75, 0x28, 0x29, 0x2a, 0x7, 0x2b, 0x76, 0x2c, 0x8, 0x9, 0x2d, 0x77, 0x78, 0x79, 0x7a, 0x7b, 0x7ffe, 0x7fc, 0x3ffd, 0x1ffd, 0xffffffc, 0xfffe6, 0x3fffd2, 0xfffe7, 0xfffe8, 0x3fffd3, 0x3fffd4, 0x3fffd5, 0x7fffd9, 0x3fffd6, 0x7fffda, 0x7fffdb, 0x7fffdc, 0x7fffdd, 0x7fffde, 0xffffeb, 0x7fffdf, 0xffffec, 0xffffed, 0x3fffd7, 0x7fffe0, 0xffffee, 0x7fffe1, 0x7fffe2, 0x7fffe3, 0x7fffe4, 0x1fffdc, 0x3fffd8, 0x7fffe5, 0x3fffd9, 0x7fffe6, 0x7fffe7, 0xffffef, 0x3fffda, 0x1fffdd, 0xfffe9, 0x3fffdb, 0x3fffdc, 0x7fffe8, 0x7fffe9, 0x1fffde, 0x7fffea, 0x3fffdd, 0x3fffde, 0xfffff0, 0x1fffdf, 0x3fffdf, 0x7fffeb, 0x7fffec, 0x1fffe0, 0x1fffe1, 0x3fffe0, 0x1fffe2, 0x7fffed, 0x3fffe1, 0x7fffee, 0x7fffef, 0xfffea, 0x3fffe2, 0x3fffe3, 0x3fffe4, 0x7ffff0, 0x3fffe5, 0x3fffe6, 0x7ffff1, 0x3ffffe0, 0x3ffffe1, 0xfffeb, 0x7fff1, 0x3fffe7, 0x7ffff2, 0x3fffe8, 0x1ffffec, 0x3ffffe2, 0x3ffffe3, 0x3ffffe4, 0x7ffffde, 0x7ffffdf, 0x3ffffe5, 0xfffff1, 0x1ffffed, 0x7fff2, 0x1fffe3, 0x3ffffe6, 0x7ffffe0, 0x7ffffe1, 0x3ffffe7, 0x7ffffe2, 0xfffff2, 0x1fffe4, 0x1fffe5, 0x3ffffe8, 0x3ffffe9, 0xffffffd, 0x7ffffe3, 0x7ffffe4, 0x7ffffe5, 0xfffec, 0xfffff3, 0xfffed, 0x1fffe6, 0x3fffe9, 0x1fffe7, 0x1fffe8, 0x7ffff3, 0x3fffea, 0x3fffeb, 0x1ffffee, 0x1ffffef, 0xfffff4, 0xfffff5, 0x3ffffea, 0x7ffff4, 0x3ffffeb, 0x7ffffe6, 0x3ffffec, 0x3ffffed, 0x7ffffe7, 0x7ffffe8, 0x7ffffe9, 0x7ffffea, 0x7ffffeb, 0xffffffe, 0x7ffffec, 0x7ffffed, 0x7ffffee, 0x7ffffef, 0x7fffff0, 0x3ffffee });

        private static array<byte> huffmanCodeLen = new array<byte>(new byte[] { 13, 23, 28, 28, 28, 28, 28, 28, 28, 24, 30, 28, 28, 30, 28, 28, 28, 28, 28, 28, 28, 28, 30, 28, 28, 28, 28, 28, 28, 28, 28, 28, 6, 10, 10, 12, 13, 6, 8, 11, 10, 10, 8, 11, 8, 6, 6, 6, 5, 5, 5, 6, 6, 6, 6, 6, 6, 6, 7, 8, 15, 6, 12, 10, 13, 6, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 8, 7, 8, 13, 19, 13, 14, 6, 15, 5, 6, 5, 6, 5, 6, 6, 6, 5, 7, 7, 6, 6, 6, 5, 6, 7, 6, 5, 5, 6, 7, 7, 7, 7, 7, 15, 11, 14, 13, 28, 20, 22, 20, 20, 22, 22, 22, 23, 22, 23, 23, 23, 23, 23, 24, 23, 24, 24, 22, 23, 24, 23, 23, 23, 23, 21, 22, 23, 22, 23, 23, 24, 22, 21, 20, 22, 22, 23, 23, 21, 23, 22, 22, 24, 21, 22, 23, 23, 21, 21, 22, 21, 23, 22, 23, 23, 20, 22, 22, 22, 23, 22, 22, 23, 26, 26, 20, 19, 22, 23, 22, 25, 26, 26, 26, 27, 27, 26, 24, 25, 19, 21, 26, 27, 27, 26, 27, 24, 21, 21, 26, 26, 28, 27, 27, 27, 20, 24, 20, 21, 22, 21, 21, 23, 22, 22, 25, 25, 24, 24, 26, 23, 26, 27, 26, 26, 27, 27, 27, 27, 27, 28, 27, 27, 27, 27, 27, 26 });
    }
}}}}}}