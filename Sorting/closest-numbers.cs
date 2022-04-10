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
     * Complete the 'closestNumbers' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static List<int> closestNumbers(List<int> arr)
    {
        var sorted = Sort(arr, 0, arr.Count - 1);
        var result = new List<int>();
        
        var min = Math.Abs(arr[1] - arr[0]);
        
        int 
            i = 0,
            j = 0;
        
        for (i = 0, j = i + 1; j < arr.Count; i++, j++)
        {
            var dif = Math.Abs(arr[j] - arr[i]);
            
            if (dif < min)
            {
                min = dif;
                result.Clear();
                result.AddRange(new int[] { arr[i], arr[j] });
            }
            
            else if (dif == min)
                result.AddRange(new int[] { arr[i], arr[j] });
        }

        return result;
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
                var tmp = arr[l];
                arr[l] = arr[r];
                arr[r] = tmp;
                
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

        List<int> result = Result.closestNumbers(arr);

        textWriter.WriteLine(String.Join(" ", result));

        textWriter.Flush();
        textWriter.Close();
    }
}
