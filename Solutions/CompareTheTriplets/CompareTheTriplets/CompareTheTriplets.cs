﻿using System.CodeDom.Compiler;
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

class Result
{

    public static List<int> compareTriplets(List<int> a, List<int> b)
    {



        List<int> result = new List<int>(2);
        result.Add(0);
        result.Add(0);

        for (int i = 0; i < 3; i++)
        {
            if (a[i] >= 100 || a[i] <= 1 || b[i] >= 100 || b[i] <= 1)
            {
                break;
            }

            if (a[i] > b[i])
            {
                result[0]++;
            }
            else if (a[i] < b[i])
            {
                result[1]++;
            }

        }

        return result;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

        List<int> b = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(bTemp => Convert.ToInt32(bTemp)).ToList();

        List<int> result = Result.compareTriplets(a, b);

        textWriter.WriteLine(String.Join(" ", result));

        textWriter.Flush();
        textWriter.Close();
    }
}
