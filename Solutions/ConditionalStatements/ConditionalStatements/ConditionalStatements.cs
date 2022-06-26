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
        int N = Convert.ToInt32(Console.ReadLine().Trim());
        String Result;



        if (N % 2 != 0)
        {
            Result = "Weird";
        }
        else if (N >= 2 && N <= 5)
        {
            Result = "Not Weird";
        }
        else if (N >= 6 && N <= 20)
        {
            Result = "Weird";
        }
        else if (N >= 20)
        {
            Result = "Not Weird";
        }
        else
        {
            Result = "Not Weird";
        }

        Console.Write(Result);
        Console.ReadLine();
    }
}
