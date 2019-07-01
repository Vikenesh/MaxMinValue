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

    // Complete the miniMaxSum function below.
    static void miniMaxSum(int[] arr)
    {
        long sum = 0;
        List<long> finalSumList = new List<long>();
        long maxValue = 0;
        long minValue = 0;

        for (int i=0;i<arr.Length;i++)
        {
            sum = arr.Sum(x => (long)x) - arr[i];
            finalSumList.Add(sum);

        }

        maxValue = finalSumList.Max();

        minValue = finalSumList.Min();

        Console.WriteLine(maxValue+" "+minValue);
    }

    static void Main(string[] args)
    {
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        miniMaxSum(arr);
    }
}
