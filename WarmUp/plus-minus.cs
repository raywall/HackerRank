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

    // Complete the plusMinus function below.
    static void plusMinus(int[] arr) {
        Console.WriteLine((float)arr.Where(w => w > 0).ToList().Count() / arr.Count());
        Console.WriteLine((float)arr.Where(w => w < 0).ToList().Count() / arr.Count());
        Console.WriteLine((float)arr.Where(w => w == 0).ToList().Count() / arr.Count());
    }

    static void Main(string[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
        plusMinus(arr);
    }
}
