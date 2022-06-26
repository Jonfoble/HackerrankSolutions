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
        double mealcost = Convert.ToDouble(Console.ReadLine());
        Console.Write("");
        int tippercent = Convert.ToInt32(Console.ReadLine());
        Console.Write("");
        int taxpercent = Convert.ToInt32(Console.ReadLine());


        double tip = (mealcost * tippercent / 100);
        double tax = (mealcost * taxpercent / 100);
        double totalcost = Convert.ToDouble((tip + tax + mealcost));
        Console.WriteLine(Math.Round(totalcost));
        Console.ReadLine();
        return;


    }


}