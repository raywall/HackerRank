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
     * Complete the 'gridChallenge' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING_ARRAY grid as parameter.
     */

    public static string gridChallenge(List<string> grid)
    {
        var data = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
        var values = new Dictionary<char, int>();
        var content = new List<List<char>>();
        
        for (int i = 0; i < data.Length; i++)
            values.Add(data[i], i);
        
        for (int l = 0; l < grid.Count; l++)
        {
            var list = new List<char>();
            var temp = grid[l].Trim().ToCharArray();
            
            Array.Sort(temp);
            
            for (int c = 0; c < temp.Length; c++)
                list.Add(temp[c]);
                
            content.Add(list);
        }
        
        for (int c = 0; c < content[0].Count; c++)
            for (int l = 0; l < content.Count - 1; l++)
                if (values[content[l + 1][c]] < values[content[l][c]])
                    return "NO";
        
        return "YES";
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int t = Convert.ToInt32(Console.ReadLine().Trim());

        for (int tItr = 0; tItr < t; tItr++)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<string> grid = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string gridItem = Console.ReadLine();
                grid.Add(gridItem);
            }

            string result = Result.gridChallenge(grid);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
