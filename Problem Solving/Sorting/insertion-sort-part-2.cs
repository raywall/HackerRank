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

    /*
     * Complete the 'insertionSort2' function below.
     *
     * The function accepts following parameters:
     *  1. INTEGER n
     *  2. INTEGER_ARRAY arr
     */

    public static void insertionSort2(int n, List<int> arr)
    {
        int 
            a = 0,
            b = 0;

        for (a = 0, b = a + 1; b < arr.Count; a++, b++)
        {
            int tmp = arr[b];
            int i = a;
            
            while (i >= 0 && tmp < arr[i])
                arr[i + 1] = arr[i--];
            
            arr[i + 1] = tmp;
            
            for (int j = 0; j < arr.Count; j++)
                Console.Write($"{arr[j]} ");
                
            Console.WriteLine();
        }
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.insertionSort2(n, arr);
    }
}
