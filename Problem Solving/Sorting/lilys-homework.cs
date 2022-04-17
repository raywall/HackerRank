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
        * Complete the 'lilysHomework' function below.
        *
        * The function is expected to return an INTEGER.
        * The function accepts INTEGER_ARRAY arr as parameter.
        */

    public static int lilysHomework(List<long> arr)
    {
        var reverseArr = arr.Select(s => s).ToList();
        reverseArr.Reverse();

        return Math.Min(Swaps(arr), Swaps(reverseArr));
    }

    private static int Swaps(List<long> unsorted, bool reverse = false)
    {
        var positions = new Dictionary<long, int>();
        var sorted = new List<long>();
        var count = 0;

        for (var i = 0; i < unsorted.Count; i++)
        {
            positions.Add(unsorted[i], i);
            sorted.Add(unsorted[i]);
        }

        sorted.Sort();

        for (var i = 0; i < sorted.Count; i++)
            if (sorted[i] != unsorted[i])
            {
                var pos = positions[sorted[i]];
                positions[unsorted[i]] = pos;

                var tmp = unsorted[i];
                unsorted[i] = unsorted[pos];
                unsorted[pos] = tmp;

                count++;
            }

        return count;
    }

    public static List<long> Reverse(List<long> arr)
    {
        var res = new List<long>();

        for (var i = arr.Count - 1; i >= 0; i--)
            res.Add(arr[i]);

        return res;
    }

    internal static int lilysHomework(object v)
    {
        throw new NotImplementedException();
    }
}
    
class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        long n = Convert.ToInt64(Console.ReadLine().Trim());

        List<long> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt64(arrTemp)).ToList();

        int result = Result.lilysHomework(arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}