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

    static void Main(string[] args)
    {
        int[][] arr = new int[6][];
        int max = -80;
        int sum = 0;
        for (int i = 0; i < 6; i++)
        {
            arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
        }
        for (int j = 0; j < 4; j++)
        {
            for (int k = 0; k < 4; k++)
            {
                sum = arr[j][k] + arr[j][k + 1] + arr[j][k + 2];
                sum = sum + arr[j + 1][k + 1];
                sum = sum + arr[j + 2][k] + arr[j + 2][k + 1] + arr[j + 2][k + 2];

                if (sum > max)
                    max = sum;
            }
        }
        Console.WriteLine(max);
    }
}
