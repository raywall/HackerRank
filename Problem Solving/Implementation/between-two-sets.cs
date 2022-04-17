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
     * Complete the 'getTotalX' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER_ARRAY a
     *  2. INTEGER_ARRAY b
     */

    public static int getTotalX(List<int> a, List<int> b)
    {
        int result = 0;

        // Get LCM of all elements of a
        int lcm = a[0];
        foreach (var integer in a)
            lcm = getLCM(lcm, integer);

        // Get GCD of all elements of b
        int gcd = b[0];
        foreach (var integer in b)
            gcd = getGCD(gcd, integer);

        // Count multiples of lcm that divide the gcd
        int multiple = 0;
        while (multiple <= gcd) 
        {
            multiple += lcm;

            if (gcd % multiple == 0)
                result++;
        }

        return result;
    }
    
    private static int getGCD(int n1, int n2) 
    {
        if (n2 == 0)
            return n1;

        return getGCD(n2, n1 % n2);
    }

    private static int getLCM(int n1, int n2) 
    {
        if (n1 == 0 || n2 == 0)
            return 0;
      
        else 
        {
            int gcd = getGCD(n1, n2);
            return Math.Abs(n1 * n2) / gcd;
        }
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int n = Convert.ToInt32(firstMultipleInput[0]);

        int m = Convert.ToInt32(firstMultipleInput[1]);

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        List<int> brr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(brrTemp => Convert.ToInt32(brrTemp)).ToList();

        int total = Result.getTotalX(arr, brr);

        textWriter.WriteLine(total);

        textWriter.Flush();
        textWriter.Close();
    }
}
