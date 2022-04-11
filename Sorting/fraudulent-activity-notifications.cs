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
     * Complete the 'activityNotifications' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER_ARRAY expenditure
     *  2. INTEGER d
     */

    public static int activityNotifications(List<int> expenditure, int d)
    {
        int notes = 0;
        var countingData = new List<int>(new int[201]);
        
        for (var i = 0; i < d; i++)
            countingData[expenditure[i]]++;
        
        for (int i = d; i < expenditure.Count; i++) 
        {
            if (expenditure[i] >= Limit(countingData, d) * (double) 2) 
                notes++;

            countingData[expenditure[i]]++;
            countingData[expenditure[i - d]]--;
        }
                     
        return notes;
    }

    private static double Limit(List<int> values, int d)
    {
        int 
            target = d / 2 + (d % 2 == 0 ? 0 : 1),
            count = 0;
                
        if (d % 2 == 0) 
            for (int i = 0; i < values.Count; i++) 
            {
                count += values[i];

                if (count > target)
                    return (double) i;
                    
                else if (count == target) 
                    for (int j = i + 1; j < values.Count; j++)
                        if (values[j] > 0)
                            return (double) (i + j) / (double) 2;
            }
        
        else 
            for (int i = 0; i < values.Count; i++) 
            {
                count += values[i];
                
                if (count >= target)
                    return (double) i;
            }

        return -1;
    }    
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int n = Convert.ToInt32(firstMultipleInput[0]);

        int d = Convert.ToInt32(firstMultipleInput[1]);

        List<int> expenditure = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(expenditureTemp => Convert.ToInt32(expenditureTemp)).ToList();

        int result = Result.activityNotifications(expenditure, d);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
