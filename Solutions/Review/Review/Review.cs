using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    static void Main(String[] args)
    {


        int fuc = Convert.ToInt32(Console.ReadLine());
        string[] strings = new string[fuc];
        int p = 0;
        while (p < fuc)//Kek Loop
        {
            strings[p] = Console.ReadLine();
            p++;
        }
        foreach (string a in strings)//Pog loop
        {
            string evens = "";
            string odds = "";
            bool isEven = true;
            for (int i = 0; i < a.Length; i++)
            {
                if (isEven) evens += a[i];
                else odds += a[i];

                isEven = !isEven;
            }
            Console.WriteLine($"{evens} {odds}");
            Console.ReadLine();
        }



    }
}
