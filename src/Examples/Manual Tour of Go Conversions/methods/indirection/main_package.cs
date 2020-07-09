﻿/*
package main

import "fmt"

type Vertex struct {
	X, Y float64
}

func (v *Vertex) Scale(f float64) {
	v.X = v.X * f
	v.Y = v.Y * f
}

func ScaleFunc(v *Vertex, f float64) {
	v.X = v.X * f
	v.Y = v.Y * f
}

func main() {
	v := Vertex{3, 4}
	v.Scale(2)
	ScaleFunc(&v, 10)

	p := &Vertex{4, 3}
	p.Scale(3)
	ScaleFunc(p, 8)

	fmt.Println(v, p)
}
*/

using go;
using static go.builtin;
using fmt = go.fmt_package;
using float64 = System.Double;

static partial class main
{
    public partial struct Vertex {
        public float64 X;
        public float64 Y;
    }

    public static void Scale(this ref Vertex v, float64 f) {
        v.X = v.X * f;
        v.Y = v.Y * f;
    }

    public static void ScaleFunc(ptr<Vertex> v_ptr, float64 f)
    {
        ref var v = ref v_ptr.Value;
        v.X = v.X * f;
        v.Y = v.Y * f;
    }

    static void Main() {
        var v_ptr = ptr(new Vertex(3, 4));
        ref var v = ref v_ptr.Value;
        v.Scale(2);
        ScaleFunc(v_ptr, 10);

        var p = ptr(new Vertex(4, 3));
        p.Value.Scale(3);
        ScaleFunc(p, 8);

        fmt.Println(v, p);
    }
}