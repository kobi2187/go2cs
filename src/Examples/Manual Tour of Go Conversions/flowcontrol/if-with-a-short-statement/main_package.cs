﻿/*
package main

import (
	"fmt"
	"math"
)

func pow(x, n, lim float64) float64 {
	if v := math.Pow(x, n); v < lim {
		return v
	}
	return lim
}

func main() {
	fmt.Println(
		pow(3, 2, 10),
		pow(3, 3, 20),
	)
}
*/
using fmt = go.fmt_package;
using math = System.Math;

static class main_package
{
	static double pow(double x, double n, double lim) {
        {
			var v = math.Pow(x, n);
            if (v < lim) {
				return v;
			}
		}
        return lim;
	}

    static void Main() {
        fmt.Println(
			pow(3, 2, 10),
			pow(3, 3, 20)
        );
    }
}
