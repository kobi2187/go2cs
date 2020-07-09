﻿/*
package main

import "fmt"

type I interface {
	M()
}

func main() {
	var i I
	describe(i)
	i.M()
}

func describe(i I) {
	fmt.Printf("(%v, %T)\n", i, i)
}
*/

using go;
using static go.builtin;

partial class main_package
{
    partial interface I {
		void M();
    }

	static void Main() {
		I i = default!;
        describe(i);
		i.M();
    }

	static void describe(I i) {
		println($"({i:v}, {i:T})");
	}
}