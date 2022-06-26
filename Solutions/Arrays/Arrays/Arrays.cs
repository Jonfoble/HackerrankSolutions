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
        int n = Convert.ToInt32(Console.ReadLine().Trim());
        Console.Write("");
        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        int L = arr.Count;
        if (n < 1 && n > 1000)
        {
            System.Environment.Exit(1);

        }
        else if (L < 1 && L > 10000)
        {
            System.Environment.Exit(1);
        }

        while (n >= 1)
        {
            Console.Write(arr[--n] + " ");

        }
        Console.Read();

    }




}





