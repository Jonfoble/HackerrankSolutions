using System;
using System.Collections.Generic;
using System.IO;

class Solution
{
    static void Main(String[] args)
    {
        int i = 4;
        double d = 4.0;
        string s = "HackerRank ";
        Console.Write("");
        int i2 = Convert.ToInt32(Console.ReadLine());
        Console.Write(i2 + i);
        Console.WriteLine("");
        double d2 = Convert.ToDouble(Console.ReadLine());
        Console.Write((d + d2).ToString("0.0"));
        Console.WriteLine("");
        String s2 = Convert.ToString(Console.ReadLine());
        Console.Write(s + s2);
        Console.ReadLine();

        return;
    }
}