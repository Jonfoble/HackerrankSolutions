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

    public static List<int> gradingStudents(List<int> grades)
    {

        bool failing = false;
        bool roundable = false;
        for (int i = 0; i < grades.Count; i++)
        {
            if (grades[i] < 0 || grades[i] > 100 || grades.Count < 1 || grades.Count > 60)
            {
                System.Environment.Exit(1);
            }
            int x = (grades[i] + 5) / 5 * 5;
            if (grades[i] < 38)
            {
                failing = true;
            }
            else if (grades[i] >= 38)
            {
                failing = false;
            }
            if (failing)
            {
                roundable = false;
            }
            if (!failing)
            {
                roundable = true;
            }
            if (roundable && (x - grades[i]) < 3)
            {
                grades[i] = x;
            }
        }
        return grades;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int gradesCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> grades = new List<int>();

        for (int i = 0; i < gradesCount; i++)
        {
            int gradesItem = Convert.ToInt32(Console.ReadLine().Trim());
            grades.Add(gradesItem);
        }

        List<int> result = Result.gradingStudents(grades);

        textWriter.WriteLine(String.Join("\n", result));

        textWriter.Flush();
        textWriter.Close();
    }
}
