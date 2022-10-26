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
    public static int countingValleys(int steps, string path)
    {
        int seaLevel = 0, valleyEnters = 0;
        char[] stepsArray = path.ToCharArray();

        for (int x = 0; x <= stepsArray.Length - 1; x++)
        {
            if (stepsArray[x] == 'D')
            {
                if (seaLevel == 0)
                    valleyEnters++;
                seaLevel--;
            }
            else
                seaLevel++;
        }

        return valleyEnters;
    }
}
class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int steps = Convert.ToInt32(Console.ReadLine().Trim());

        string path = Console.ReadLine();

        int result = Result.countingValleys(steps, path);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
