using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {

    /*
     * Complete the timeConversion function below.
     */
    static string timeConversion(string s) {
        int.TryParse(s.Split(':').First(), out int hour);

        if (s.Contains("AM"))
            return $"{(hour == 12 ? "00" : hour.ToString().PadLeft(2, '0'))}{s.Substring(2).Replace("AM", "")}";

        else
            return $"{(hour == 12 ? "12" : (hour + 12).ToString())}{s.Substring(2).Replace("PM", "")}";
    }

    static void Main(string[] args) {
        TextWriter tw = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = timeConversion(s);

        tw.WriteLine(result);

        tw.Flush();
        tw.Close();
    }
}
