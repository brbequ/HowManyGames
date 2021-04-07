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

    // Complete the howManyGames function below.
    static int howManyGames(int p, int d, int m, int s)
    {
        // Return the number of games you can buy

        int count = 0;

        if (p > s)
            return count;

        while (s >= p)
        {
            s -= p;
            p -= d;
            if (p < m)
                p = m;
            count++;
        }

        return count;
    }

    static void Main(string[] args)
    {
        List<int[]> testcases = new List<int[]>
        {
            new int[] { 20,   3, 6,  70, 5 },
            new int[] { 20,   3, 6,  80, 6 },
            new int[] { 20,   3, 6,  85, 7 },
            new int[] { 100, 19, 1, 180, 1 }
        };

        foreach(int[] testcase in testcases)
        {
            int p = testcase[0];
            int d = testcase[1];
            int m = testcase[2];
            int s = testcase[3];

            int answer = howManyGames(p, d, m, s);

            if (answer == testcase[4])
            {
                Console.WriteLine(answer);
            }
            else
            {
                Console.WriteLine(String.Format("{0} - Expected {1}", answer, testcase[4]));
            }
        }
    }
}
