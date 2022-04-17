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
     * Complete the 'insertionSort1' function below.
     *
     * The function accepts following parameters:
     *  1. INTEGER n
     *  2. INTEGER_ARRAY arr
     */

    public static void insertionSort1(int n, List<int> arr)
    {
        int 
            among = 0, 
            index = 0;
        
        for (var i = 1; i < arr.Count; i++)
            if (arr[i] < arr[i - 1])
            {
                among = arr[i];
                index = i;
            }
        
        for (var i = index; i >= 0; i--)
            if (i == 0)
            {
                arr[0] = among;
                break;
            }
            
            else if (arr[i - 1] < among)
            {
                arr[i] = among;
                break;
            }
            
            else
            {
                arr[i] = arr[i - 1];
                Console.WriteLine(string.Join(" ", arr));
            }
            
        Console.WriteLine(string.Join(" ", arr));
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.insertionSort1(n, arr);
    }
}
