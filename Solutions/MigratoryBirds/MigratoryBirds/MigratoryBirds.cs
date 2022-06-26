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
    public static int migratoryBirds(List<int> arr)
    {
        int[] repeated = { 1, 2, 3, 4, 5 };

        int repeatedNumber1 = 0;
        int repeatedNumber2 = 0;
        int repeatedNumber3 = 0;
        int repeatedNumber4 = 0;
        int repeatedNumber5 = 0;

        int lastResult = 0;


        for (int i = 0; i < arr.Count; i++)
        {

            if (arr[i] == repeated[0])
            {
                repeatedNumber1++;
            }
            else if (arr[i] == repeated[1])
            {
                repeatedNumber2++;
            }
            else if (arr[i] == repeated[2])
            {
                repeatedNumber3++;
            }
            else if (arr[i] == repeated[3])
            {
                repeatedNumber4++;
            }
            else if (arr[i] == repeated[4])
            {
                repeatedNumber5++;
            }
        }

        int[] output = { repeatedNumber1, repeatedNumber2, repeatedNumber3, repeatedNumber4, repeatedNumber5 };
        int result = output.Max();
        if (result == repeatedNumber1)
        {
            lastResult = 1;
        }
        else if (result == repeatedNumber2)
        {
            lastResult = 2;
        }
        else if (result == repeatedNumber3)
        {
            lastResult = 3;
        }
        else if (result == repeatedNumber4)
        {
            lastResult = 4;
        }
        else if (result == repeatedNumber5)
        {
            lastResult = 5;
        }

        return lastResult;


    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int arrCount = Convert.ToInt32(Console.ReadLine().Trim());


        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        int result = Result.migratoryBirds(arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
