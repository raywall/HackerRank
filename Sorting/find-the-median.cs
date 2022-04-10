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
     * Complete the 'findMedian' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static int findMedian(List<int> arr)
    {
        return Median(Sort(arr, 0, arr.Count - 1));
    }

    private static int Median(List<int> arr)
    {
        if (arr.Count % 2 != 0)
            return arr[((arr.Count - 1) / 2)];
            
        else
        {
            var middle = arr.Count / 2;
            var median = (arr[middle - 1] + arr[middle]) / 2;
            
            return median;
        }
    }

    private static List<int> Sort(List<int> arr, int left, int right)
    {
        int 
            l = left,
            r = right;
            
        int pivot = arr[(left + right) / 2];
        
        while (true)
        {
            while (l >= 0 && arr[l] < pivot)
                l++;
                
            while (r >= 0 && arr[r] > pivot)
                r--;
            
            if (l <= r)
            {
                var tmp = arr[r];
                arr[r] = arr[l];
                arr[l] = tmp;
                
                l++;
                r--;
            }
            
            else
                break;
        }   
        
        if (left < r)
            Sort(arr, left, r);
            
        if (l < right)
            Sort(arr, l, right);
            
        return arr;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        int result = Result.findMedian(arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
