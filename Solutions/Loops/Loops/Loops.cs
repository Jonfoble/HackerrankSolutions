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
        IEnumerable<int> S = System.Linq.Enumerable.Range(1, 10).Select(Q => Q * n);

        foreach (int num in S)
        {

            Console.WriteLine(n + " x " + (num / n) + " = " + num);

        }
        Console.ReadLine();
    }
}
