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
using System.Numerics;
class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());
        Console.WriteLine(factorial(n));
    }
    public static BigInteger factorial(BigInteger x)
    {


        BigInteger result = 0;

        if (x < 1)
        {
            return 1;
        }

        result = x * factorial(x - 1);

        return result;
    }
}
