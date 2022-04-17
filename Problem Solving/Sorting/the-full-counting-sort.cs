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
     * Complete the 'countSort' function below.
     *
     * The function accepts 2D_STRING_ARRAY arr as parameter.
     */

    public static void countSort(List<List<string>> arr)
    {
        var max = 0;
        var lim = (arr.Count / 2);
        
        for (var i = 0; i < arr.Count; i++)
        {
            var tmp = int.Parse(arr[i][0]);
            
            if (i < lim)
                arr[i][1] = "-";
            
            if (tmp > max)
                max = tmp;
        }

        List<string>[] sort = new List<string>[++max];

        foreach (var item in arr)
        {
            var key = int.Parse(item[0]);
            
            if (sort[key] == null)
                sort[key] = new List<string>();
                
            sort[key].Add(item[1]);
        }
               
        for (var i = 0; i < sort.Length; i++)
            if (sort[i] != null)
                Console.Write($"{string.Join(" ", sort[i])} ");

        Console.WriteLine();
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<List<string>> arr = new List<List<string>>();

        for (int i = 0; i < n; i++)
        {
            arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList());
        }

        Result.countSort(arr);
    }
}
