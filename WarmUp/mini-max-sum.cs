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

class Solution {

    // Complete the miniMaxSum function below.
    static void miniMaxSum(long[] arr) {
        var ord = arr.OrderBy(o => o);
        Console.WriteLine($"{ord.Take(4).Sum()} {ord.Skip(ord.Count() - 4).Sum()}");
    }

    static void Main(string[] args) {
        long[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt64(arrTemp));
        miniMaxSum(arr);
        
    }
}
