﻿using System;
using System.Linq;

namespace Utility
{
    public class Util
    {
        public static string PadBoth(string source, int length, int disp, bool neg)
        {
            int spaces = length - source.Length + 2;
            int padLeft = (int)(spaces * 0.5f) + source.Length;
            string ws;

            if (neg)
            {
                ws = string.Join("", Enumerable.Repeat(" ", disp - 1));
                return (ws + source).PadLeft(padLeft - disp).PadRight(length);
            }

            ws = string.Join("", Enumerable.Repeat(" ", disp));
            return (ws + source).PadLeft(padLeft - disp).PadRight(length);
        }





    }
}
