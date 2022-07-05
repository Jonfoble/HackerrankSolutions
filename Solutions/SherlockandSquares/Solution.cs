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
namespace SherlockandSquares
{
	class Solution
	{
		static void Main(string[] args)
		{
            int q = Convert.ToInt32(Console.ReadLine().Trim());
            if (q < 1 || q > 100)
            {
                System.Environment.Exit(0);
            }

            for (int qItr = 0; qItr < q; qItr++)
            {
                string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

                int a = Convert.ToInt32(firstMultipleInput[0]);

                int b = Convert.ToInt32(firstMultipleInput[1]);
                if (a < 1 || b < 1 || a > Math.Pow(10, 9) || b > Math.Pow(10, 9))
				{
                    System.Environment.Exit(0);
				}
                
                    int result = squares(a, b);

                Console.WriteLine(result);
                Console.ReadLine();
            }
        }
        public static int squares(int a, int b)
        {
            int result = 0;
            int x = 1;
            while (x * x < a)
            {
                x++;
            }
            while (x * x <= b)
            {
                result++;
                x++;
            }
            return result;
        }
    }
}
