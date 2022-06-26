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

    public static List<int> breakingRecords(List<int> scores)
    {
        List<int> res = new List<int> { 0, 0 };
        int x = res[0];
        int y = res[1];
        if (scores.Count <= 1)
        {
            return res;
        }
        int currentScore = scores[0];
        int highScore = scores[0];
        int lowestScore = scores[0];

        if (scores[1] > currentScore)
        {
            highScore = currentScore;
        }
        else if (scores[1] < currentScore)
        {
            lowestScore = currentScore;
        }

        for (int i = 0; i < scores.Count; i++)
        {
            currentScore = scores[i];

            if (currentScore > highScore)
            {
                highScore = currentScore;
                if (currentScore >= highScore)
                {
                    x++;
                }
            }
            else if (currentScore < lowestScore)
            {
                lowestScore = currentScore;
                if (currentScore <= lowestScore)
                {
                    y++;
                }
            }
        }

        res[0] = x;
        res[1] = y;
        return res;

    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> scores = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(scoresTemp => Convert.ToInt32(scoresTemp)).ToList();

        List<int> result = Result.breakingRecords(scores);

        textWriter.WriteLine(String.Join(" ", result));

        textWriter.Flush();
        textWriter.Close();
    }
}
