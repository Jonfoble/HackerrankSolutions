using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;



class Solution
{
    public static void Main(string[] args)
    {
        Console.Write("");
        int n = Convert.ToInt32(Console.ReadLine());
        if (n < 1 || n > 1000000)
        {

            System.Environment.Exit(1);

        }
        var a = Convert.ToString(n, 2);
        string[] binary = a.Split('0').ToArray();
        int c = binary.Select(x => x.Length).Max();
        Console.Write(c);
        Console.ReadLine();

    }
}
