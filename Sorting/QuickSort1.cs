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
     * Complete the 'quickSort' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static List<int> quickSort(List<int> arr)
    {
        var pivot = arr[0];
        
        List<int> 
            l = new List<int>(), 
            e = new List<int>(),
            r = new List<int>();
        
        for (var i = 0; i < arr.Count; i++)
            if (arr[i] < pivot)
                l.Add(arr[i]);
                
            else if (arr[i] == pivot)
                e.Add(arr[i]);
                
            else
                r.Add(arr[i]);
                

        l.AddRange(e);
        l.AddRange(r);
        
        return l;
    }    
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        List<int> result = Result.quickSort(arr);

        textWriter.WriteLine(String.Join(" ", result));

        textWriter.Flush();
        textWriter.Close();
    }
}
