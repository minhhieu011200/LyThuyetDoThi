﻿using System;

namespace Bai1
{
    class Program
    {
        static void Main(string[] args)
        {
            Graph graph = new Graph();
            graph.ReadData("LIENTHONG.INP");
            graph.WriteData();
            graph.LienThong("LIENTHONG.OUT");
        }
    }
}
