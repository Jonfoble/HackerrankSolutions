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

class Result
{
    public static void miniMaxSum(List<int> arr)
    {


        arr.Sort();
        long toplamin = 0;
        long toplamax = 0;
        for (int i = 0; i < 4; i++)
        {
            toplamin += arr[i];

        }
        for (int j = 4; j > 0; j--)
        {
            toplamax += arr[j];
        }
        List<long> result = new List<long>(3);
        result.Add(0);
        result.Add(0);
        result[0] = toplamin;
        result[1] = toplamax;
        foreach (long item in result)
        {
            Console.Write(item);
            Console.Write(" ");
        }
    }

}

class Solution
{
    public static void Main(string[] args)
    {

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.miniMaxSum(arr);
    }
}
