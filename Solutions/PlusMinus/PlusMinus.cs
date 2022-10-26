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
    public static void plusMinus(List<int> arr)
    {
        int k = arr.Count;
        int positive = 0;
        int negative = 0;
        int zero = 0;

        for (int i = 0; i < k; i++)
        {
            if (arr[i] > 0)
            {
                positive++;
            }
            else if (arr[i] < 0)
            {
                negative++;
            }
            else if (arr[i] == 0)
            {
                zero++;
            }
        }
        Console.WriteLine((float)positive / k);
        Console.WriteLine((float)negative / k);
        Console.WriteLine((float)zero / k);
    }
}
class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.plusMinus(arr);
    }
}
